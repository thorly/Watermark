using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;

using ImageMagick;
using System.Linq;
using System.ComponentModel;
using System.Drawing;
using System.Threading;


namespace Watermark
{
    public partial class MainForm : Form
    {
        private List<string> cameraItems = new List<string>()
        {
            "相机制造商",
            "相机型号",
            "镜头型号",
            "焦距+光圈+快门+ISO",
            "拍摄时间"
        };

        /// <summary>
        /// logo字典
        /// </summary>
        private readonly Dictionary<string, string> logoDict = new Dictionary<string, string>()
        {
            {"NIKON", @"./logos/nikon.png"},
            {"APPLE", @"./logos/apple.png"},
            {"FUJIFILM", @"./logos/fujifilm.png" }
        };

        public MainForm()
        {
            InitializeComponent();

            #region 初始化样式1

            this.comboBoxLogo1.Items.Add("左侧");
            this.comboBoxLogo1.Items.Add("右侧");
            this.comboBoxLogo1.Items.Add("不添加");

            foreach (var item in cameraItems)
            {
                this.comboBoxUpperLeft1.Items.Add(item);
                this.comboBoxUpperRight1.Items.Add(item);
                this.comboBoxLowerLeft1.Items.Add(item);
                this.comboBoxLowerRight1.Items.Add(item);
            }

            //设置默认选择项
            this.comboBoxUpperLeft1.SelectedIndex = 1;     //相机型号
            this.comboBoxUpperRight1.SelectedIndex = 3;    //焦距+光圈+快门+ISO
            this.comboBoxLowerLeft1.SelectedIndex = 2;     //镜头型号
            this.comboBoxLowerRight1.SelectedIndex = 4;    //拍摄时间

            comboBoxLogo1.SelectedIndex = 1;

            #endregion


            #region 初始化样式2

            foreach (var item in cameraItems)
            {
                this.comboBoxFirstLine1.Items.Add(item);
                this.comboBoxFirstLine2.Items.Add(item);
            }

            this.comboBoxFirstLineLogo.Items.Add("左侧");
            this.comboBoxFirstLineLogo.Items.Add("不添加");

            //设置默认选择项
            this.comboBoxFirstLine1.SelectedIndex = 1;
            this.comboBoxFirstLine2.SelectedIndex = 3;
            this.comboBoxFirstLineLogo.SelectedIndex = 0;

            #endregion


            //测试用
            //this.InputTextBox.Text = @"D:\Watermark\jpg";
            //this.OutputTextBox.Text = @"D:\Watermark\jpg_res";


            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;

            this.backgroundWorker.DoWork += BackgroundWorker_DoWork;
            this.backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
            this.backgroundWorker.ProgressChanged += BackgroundWorker_ProgressChanged;

        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.progressBar.Maximum = (int)e.UserState;
            this.progressBar.Value = e.ProgressPercentage;
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.RunButton.Enabled = true;
            //MessageBox.Show("处理完成！", "提示");
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker backgroundWorker = sender as BackgroundWorker;

            Dictionary<string, string> parm = (Dictionary<string, string>)e.Argument;

            parm.TryGetValue("input", out string inputPath);
            parm.TryGetValue("output", out string outputPath);
            parm.TryGetValue("flag", out string flag);

            List<string> images = GetAllImages(inputPath, Convert.ToBoolean(flag));

            int imageCount = images.Count;

            if (imageCount == 0)
            {
                MessageBox.Show("没有需要处理的图片，请检查路径！", "提示");
            }
            else
            {
                for (int i = 0; i < imageCount; i++)
                {
                    FileInfo file = new FileInfo(images[i]);

                    //添加水印后的图片名称
                    string outputImagePath = outputPath + "\\" + Path.GetFileNameWithoutExtension(file.ToString()) + ".JPG";

                    using (var inputImage = new MagickImage(file))
                    {
                        //获取图片exif信息
                        var profile = inputImage.GetExifProfile();

                        int width = inputImage.Width;    //原始图片宽度
                        int height = inputImage.Height;   //原始图片高度

                        #region 参数配置

                        int refValue = Convert.ToInt16(0.015 * Math.Max(width, height));
                        int margin = refValue;   //边缘宽度
                        var watermarkColor = new MagickColor("#ffffff");       //水印边框颜色

                        int fontSize = refValue;     //字体大小
                        int lineGap = Convert.ToInt16(fontSize / 4);   //字体行间距
                        var fontColor = MagickColors.Black;        //字体颜色
                        string fontBold = @"./fonts/MonaspaceNeon-Bold.otf";         //粗字体
                        string fontLight = @"./fonts/MonaspaceNeon-Light.otf";       //细字体

                        int logoHeight = 2 * fontSize + lineGap;   //logo大小

                        #endregion

                        //获取选中tabPage的index
                        parm.TryGetValue("tabPage", out string tabPageIndex);

                        //样式1
                        if (tabPageIndex == "0")
                        {
                            //创建一张画布，用于放置原始图片和水印
                            int newImageWidth = width + 2 * margin;
                            int newImageHeight = height + 2 * margin + 4 * refValue;

                            using (var newImage = new MagickImage(watermarkColor, newImageWidth, newImageHeight))
                            {
                                //将原始图片放置于白色画布
                                newImage.Composite(inputImage, margin, margin);

                                //将原始图片的exif信息写入到白色画布，防止exif信息丢失
                                newImage.SetProfile(profile);

                                //设置分辨率
                                newImage.Density = inputImage.Density;

                                //获取图片参数 
                                var imageParmDict = GetImageParmFromExifProfile(profile);

                                //左上角参数
                                int upperLeftIndex = Convert.ToInt16(parm["upperLeft"]);
                                string upperLeftParm = GetParmUsingImageParmAndIndex(imageParmDict, upperLeftIndex);
                                var upperLeftSize = GetTextSize(upperLeftParm, fontBold, fontSize);
                                double upperLeftWidth = upperLeftSize.TextWidth;

                                //左下角参数
                                int lowerLeftIndex = Convert.ToInt16(parm["lowerLeft"]);
                                string lowerLeftParm = GetParmUsingImageParmAndIndex(imageParmDict, lowerLeftIndex);
                                double lowerLeftWidth = GetTextSize(lowerLeftParm, fontLight, fontSize).TextWidth;

                                //右上角参数
                                int upperRightIndex = Convert.ToInt16(parm["upperRight"]);
                                string upperRightParm = GetParmUsingImageParmAndIndex(imageParmDict, upperRightIndex);
                                double upperRightWidth = GetTextSize(upperRightParm, fontBold, fontSize).TextWidth;

                                //右下角参数
                                int lowerRightIndex = Convert.ToInt16(parm["lowerRight"]);
                                string lowerRightParm = GetParmUsingImageParmAndIndex(imageParmDict, lowerRightIndex);
                                double lowerRightWidth = GetTextSize(lowerRightParm, fontLight, fontSize).TextWidth;

                                //添加logo
                                int logoIndex = Convert.ToInt16(parm["logo"]);
                                logoDict.TryGetValue(imageParmDict["CameraMake"].ToUpper(), out string logo);

                                //左侧文字和右侧文字的X坐标
                                int leftFontX = margin + refValue;

                                var temp = Math.Max(upperRightWidth, lowerRightWidth);
                                int rightFontX = Convert.ToInt16(newImageWidth - margin - refValue - temp);

                                //第一行文字和第二行文字的Y坐标
                                int upperFontY = Convert.ToInt16((newImageHeight + height + margin - lineGap) / 2);
                                int lowerFontY = Convert.ToInt16(upperFontY + lineGap + upperLeftSize.TextHeight);

                                //logo的Y坐标
                                int logoY = lowerFontY - logoHeight;

                                if (logoIndex == 0)   //左侧
                                {
                                    int logoX = 2 * margin;

                                    using (var logoImage = new MagickImage(logo))
                                    {
                                        //resize
                                        logoImage.Resize(0, logoHeight);

                                        //添加
                                        newImage.Composite(logoImage, logoX, logoY);

                                        leftFontX = logoX + logoImage.Width + 4 * lineGap;
                                    }
                                }

                                if (logoIndex == 1)        //右侧
                                {
                                    using (var logoImage = new MagickImage(logo))
                                    {
                                        //resize
                                        logoImage.Resize(0, logoHeight);

                                        int logoX = Convert.ToInt16(rightFontX - logoImage.Width - lineGap * 4);

                                        //添加
                                        newImage.Composite(logoImage, logoX, logoY);
                                    }
                                }

                                //添加左上角文字
                                if (upperLeftParm.Length > 0)
                                {
                                    new Drawables()
                                    .FontPointSize(fontSize)
                                    .Font(fontBold)
                                    .FillColor(fontColor)
                                    .Text(leftFontX, upperFontY, upperLeftParm)
                                    .Draw(newImage);
                                }

                                //添加左下角文字
                                if (lowerLeftParm.Length > 0)
                                {
                                    new Drawables()
                                    .FontPointSize(fontSize)
                                    .Font(fontLight)
                                    .FillColor(fontColor)
                                    .Text(leftFontX, lowerFontY, lowerLeftParm)
                                    .Draw(newImage);
                                }

                                //添加右上角文字
                                if (upperRightParm.Length > 0)
                                {
                                    new Drawables()
                                    .FontPointSize(fontSize)
                                    .Font(fontBold)
                                    .FillColor(fontColor)
                                    .TextAlignment(TextAlignment.Left)
                                    .Text(rightFontX, upperFontY, upperRightParm)
                                    .Draw(newImage);
                                }

                                //添加右下角文字
                                if (lowerRightParm.Length > 0)
                                {
                                    new Drawables()
                                        .FontPointSize(fontSize)
                                        .Font(fontLight)
                                        .FillColor(fontColor)
                                        .TextAlignment(TextAlignment.Left)
                                        .Text(rightFontX, lowerFontY, lowerRightParm)
                                        .Draw(newImage);
                                }

                                //输出图片
                                newImage.Write(outputImagePath);
                            }
                        }

                        //样式2
                        if (tabPageIndex == "1")
                        {
                            string font = parm["font"];

                            //未设置字体则使用默认字体
                            if (font == "")
                            {
                                font = fontLight;
                            }

                            //创建一张画布，用于放置原始图片和水印
                            int newImageWidth = width + 2 * margin;
                            int newImageHeight = height + 2 * margin + 4 * refValue;

                            using (var newImage = new MagickImage(watermarkColor, newImageWidth, newImageHeight))
                            {
                                //将原始图片放置于白色画布
                                newImage.Composite(inputImage, margin, margin);

                                //将原始图片的exif信息写入到白色画布，防止exif信息丢失
                                newImage.SetProfile(profile);

                                //设置分辨率
                                newImage.Density = inputImage.Density;

                                //获取图片参数 
                                var imageParmDict = GetImageParmFromExifProfile(profile);

                                //添加logo
                                int logoIndex = Convert.ToInt16(parm["logo"]);
                                logoDict.TryGetValue(imageParmDict["CameraMake"].ToUpper(), out string logo);

                                //第一行参数
                                int firstLineIndex1 = Convert.ToInt16(parm["firstLine1"]);
                                int firstLineIndex2 = Convert.ToInt16(parm["firstLine2"]);

                                string firstLineParm1 = GetParmUsingImageParmAndIndex(imageParmDict, firstLineIndex1);
                                string firstLineParm2 = GetParmUsingImageParmAndIndex(imageParmDict, firstLineIndex2);
                                string firstLIneParm3 = parm["firstLine3"];

                                string firstLineParm = firstLineParm1 + " | " + firstLineParm2;

                                //若设置了自定义内容，则添加
                                if (firstLIneParm3.Length > 0)
                                {
                                    firstLineParm += " | " + firstLIneParm3;
                                }

                                var textSize = GetTextSize(firstLineParm, font, fontSize);
                                double firstLineWidth = textSize.TextWidth;
                                double firstLineHeight = textSize.TextHeight;

                                //第一行文字坐标
                                int firstLineX = Convert.ToInt16((newImageWidth - firstLineWidth) / 2);
                                int firstLineY = Convert.ToInt16((newImageHeight + height + margin + fontSize) / 2);

                                //logo的Y坐标
                                int logoY = Convert.ToInt16((newImageHeight + height + margin - logoHeight) / 2);

                                if (logoIndex == 0)   //左侧
                                {
                                    using (var logoImage = new MagickImage(logo))
                                    {
                                        //resize
                                        logoImage.Resize(0, logoHeight);

                                        int logoX = Convert.ToInt16((newImageWidth - firstLineWidth - logoImage.Width - 4 * lineGap) / 2);

                                        //添加
                                        newImage.Composite(logoImage, logoX, logoY);

                                        firstLineX = logoX + logoImage.Width + 4 * lineGap;
                                    }
                                }

                                //添加第一行文字
                                if (firstLineParm != null)
                                {
                                    new Drawables()
                                    .FontPointSize(fontSize)
                                    .Font(font)
                                    .FillColor(fontColor)
                                    .Text(firstLineX, firstLineY, firstLineParm)
                                    .Draw(newImage);
                                }

                                //输出图片
                                newImage.Write(outputImagePath);
                            }
                        }

                        //样式3
                        if (tabPageIndex == "2")
                        {
                            //创建一张画布，用于放置原始图片和水印
                            int newImageWidth = width + 2 * margin;
                            int newImageHeight = height + 2 * margin;

                            string color = parm["color"];

                            //未设置颜色则使用默认颜色
                            if (color == "")
                            {
                                color = "White";
                            }

                            watermarkColor = new MagickColor(color);

                            using (var newImage = new MagickImage(watermarkColor, newImageWidth, newImageHeight))
                            {
                                //将原始图片放置于白色画布
                                newImage.Composite(inputImage, margin, margin);

                                //将原始图片的exif信息写入到白色画布，防止exif信息丢失
                                newImage.SetProfile(profile);

                                //设置分辨率
                                newImage.Density = inputImage.Density;

                                //输出图片
                                newImage.Write(outputImagePath);
                            }
                        }
                    }

                    //使用backgroundWorker传输进度
                    backgroundWorker.ReportProgress(i + 1, imageCount);
                }
            }
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            if (checkBoxFlag.Checked)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "图片|*.JPG|图片|*.HEIC",
                    Title = "选择图片",
                    Multiselect = true
                };

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] fileNames = openFileDialog.FileNames;
                    InputTextBox.Text = String.Join(";", fileNames);
                }
            }
            else
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog
                {
                    Description = "选择图片文件夹"
                };

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string path = dialog.SelectedPath;
                    InputTextBox.Text = path;
                }
            }
            
            
        }

        private void OutputButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog
            {
                Description = "选择输出文件夹"
            };

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string savePath = dialog.SelectedPath;
                OutputTextBox.Text = savePath;
            }
        }

        /// <summary>
        /// 获取图片路径
        /// </summary>
        /// <param name="inputPath"></param>
        /// <param name="flag"></param>
        /// <returns></returns>
        private List<string> GetAllImages(string inputPath, bool flag)
        {
            List<string> images = new List<string>();

            if (flag)        //图片模式
            {
                images = Regex.Split(inputPath, ";").ToList();
            }
            else       //文件夹模式
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(inputPath);
                FileInfo[] files = directoryInfo.GetFiles();

                foreach(FileInfo file in files)
                {
                    if (file.Extension == ".JPG" || file.Extension == ".JPEG")
                    {
                        images.Add(inputPath + "\\" + file.Name);
                    }
                }
            }

            return images;
        }

        /// <summary>
        /// 获取字符串的宽度和高度
        /// </summary>
        /// <param name="text">字符串</param>
        /// <param name="font">字体</param>
        /// <param name="fontSize">字体大小</param>
        /// <returns></returns>
        private ITypeMetric GetTextSize(string text, string font, int fontSize)
        {
            var textSize = new Drawables()
                    .FontPointSize(fontSize)
                    .Font(font)
                    .FontTypeMetrics(text, true);

            return textSize;
        }

        /// <summary>
        /// 从ExifProfile钟获取图片参数
        /// </summary>
        /// <param name="profile"></param>
        /// <returns></returns>
        private Dictionary<string, string> GetImageParmFromExifProfile(IExifProfile profile)
        {
            Dictionary<string, string> imageParmDict = new Dictionary<string, string>();

            //获取参数
            var cameraMake = profile.GetValue(ExifTag.Make).ToString();   //相机制造商
            if (cameraMake != null)
            {
                cameraMake = Regex.Split(cameraMake, " ")[0];
            }

            var cameraModel = profile.GetValue(ExifTag.Model);   //相机型号
            var lensModel = profile.GetValue(ExifTag.LensModel);     //镜头制造商

            var exposureTime = profile.GetValue(ExifTag.ExposureTime);    //曝光时间

            var focalLength = profile.GetValue(ExifTag.FocalLength);     //焦距
            var focalLengthIn35mmFilm = profile.GetValue(ExifTag.FocalLengthIn35mmFilm);   //35mm等效焦距

            //拍摄时间
            var formatShotTime = "";
            var shotTime = profile.GetValue(ExifTag.DateTimeOriginal);
            if (shotTime != null)
            {
                DateTime dt = DateTime.ParseExact(shotTime.ToString(), "yyyy:MM:dd HH:mm:ss", System.Globalization.CultureInfo.CurrentCulture);
                //formatShotTime = dt.ToString("yyyy-MM-dd HH:mm:ss");
                formatShotTime = dt.ToString("yyyy-MM-dd");
            }

            var fNumber = profile.GetValue(ExifTag.FNumber);           //光圈大小

            //获取ISO
            var ISOSpeedRatings = "";
            var iso = profile.GetValue(ExifTag.ISOSpeedRatings);
            if (iso != null)
            {
                var res = (Array)iso.GetValue();
                if (res != null)
                {
                    ISOSpeedRatings = Convert.ToString(res.GetValue(0));
                }
            }

            //赋值
            imageParmDict["CameraMake"] = cameraMake;
            imageParmDict["CameraModel"] = (cameraModel != null) ? cameraModel.ToString() : "";
            imageParmDict["LensModel"] = (lensModel != null) ? lensModel.ToString() : "";
            imageParmDict["ExposureTime"] = (exposureTime != null)? exposureTime.ToString() : "";
            imageParmDict["FocalLength"] = (focalLength != null)? focalLength.ToString() : "";
            imageParmDict["FocalLengthIn35mmFilm"] = (focalLengthIn35mmFilm != null)? focalLengthIn35mmFilm.ToString() : "";
            imageParmDict["ShotTime"] = formatShotTime;
            imageParmDict["ISOSpeedRatings"] = ISOSpeedRatings;
            imageParmDict["FNumber"] = (fNumber != null)? fNumber.ToString() : "";

            return imageParmDict;
        }

        /// <summary>
        /// 根据ComboBox的SelectedIndex获取相应的值
        /// </summary>
        /// <param name="imageParmDict"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        private string GetParmUsingImageParmAndIndex(Dictionary<string, string> imageParmDict, int index)
        {
            //"相机制造商" , 0
            //"相机型号", 1
            //"镜头型号", 2
            //"焦距+光圈+快门+ISO", 3
            //"拍摄时间", 4

            string parm = "";
            
            switch(index)
            {
                case 0:
                    parm = imageParmDict["CameraMake"];
                    break;
                case 1:
                    parm = imageParmDict["CameraModel"];
                    break;
                case 2:
                    parm = imageParmDict["LensModel"];
                    break;
                case 3:
                    //var focalLength = imageParmDict["FocalLength"];
                    var focalLengthIn35mmFilm = imageParmDict["FocalLengthIn35mmFilm"];
                    var fNumber = imageParmDict["FNumber"];
                    var exposureTime = imageParmDict["ExposureTime"];
                    var ISOSpeedRatings = imageParmDict["ISOSpeedRatings"];
                    parm = $"{focalLengthIn35mmFilm}mm f/{fNumber} {exposureTime}s ISO{ISOSpeedRatings}";
                    break;
                case 4:
                    parm = imageParmDict["ShotTime"];
                    break;
            }


            return parm;
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            this.progressBar.Value = 0;


            Dictionary<string, string> parm = new Dictionary<string, string>();

            parm.Add("input", this.InputTextBox.Text);
            parm.Add("output", this.OutputTextBox.Text);
            parm.Add("flag", this.checkBoxFlag.Checked.ToString());

            if (tabControlStyle.SelectedIndex == 0)
            {
                parm.Add("tabPage", "0");
                parm.Add("upperLeft", this.comboBoxUpperLeft1.SelectedIndex.ToString());
                parm.Add("upperRight", this.comboBoxUpperRight1.SelectedIndex.ToString());
                parm.Add("lowerLeft", this.comboBoxLowerLeft1.SelectedIndex.ToString());
                parm.Add("lowerRight", this.comboBoxLowerRight1.SelectedIndex.ToString());
                parm.Add("logo", this.comboBoxLogo1.SelectedIndex.ToString());
            }

            if (tabControlStyle.SelectedIndex == 1)
            {
                parm.Add("tabPage", "1");
                parm.Add("firstLine1", this.comboBoxFirstLine1.SelectedIndex.ToString());
                parm.Add("firstLine2", this.comboBoxFirstLine2.SelectedIndex.ToString());
                parm.Add("firstLine3", this.textBoxFirstLine3.Text);
                parm.Add("logo", this.comboBoxFirstLineLogo.SelectedIndex.ToString());
                parm.Add("font", this.textBoxFont.Text);
            }

            if (tabControlStyle.SelectedIndex == 2)
            {
                parm.Add("tabPage", "2");
                parm.Add("color", this.textBoxColor.Text);
            }

            this.backgroundWorker.RunWorkerAsync(parm);
            this.RunButton.Enabled = false;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color color = colorDialog.Color;
                string hexColor = ColorTranslator.ToHtml(color);
                this.textBoxColor.Text = hexColor;
            }
        }

        private void buttonFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                Font font = fontDialog.Font;
                this.textBoxFont.Text = font.Name;
            }
        }
    }
}
