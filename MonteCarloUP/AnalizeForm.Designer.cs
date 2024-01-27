namespace MonteCarloUP
{
    partial class AnalizeForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnalizeForm));
            pictureBox1 = new PictureBox();
            buttonClose = new Button();
            chartAnalize = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartAnalize).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.title_intro;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(24, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 28);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            buttonClose.Location = new Point(476, 12);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(16, 16);
            buttonClose.TabIndex = 1;
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // chartAnalize
            // 
            chartAnalize.BackColor = Color.Transparent;
            chartAnalize.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea1.AxisX.LabelStyle.Font = new Font("Minecraft Rus", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            chartArea1.AxisX.LabelStyle.ForeColor = Color.White;
            chartArea1.AxisX.TitleFont = new Font("Minecraft Rus", 8.25F);
            chartArea1.AxisX.TitleForeColor = Color.White;
            chartArea1.AxisX2.LabelStyle.Font = new Font("Minecraft Rus", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            chartArea1.AxisX2.LabelStyle.ForeColor = Color.White;
            chartArea1.AxisX2.TitleFont = new Font("Minecraft Rus", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            chartArea1.AxisX2.TitleForeColor = Color.White;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.LabelStyle.Font = new Font("Minecraft Rus", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            chartArea1.AxisY.LabelStyle.ForeColor = Color.White;
            chartArea1.AxisY.TitleFont = new Font("Minecraft Rus", 8.25F);
            chartArea1.AxisY.TitleForeColor = Color.White;
            chartArea1.AxisY2.LabelStyle.Font = new Font("Minecraft Rus", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            chartArea1.AxisY2.LabelStyle.ForeColor = Color.White;
            chartArea1.AxisY2.TitleFont = new Font("Minecraft Rus", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            chartArea1.AxisY2.TitleForeColor = Color.White;
            chartArea1.BackSecondaryColor = Color.White;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartMainArea";
            chartAnalize.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartAnalize.Legends.Add(legend1);
            chartAnalize.Location = new Point(24, 40);
            chartAnalize.Name = "chartAnalize";
            chartAnalize.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            chartAnalize.Size = new Size(455, 295);
            chartAnalize.TabIndex = 2;
            chartAnalize.Text = "chartAnalize";
            // 
            // AnalizeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            BackgroundImage = Properties.Resources.bg_analize;
            ClientSize = new Size(504, 360);
            Controls.Add(chartAnalize);
            Controls.Add(buttonClose);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AnalizeForm";
            Text = "MonteCarlo - Analize";
            TransparencyKey = Color.FromArgb(192, 255, 192);
            MouseDown += analizeForm_MouseDown;
            MouseMove += analizeForm_MouseMove;
            MouseUp += analizeForm_MouseUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartAnalize).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonClose;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAnalize;
    }
}