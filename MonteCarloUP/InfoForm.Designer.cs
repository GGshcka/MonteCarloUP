namespace MonteCarloUP
{
    partial class InfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            tableLayoutPanel = new TableLayoutPanel();
            labelProductName = new Label();
            labelVersion = new Label();
            labelCopyright = new Label();
            labelCompanyName = new Label();
            pictureBox1 = new PictureBox();
            okButton = new PictureBox();
            buttonHelp = new Button();
            tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)okButton).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.BackColor = Color.Transparent;
            tableLayoutPanel.ColumnCount = 1;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(labelProductName, 1, 1);
            tableLayoutPanel.Controls.Add(labelVersion, 1, 2);
            tableLayoutPanel.Controls.Add(labelCopyright, 1, 4);
            tableLayoutPanel.Controls.Add(labelCompanyName, 1, 3);
            tableLayoutPanel.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel.Dock = DockStyle.Top;
            tableLayoutPanel.Location = new Point(0, 0);
            tableLayoutPanel.Margin = new Padding(0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(20, 27, 10, 10);
            tableLayoutPanel.RowCount = 11;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 23F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel.Size = new Size(289, 312);
            tableLayoutPanel.TabIndex = 0;
            // 
            // labelProductName
            // 
            labelProductName.BackColor = Color.Transparent;
            labelProductName.Dock = DockStyle.Fill;
            labelProductName.Font = new Font("Minecraft Rus", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelProductName.ForeColor = Color.Black;
            labelProductName.Location = new Point(27, 73);
            labelProductName.Margin = new Padding(7, 0, 4, 0);
            labelProductName.MaximumSize = new Size(0, 20);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(248, 20);
            labelProductName.TabIndex = 19;
            labelProductName.Text = "Product Name";
            labelProductName.TextAlign = ContentAlignment.BottomLeft;
            // 
            // labelVersion
            // 
            labelVersion.BackColor = Color.Transparent;
            labelVersion.Dock = DockStyle.Fill;
            labelVersion.Font = new Font("Minecraft Rus", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelVersion.ForeColor = Color.Black;
            labelVersion.Location = new Point(27, 96);
            labelVersion.Margin = new Padding(7, 0, 4, 0);
            labelVersion.MaximumSize = new Size(0, 20);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(248, 20);
            labelVersion.TabIndex = 0;
            labelVersion.Text = "Version";
            labelVersion.TextAlign = ContentAlignment.BottomLeft;
            // 
            // labelCopyright
            // 
            labelCopyright.BackColor = Color.Transparent;
            labelCopyright.Dock = DockStyle.Fill;
            labelCopyright.Font = new Font("Minecraft Rus", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCopyright.ForeColor = Color.Black;
            labelCopyright.Location = new Point(27, 143);
            labelCopyright.Margin = new Padding(7, 0, 4, 0);
            labelCopyright.MaximumSize = new Size(0, 20);
            labelCopyright.Name = "labelCopyright";
            labelCopyright.Size = new Size(248, 20);
            labelCopyright.TabIndex = 21;
            labelCopyright.Text = "Copyright";
            labelCopyright.TextAlign = ContentAlignment.BottomLeft;
            // 
            // labelCompanyName
            // 
            labelCompanyName.BackColor = Color.Transparent;
            labelCompanyName.Dock = DockStyle.Fill;
            labelCompanyName.Font = new Font("Minecraft Rus", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelCompanyName.ForeColor = Color.Black;
            labelCompanyName.Location = new Point(27, 119);
            labelCompanyName.Margin = new Padding(7, 0, 4, 0);
            labelCompanyName.MaximumSize = new Size(0, 20);
            labelCompanyName.Name = "labelCompanyName";
            labelCompanyName.Size = new Size(248, 20);
            labelCompanyName.TabIndex = 22;
            labelCompanyName.Text = "Company Name";
            labelCompanyName.TextAlign = ContentAlignment.BottomLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.title_intro;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(20, 35);
            pictureBox1.Margin = new Padding(0, 8, 0, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(240, 30);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // okButton
            // 
            okButton.BackColor = Color.Transparent;
            okButton.BackgroundImage = Properties.Resources.btn_back_info;
            okButton.BackgroundImageLayout = ImageLayout.Zoom;
            okButton.Location = new Point(0, 325);
            okButton.Name = "okButton";
            okButton.Size = new Size(53, 26);
            okButton.TabIndex = 25;
            okButton.TabStop = false;
            okButton.Click += okButton_Click;
            okButton.MouseLeave += okButton_MouseLeave;
            okButton.MouseHover += okButton_MouseHover;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.Transparent;
            buttonHelp.BackgroundImage = Properties.Resources.btn_help;
            buttonHelp.BackgroundImageLayout = ImageLayout.Zoom;
            buttonHelp.FlatAppearance.BorderSize = 0;
            buttonHelp.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonHelp.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(255, 325);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(20, 20);
            buttonHelp.TabIndex = 26;
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BackgroundImage = Properties.Resources.bg_info;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(289, 350);
            ControlBox = false;
            Controls.Add(buttonHelp);
            Controls.Add(okButton);
            Controls.Add(tableLayoutPanel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InfoForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MonteCarlo - About...";
            TransparencyKey = Color.FromArgb(64, 64, 64);
            tableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)okButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelCompanyName;
        private PictureBox okButton;
        private PictureBox pictureBox1;
        private Button buttonHelp;
    }
}
