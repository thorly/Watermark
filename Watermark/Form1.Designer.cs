﻿namespace Watermark
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.InputButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.OutputButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.checkBoxFlag = new System.Windows.Forms.CheckBox();
            this.groupBoxPath = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControlStyle = new System.Windows.Forms.TabControl();
            this.tabPageStyle1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxLogo1 = new System.Windows.Forms.ComboBox();
            this.comboBoxLowerRight1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxLowerLeft1 = new System.Windows.Forms.ComboBox();
            this.comboBoxUpperRight1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxUpperLeft1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageStyle2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxFirstLineLogo = new System.Windows.Forms.ComboBox();
            this.comboBoxFirstLine1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxFirstLine2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxFont = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.buttonFont = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxFirstLine3 = new System.Windows.Forms.TextBox();
            this.tabPageStyle3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonColor = new System.Windows.Forms.Button();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.groupBoxStyle = new System.Windows.Forms.GroupBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBoxRun = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxPath.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabControlStyle.SuspendLayout();
            this.tabPageStyle1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tabPageStyle2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tabPageStyle3.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBoxStyle.SuspendLayout();
            this.groupBoxRun.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputButton
            // 
            this.InputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InputButton.Location = new System.Drawing.Point(675, 12);
            this.InputButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputButton.Name = "InputButton";
            this.InputButton.Size = new System.Drawing.Size(67, 26);
            this.InputButton.TabIndex = 0;
            this.InputButton.Text = "选择";
            this.InputButton.UseVisualStyleBackColor = true;
            this.InputButton.Click += new System.EventHandler(this.InputButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "输入路径：";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InputTextBox.Location = new System.Drawing.Point(108, 12);
            this.InputTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(541, 25);
            this.InputTextBox.TabIndex = 2;
            // 
            // OutputButton
            // 
            this.OutputButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputButton.Location = new System.Drawing.Point(675, 61);
            this.OutputButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OutputButton.Name = "OutputButton";
            this.OutputButton.Size = new System.Drawing.Size(67, 28);
            this.OutputButton.TabIndex = 1;
            this.OutputButton.Text = "选择";
            this.OutputButton.UseVisualStyleBackColor = true;
            this.OutputButton.Click += new System.EventHandler(this.OutputButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "输出路径：";
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTextBox.Location = new System.Drawing.Point(108, 62);
            this.OutputTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(541, 25);
            this.OutputTextBox.TabIndex = 2;
            // 
            // RunButton
            // 
            this.RunButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RunButton.Location = new System.Drawing.Point(747, 2);
            this.RunButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(105, 31);
            this.RunButton.TabIndex = 3;
            this.RunButton.Text = "开始处理";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // checkBoxFlag
            // 
            this.checkBoxFlag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxFlag.AutoSize = true;
            this.checkBoxFlag.Location = new System.Drawing.Point(748, 14);
            this.checkBoxFlag.Name = "checkBoxFlag";
            this.checkBoxFlag.Size = new System.Drawing.Size(100, 22);
            this.checkBoxFlag.TabIndex = 5;
            this.checkBoxFlag.Text = "选择图片";
            this.checkBoxFlag.UseVisualStyleBackColor = true;
            // 
            // groupBoxPath
            // 
            this.groupBoxPath.Controls.Add(this.tableLayoutPanel3);
            this.groupBoxPath.Location = new System.Drawing.Point(3, 3);
            this.groupBoxPath.Name = "groupBoxPath";
            this.groupBoxPath.Size = new System.Drawing.Size(874, 133);
            this.groupBoxPath.TabIndex = 6;
            this.groupBoxPath.TabStop = false;
            this.groupBoxPath.Text = "设置路径";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.16667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.83334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel3.Controls.Add(this.checkBoxFlag, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.InputTextBox, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.OutputButton, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.InputButton, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.OutputTextBox, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(17, 24);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(851, 100);
            this.tableLayoutPanel3.TabIndex = 11;
            // 
            // tabControlStyle
            // 
            this.tabControlStyle.Controls.Add(this.tabPageStyle1);
            this.tabControlStyle.Controls.Add(this.tabPageStyle2);
            this.tabControlStyle.Controls.Add(this.tabPageStyle3);
            this.tabControlStyle.Location = new System.Drawing.Point(17, 24);
            this.tabControlStyle.Name = "tabControlStyle";
            this.tabControlStyle.SelectedIndex = 0;
            this.tabControlStyle.Size = new System.Drawing.Size(848, 146);
            this.tabControlStyle.TabIndex = 7;
            // 
            // tabPageStyle1
            // 
            this.tabPageStyle1.Controls.Add(this.tableLayoutPanel4);
            this.tabPageStyle1.Location = new System.Drawing.Point(4, 27);
            this.tabPageStyle1.Name = "tabPageStyle1";
            this.tabPageStyle1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStyle1.Size = new System.Drawing.Size(840, 115);
            this.tabPageStyle1.TabIndex = 0;
            this.tabPageStyle1.Text = " 样式1";
            this.tabPageStyle1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 8;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.72691F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.27309F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 207F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel4.Controls.Add(this.comboBoxLogo1, 7, 0);
            this.tableLayoutPanel4.Controls.Add(this.comboBoxLowerRight1, 4, 1);
            this.tableLayoutPanel4.Controls.Add(this.label7, 6, 0);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.comboBoxLowerLeft1, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.comboBoxUpperRight1, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label6, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.comboBoxUpperLeft1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label5, 3, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(831, 109);
            this.tableLayoutPanel4.TabIndex = 11;
            // 
            // comboBoxLogo1
            // 
            this.comboBoxLogo1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLogo1.FormattingEnabled = true;
            this.comboBoxLogo1.Location = new System.Drawing.Point(688, 15);
            this.comboBoxLogo1.Name = "comboBoxLogo1";
            this.comboBoxLogo1.Size = new System.Drawing.Size(140, 26);
            this.comboBoxLogo1.TabIndex = 1;
            // 
            // comboBoxLowerRight1
            // 
            this.comboBoxLowerRight1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLowerRight1.FormattingEnabled = true;
            this.comboBoxLowerRight1.Location = new System.Drawing.Point(375, 70);
            this.comboBoxLowerRight1.Name = "comboBoxLowerRight1";
            this.comboBoxLowerRight1.Size = new System.Drawing.Size(201, 26);
            this.comboBoxLowerRight1.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(605, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "logo：";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "左上角：";
            // 
            // comboBoxLowerLeft1
            // 
            this.comboBoxLowerLeft1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLowerLeft1.FormattingEnabled = true;
            this.comboBoxLowerLeft1.Location = new System.Drawing.Point(87, 70);
            this.comboBoxLowerLeft1.Name = "comboBoxLowerLeft1";
            this.comboBoxLowerLeft1.Size = new System.Drawing.Size(175, 26);
            this.comboBoxLowerLeft1.TabIndex = 1;
            // 
            // comboBoxUpperRight1
            // 
            this.comboBoxUpperRight1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxUpperRight1.FormattingEnabled = true;
            this.comboBoxUpperRight1.Location = new System.Drawing.Point(375, 15);
            this.comboBoxUpperRight1.Name = "comboBoxUpperRight1";
            this.comboBoxUpperRight1.Size = new System.Drawing.Size(201, 26);
            this.comboBoxUpperRight1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "左下角：";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(291, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "右下角：";
            // 
            // comboBoxUpperLeft1
            // 
            this.comboBoxUpperLeft1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxUpperLeft1.FormattingEnabled = true;
            this.comboBoxUpperLeft1.Location = new System.Drawing.Point(87, 15);
            this.comboBoxUpperLeft1.Name = "comboBoxUpperLeft1";
            this.comboBoxUpperLeft1.Size = new System.Drawing.Size(175, 26);
            this.comboBoxUpperLeft1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "右上角：";
            // 
            // tabPageStyle2
            // 
            this.tabPageStyle2.Controls.Add(this.tableLayoutPanel5);
            this.tabPageStyle2.Location = new System.Drawing.Point(4, 27);
            this.tabPageStyle2.Name = "tabPageStyle2";
            this.tabPageStyle2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStyle2.Size = new System.Drawing.Size(840, 115);
            this.tabPageStyle2.TabIndex = 1;
            this.tabPageStyle2.Text = "样式2";
            this.tabPageStyle2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 8;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.31847F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.68153F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel5.Controls.Add(this.comboBoxFirstLineLogo, 7, 0);
            this.tableLayoutPanel5.Controls.Add(this.comboBoxFirstLine1, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label9, 6, 0);
            this.tableLayoutPanel5.Controls.Add(this.comboBoxFirstLine2, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBoxFont, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.buttonFont, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.label13, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBoxFirstLine3, 4, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(824, 100);
            this.tableLayoutPanel5.TabIndex = 11;
            // 
            // comboBoxFirstLineLogo
            // 
            this.comboBoxFirstLineLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFirstLineLogo.FormattingEnabled = true;
            this.comboBoxFirstLineLogo.Location = new System.Drawing.Point(705, 13);
            this.comboBoxFirstLineLogo.Name = "comboBoxFirstLineLogo";
            this.comboBoxFirstLineLogo.Size = new System.Drawing.Size(116, 26);
            this.comboBoxFirstLineLogo.TabIndex = 1;
            // 
            // comboBoxFirstLine1
            // 
            this.comboBoxFirstLine1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFirstLine1.FormattingEnabled = true;
            this.comboBoxFirstLine1.Location = new System.Drawing.Point(99, 13);
            this.comboBoxFirstLine1.Name = "comboBoxFirstLine1";
            this.comboBoxFirstLine1.Size = new System.Drawing.Size(89, 26);
            this.comboBoxFirstLine1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(640, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "logo：";
            // 
            // comboBoxFirstLine2
            // 
            this.comboBoxFirstLine2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFirstLine2.FormattingEnabled = true;
            this.comboBoxFirstLine2.Location = new System.Drawing.Point(194, 13);
            this.comboBoxFirstLine2.Name = "comboBoxFirstLine2";
            this.comboBoxFirstLine2.Size = new System.Drawing.Size(128, 26);
            this.comboBoxFirstLine2.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "第一行：";
            // 
            // textBoxFont
            // 
            this.textBoxFont.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFont.Location = new System.Drawing.Point(99, 62);
            this.textBoxFont.Name = "textBoxFont";
            this.textBoxFont.Size = new System.Drawing.Size(89, 25);
            this.textBoxFont.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(37, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "字体：";
            // 
            // buttonFont
            // 
            this.buttonFont.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonFont.Location = new System.Drawing.Point(194, 62);
            this.buttonFont.Name = "buttonFont";
            this.buttonFont.Size = new System.Drawing.Size(71, 26);
            this.buttonFont.TabIndex = 3;
            this.buttonFont.Text = "选择";
            this.buttonFont.UseVisualStyleBackColor = true;
            this.buttonFont.Click += new System.EventHandler(this.buttonFont_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(328, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 18);
            this.label13.TabIndex = 4;
            this.label13.Text = "自定义：";
            // 
            // textBoxFirstLine3
            // 
            this.textBoxFirstLine3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFirstLine3.Location = new System.Drawing.Point(408, 12);
            this.textBoxFirstLine3.Name = "textBoxFirstLine3";
            this.textBoxFirstLine3.Size = new System.Drawing.Size(197, 25);
            this.textBoxFirstLine3.TabIndex = 5;
            // 
            // tabPageStyle3
            // 
            this.tabPageStyle3.Controls.Add(this.tableLayoutPanel6);
            this.tabPageStyle3.Location = new System.Drawing.Point(4, 27);
            this.tabPageStyle3.Name = "tabPageStyle3";
            this.tabPageStyle3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStyle3.Size = new System.Drawing.Size(840, 115);
            this.tabPageStyle3.TabIndex = 2;
            this.tabPageStyle3.Text = "样式3";
            this.tabPageStyle3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.03745F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.10862F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel6.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.buttonColor, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.textBoxColor, 1, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(6, 40);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(534, 45);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "边框颜色：";
            // 
            // buttonColor
            // 
            this.buttonColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonColor.Location = new System.Drawing.Point(447, 9);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(84, 26);
            this.buttonColor.TabIndex = 1;
            this.buttonColor.Text = "选择";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // textBoxColor
            // 
            this.textBoxColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxColor.Location = new System.Drawing.Point(110, 10);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(331, 25);
            this.textBoxColor.TabIndex = 2;
            // 
            // groupBoxStyle
            // 
            this.groupBoxStyle.Controls.Add(this.tabControlStyle);
            this.groupBoxStyle.Location = new System.Drawing.Point(3, 144);
            this.groupBoxStyle.Name = "groupBoxStyle";
            this.groupBoxStyle.Size = new System.Drawing.Size(874, 192);
            this.groupBoxStyle.TabIndex = 8;
            this.groupBoxStyle.TabStop = false;
            this.groupBoxStyle.Text = "设置样式";
            // 
            // groupBoxRun
            // 
            this.groupBoxRun.Controls.Add(this.tableLayoutPanel2);
            this.groupBoxRun.Location = new System.Drawing.Point(3, 342);
            this.groupBoxRun.Name = "groupBoxRun";
            this.groupBoxRun.Size = new System.Drawing.Size(868, 73);
            this.groupBoxRun.TabIndex = 9;
            this.groupBoxRun.TabStop = false;
            this.groupBoxRun.Text = "处理";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.progressBar, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.RunButton, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(855, 35);
            this.tableLayoutPanel2.TabIndex = 11;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(97, 5);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(604, 24);
            this.progressBar.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 18);
            this.label12.TabIndex = 5;
            this.label12.Text = "处理进度：";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBoxRun, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxPath, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBoxStyle, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.81995F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.60765F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.66029F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(880, 418);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 446);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Watermark";
            this.groupBoxPath.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabControlStyle.ResumeLayout(false);
            this.tabPageStyle1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tabPageStyle2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tabPageStyle3.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.groupBoxStyle.ResumeLayout(false);
            this.groupBoxRun.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button InputButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button OutputButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.CheckBox checkBoxFlag;
        private System.Windows.Forms.GroupBox groupBoxPath;
        private System.Windows.Forms.TabControl tabControlStyle;
        private System.Windows.Forms.TabPage tabPageStyle1;
        private System.Windows.Forms.TabPage tabPageStyle2;
        private System.Windows.Forms.GroupBox groupBoxStyle;
        private System.Windows.Forms.TabPage tabPageStyle3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxUpperLeft1;
        private System.Windows.Forms.ComboBox comboBoxLowerLeft1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxLowerRight1;
        private System.Windows.Forms.ComboBox comboBoxUpperRight1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxLogo1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxFirstLine1;
        private System.Windows.Forms.ComboBox comboBoxFirstLine2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxFirstLineLogo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxFont;
        private System.Windows.Forms.Button buttonFont;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.GroupBox groupBoxRun;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxFirstLine3;
    }
}

