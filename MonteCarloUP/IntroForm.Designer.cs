namespace MonteCarloUP
{
    partial class IntroForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntroForm));
            buttonToStart = new Button();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            labelTimeCounter = new Label();
            timerTimeCounter = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonToStart
            // 
            buttonToStart.BackColor = Color.Transparent;
            buttonToStart.BackgroundImage = Properties.Resources.button;
            buttonToStart.BackgroundImageLayout = ImageLayout.Stretch;
            buttonToStart.FlatAppearance.BorderColor = SystemColors.ControlLightLight;
            buttonToStart.FlatAppearance.BorderSize = 0;
            buttonToStart.FlatStyle = FlatStyle.Flat;
            buttonToStart.Font = new Font("Minecraft Rus", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonToStart.ForeColor = Color.White;
            buttonToStart.Location = new Point(131, 188);
            buttonToStart.Name = "buttonToStart";
            buttonToStart.Size = new Size(115, 25);
            buttonToStart.TabIndex = 1;
            buttonToStart.Text = "Начать";
            buttonToStart.UseVisualStyleBackColor = false;
            buttonToStart.Click += buttonToStart_Click;
            buttonToStart.MouseLeave += buttonToStart_MouseLeave;
            buttonToStart.MouseHover += buttonToStart_MouseHover;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Minecraft Rus", 13F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(123, 100);
            label2.Name = "label2";
            label2.Size = new Size(139, 18);
            label2.TabIndex = 2;
            label2.Text = "Зорин Иван";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.title_intro;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(63, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 50);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // labelTimeCounter
            // 
            labelTimeCounter.AutoSize = true;
            labelTimeCounter.BackColor = Color.Transparent;
            labelTimeCounter.Font = new Font("Minecraft Rus", 12F);
            labelTimeCounter.ForeColor = Color.White;
            labelTimeCounter.Location = new Point(252, 193);
            labelTimeCounter.Name = "labelTimeCounter";
            labelTimeCounter.Size = new Size(31, 16);
            labelTimeCounter.TabIndex = 4;
            labelTimeCounter.Text = "20";
            labelTimeCounter.TextAlign = ContentAlignment.BottomLeft;
            // 
            // timerTimeCounter
            // 
            timerTimeCounter.Interval = 1000;
            timerTimeCounter.Tick += timerTimeCounter_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Minecraft Rus", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(146, 130);
            label1.Name = "label1";
            label1.Size = new Size(91, 16);
            label1.TabIndex = 5;
            label1.Text = "ИСП-306";
            // 
            // IntroForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            BackgroundImage = Properties.Resources.bg_intro;
            CancelButton = buttonToStart;
            ClientSize = new Size(375, 225);
            ControlBox = false;
            Controls.Add(label1);
            Controls.Add(labelTimeCounter);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(buttonToStart);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "IntroForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MonteCarlo - Intro";
            TopMost = true;
            TransparencyKey = Color.FromArgb(192, 255, 192);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonToStart;
        private Label label2;
        private PictureBox pictureBox1;
        private Label labelTimeCounter;
        private System.Windows.Forms.Timer timerTimeCounter;
        private Label label1;
    }
}