namespace MonteCarloUP
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            acceptButton = new PictureBox();
            textBoxDots = new TextBox();
            panelDrawSpace = new PictureBox();
            panelMapFrame = new Panel();
            buttonClear = new Button();
            labelS = new Label();
            timerDrawer = new System.Windows.Forms.Timer(components);
            buttonClose = new Button();
            buttonMinimize = new Button();
            buttonInfo = new Button();
            labelMathS = new Label();
            buttonAnalize = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)acceptButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelDrawSpace).BeginInit();
            panelMapFrame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.bg_textInput;
            panel1.Controls.Add(acceptButton);
            panel1.Controls.Add(textBoxDots);
            panel1.Location = new Point(27, 83);
            panel1.Name = "panel1";
            panel1.Size = new Size(218, 38);
            panel1.TabIndex = 7;
            // 
            // acceptButton
            // 
            acceptButton.BackgroundImage = Properties.Resources.btn_accept;
            acceptButton.BackgroundImageLayout = ImageLayout.Zoom;
            acceptButton.Dock = DockStyle.Right;
            acceptButton.Location = new Point(180, 0);
            acceptButton.Name = "acceptButton";
            acceptButton.Size = new Size(38, 38);
            acceptButton.TabIndex = 1;
            acceptButton.TabStop = false;
            acceptButton.Click += acceptButton_Click;
            acceptButton.MouseLeave += acceptButton_MouseLeave;
            acceptButton.MouseHover += acceptButton_MouseHover;
            // 
            // textBoxDots
            // 
            textBoxDots.BackColor = Color.FromArgb(160, 145, 114);
            textBoxDots.BorderStyle = BorderStyle.None;
            textBoxDots.Font = new Font("Minecraft Rus", 12F);
            textBoxDots.ForeColor = Color.White;
            textBoxDots.Location = new Point(6, 11);
            textBoxDots.MaxLength = 7;
            textBoxDots.Name = "textBoxDots";
            textBoxDots.Size = new Size(170, 16);
            textBoxDots.TabIndex = 0;
            textBoxDots.Text = "10000";
            // 
            // panelDrawSpace
            // 
            panelDrawSpace.Dock = DockStyle.Fill;
            panelDrawSpace.Location = new Point(18, 18);
            panelDrawSpace.Name = "panelDrawSpace";
            panelDrawSpace.Size = new Size(348, 348);
            panelDrawSpace.TabIndex = 0;
            panelDrawSpace.TabStop = false;
            panelDrawSpace.Paint += panelDrawSpace_Paint;
            // 
            // panelMapFrame
            // 
            panelMapFrame.BackColor = Color.Transparent;
            panelMapFrame.BackgroundImage = Properties.Resources.bg_map;
            panelMapFrame.Controls.Add(buttonClear);
            panelMapFrame.Controls.Add(panelDrawSpace);
            panelMapFrame.Location = new Point(341, 72);
            panelMapFrame.Name = "panelMapFrame";
            panelMapFrame.Padding = new Padding(18);
            panelMapFrame.Size = new Size(384, 384);
            panelMapFrame.TabIndex = 8;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.Transparent;
            buttonClear.BackgroundImage = Properties.Resources.button;
            buttonClear.BackgroundImageLayout = ImageLayout.Zoom;
            buttonClear.FlatAppearance.BorderSize = 0;
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.Font = new Font("Minecraft Rus", 8F);
            buttonClear.ForeColor = Color.White;
            buttonClear.Location = new Point(134, 359);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(115, 25);
            buttonClear.TabIndex = 13;
            buttonClear.Text = "ОЧИСТИТЬ";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Visible = false;
            buttonClear.Click += buttonClear_Click;
            buttonClear.MouseLeave += buttonClear_MouseLeave;
            buttonClear.MouseHover += buttonClear_MouseHover;
            // 
            // labelS
            // 
            labelS.AutoSize = true;
            labelS.BackColor = Color.Transparent;
            labelS.Font = new Font("Minecraft Rus", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelS.Location = new Point(27, 130);
            labelS.Name = "labelS";
            labelS.Size = new Size(123, 16);
            labelS.TabIndex = 9;
            labelS.Text = "S СЕГМЕНТА:";
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.Transparent;
            buttonClose.BackgroundImage = Properties.Resources.btn_close;
            buttonClose.BackgroundImageLayout = ImageLayout.Zoom;
            buttonClose.FlatAppearance.BorderSize = 0;
            buttonClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonClose.FlatStyle = FlatStyle.Flat;
            buttonClose.Location = new Point(757, 32);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(16, 16);
            buttonClose.TabIndex = 10;
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // buttonMinimize
            // 
            buttonMinimize.BackColor = Color.Transparent;
            buttonMinimize.BackgroundImage = Properties.Resources.btn_minimize;
            buttonMinimize.BackgroundImageLayout = ImageLayout.Zoom;
            buttonMinimize.FlatAppearance.BorderSize = 0;
            buttonMinimize.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonMinimize.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonMinimize.FlatStyle = FlatStyle.Flat;
            buttonMinimize.Location = new Point(715, 32);
            buttonMinimize.Name = "buttonMinimize";
            buttonMinimize.Size = new Size(16, 16);
            buttonMinimize.TabIndex = 11;
            buttonMinimize.UseVisualStyleBackColor = false;
            buttonMinimize.Click += buttonMinimize_Click;
            // 
            // buttonInfo
            // 
            buttonInfo.BackColor = Color.Transparent;
            buttonInfo.BackgroundImage = Properties.Resources.btn_info;
            buttonInfo.BackgroundImageLayout = ImageLayout.Zoom;
            buttonInfo.FlatAppearance.BorderSize = 0;
            buttonInfo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonInfo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonInfo.FlatStyle = FlatStyle.Flat;
            buttonInfo.Location = new Point(674, 32);
            buttonInfo.Name = "buttonInfo";
            buttonInfo.Size = new Size(16, 16);
            buttonInfo.TabIndex = 12;
            buttonInfo.UseVisualStyleBackColor = false;
            buttonInfo.Click += buttonInfo_Click;
            // 
            // labelMathS
            // 
            labelMathS.AutoSize = true;
            labelMathS.BackColor = Color.Transparent;
            labelMathS.Font = new Font("Minecraft Rus", 8F);
            labelMathS.Location = new Point(28, 150);
            labelMathS.Name = "labelMathS";
            labelMathS.Size = new Size(185, 11);
            labelMathS.TabIndex = 13;
            labelMathS.Text = "S МАТЕМАТИЧЕСКАЯ: 10.1096";
            labelMathS.Visible = false;
            // 
            // buttonAnalize
            // 
            buttonAnalize.BackColor = Color.Transparent;
            buttonAnalize.BackgroundImage = Properties.Resources.button;
            buttonAnalize.BackgroundImageLayout = ImageLayout.Zoom;
            buttonAnalize.FlatAppearance.BorderSize = 0;
            buttonAnalize.FlatStyle = FlatStyle.Flat;
            buttonAnalize.Font = new Font("Minecraft Rus", 8F);
            buttonAnalize.ForeColor = Color.White;
            buttonAnalize.Location = new Point(87, 473);
            buttonAnalize.Name = "buttonAnalize";
            buttonAnalize.Size = new Size(115, 25);
            buttonAnalize.TabIndex = 14;
            buttonAnalize.Text = "АНАЛИЗ";
            buttonAnalize.UseVisualStyleBackColor = false;
            buttonAnalize.Visible = false;
            buttonAnalize.Click += buttonAnalize_Click;
            buttonAnalize.MouseLeave += buttonAnalize_MouseLeave;
            buttonAnalize.MouseHover += buttonAnalize_MouseHover;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.title_intro;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(27, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 59);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            BackgroundImage = Properties.Resources.bg_mainForm;
            ClientSize = new Size(810, 510);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(buttonAnalize);
            Controls.Add(labelMathS);
            Controls.Add(buttonInfo);
            Controls.Add(buttonMinimize);
            Controls.Add(buttonClose);
            Controls.Add(labelS);
            Controls.Add(panelMapFrame);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MonteCarlo - Workspace";
            TransparencyKey = Color.FromArgb(192, 255, 192);
            MouseDown += mainForm_MouseDown;
            MouseMove += mainForm_MouseMove;
            MouseUp += mainForm_MouseUp;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)acceptButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelDrawSpace).EndInit();
            panelMapFrame.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Panel panelMapFrame;
        private TextBox textBoxDots;
        private PictureBox panelDrawSpace;
        private PictureBox acceptButton;
        private Label labelS;
        private System.Windows.Forms.Timer timerDrawer;
        private Button buttonClose;
        private Button buttonMinimize;
        private Button buttonInfo;
        private Button buttonClear;
        private Label labelMathS;
        private Button buttonAnalize;
        private PictureBox pictureBox1;
    }
}
