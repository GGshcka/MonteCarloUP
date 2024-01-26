namespace MonteCarloUP
{
    partial class ErrorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorForm));
            buttonOK = new Button();
            pictureBox1 = new PictureBox();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonOK
            // 
            buttonOK.BackgroundImage = Properties.Resources.button;
            buttonOK.BackgroundImageLayout = ImageLayout.Zoom;
            buttonOK.FlatAppearance.BorderSize = 0;
            buttonOK.FlatStyle = FlatStyle.Flat;
            buttonOK.Font = new Font("Minecraft Rus", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOK.ForeColor = Color.White;
            buttonOK.Location = new Point(267, 181);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(115, 25);
            buttonOK.TabIndex = 0;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            buttonOK.MouseLeave += buttonOK_MouseLeave;
            buttonOK.MouseHover += buttonOK_MouseHover;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.btn_close;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(20, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(49, 50);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(48, 48, 48);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Minecraft Rus", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(75, 24);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(307, 133);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "Разрешены только числа!\n\nВ введённых данных находятся запрещённые символы.\n\nКол-во точек будет заменено на 10000...";
            // 
            // ErrorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            BackgroundImage = Properties.Resources.bg_error;
            ClientSize = new Size(406, 232);
            ControlBox = false;
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox1);
            Controls.Add(buttonOK);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ErrorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MonteCarlo - Error";
            TransparencyKey = Color.FromArgb(192, 255, 192);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOK;
        private PictureBox pictureBox1;
        private RichTextBox richTextBox1;
    }
}