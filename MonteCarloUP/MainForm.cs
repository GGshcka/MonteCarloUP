using MonteCarloUP.Properties;
using System;
using System.Drawing;
using System.Xml;
using System.Xml.Linq;

namespace MonteCarloUP
{
    public partial class MainForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        List<PointF> points = new List<PointF>();

        XmlDocument savedData = new XmlDocument();
        XmlElement savedItems;

        int centerX, centerY, radiusCircleSquare, cordX, cordY, circleDiameter;
        float scaleFactor = 40.0f;

        public MainForm()
        {
            InitializeComponent();

            var IntroWindow = new IntroForm();
            IntroWindow.ShowDialog();


            string fileName = "savedData.xml";

            if (File.Exists(fileName))
            {
                savedData.Load(fileName);
                savedItems = savedData["savedItems"];
            }
            else
            {
                savedItems = savedData.CreateElement("savedItems");
                savedData.AppendChild(savedItems);
            }

            panelDrawSpace.Paint += new PaintEventHandler(panelDrawSpace_Paint);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            var InfoWindow = new InfoForm();
            InfoWindow.ShowDialog();
        }

        private void mainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void mainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void mainForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panelDrawSpace_Paint(object sender, PaintEventArgs e)
        {
            Brush rectangleBrush = new SolidBrush(Color.FromArgb(198, 220, 77));
            Brush circleBrush = new SolidBrush(Color.FromArgb(119, 161, 25));
            Brush lineBrush = new SolidBrush(Color.FromArgb(94, 55, 47));

            Pen axisPen = new Pen(Color.Black, 2);
            Pen rectanglePen = new Pen(rectangleBrush, 2);
            Pen circlePen = new Pen(circleBrush, 2);
            Pen linePen = new Pen(lineBrush, 2);

            // Calculate the center of the panel for reference
            centerX = panelDrawSpace.Width / 2;
            centerY = panelDrawSpace.Height / 2;

            // Draw the coordinate axes
            e.Graphics.DrawLine(axisPen, 0, centerY + (2 * scaleFactor), panelDrawSpace.Width, centerY + (2 * scaleFactor)); // X-axis
            e.Graphics.DrawLine(axisPen, centerX - (1 * scaleFactor), 0, centerX - (1 * scaleFactor), panelDrawSpace.Height); // Y-axis

            radiusCircleSquare = (int)(2 * scaleFactor); // Side length of 2, scaled
            cordX = (int)(centerX - radiusCircleSquare);
            cordY = (int)(centerY - radiusCircleSquare);
            circleDiameter = radiusCircleSquare * 2;

            e.Graphics.DrawRectangle(rectanglePen, cordX, cordY, radiusCircleSquare * 2, radiusCircleSquare * 2);

            // Draw the circle
            e.Graphics.DrawEllipse(circlePen, cordX, cordY, circleDiameter, circleDiameter);

            // Define the line to draw
            int lineX = (int)(centerX + (2 * scaleFactor)); // X coordinate of the line

            // Draw the line
            e.Graphics.DrawLine(linePen, lineX - (1 * scaleFactor), 0, lineX - (1 * scaleFactor), panelDrawSpace.Height);

            foreach (var point in points)
            {
                if (Math.Pow((point.X - centerX), 2) + Math.Pow((point.Y - centerY), 2) <= Math.Pow(radiusCircleSquare, 2))
                {
                    if (((point.X - centerX) - scaleFactor) * Math.Pow(scaleFactor, 2) * Math.Pow(radiusCircleSquare, 2) <= lineX - (1 * scaleFactor))
                    {
                        e.Graphics.FillEllipse(circleBrush, point.X, point.Y, 2, 2);
                    }
                    else
                    {
                        e.Graphics.FillEllipse(lineBrush, point.X, point.Y, 2, 2);
                    }
                }
                else
                {
                    e.Graphics.FillEllipse(rectangleBrush, point.X, point.Y, 2, 2);
                }

                PointF lastPoint = points[points.Count - 1];
                if (point == lastPoint)
                {
                    buttonClear.Visible = true;
                }
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            int totalPoints;
            string textBoxAllDots = textBoxDots.Text;
            bool resaultParse = int.TryParse(textBoxAllDots, out totalPoints);
            var errorBox = new ErrorForm();

            labelMathS.Visible = true;

            if (resaultParse == false)
            {
                errorBox.ShowDialog();
                totalPoints = 10000;
            }

            Random rand = new Random();
            int pointsInsideCircle = 0; // Количество точек, попавших в круг

            // Очищаем список точек перед новым расчетом
            points.Clear();

            for (int i = 0; i < totalPoints; i++)
            {
                double x = rand.NextDouble() * (cordX + radiusCircleSquare * 2 - cordX) + cordX;
                double y = rand.NextDouble() * (cordY + radiusCircleSquare * 2 - cordY) + cordY;

                // Проверяем, находится ли точка внутри круга и квадрата
                if (Math.Pow((x - centerX), 2) + Math.Pow((y - centerY), 2) <= Math.Pow(radiusCircleSquare, 2))
                {
                    if (((x - centerX) - scaleFactor) * Math.Pow(scaleFactor, 2) * Math.Pow(radiusCircleSquare, 2) <= x - (1 * scaleFactor))
                    {
                        pointsInsideCircle++;
                    }

                    points.Add(new PointF((float)x, (float)y));
                }
                else
                {
                    points.Add(new PointF((float)x, (float)y));
                }
            }

            // Вычисляем площадь круга, используя метод Монте-Карло
            double circleS = Math.Round(((double)pointsInsideCircle / totalPoints * Math.Pow(radiusCircleSquare, 2)) / (scaleFactor * 10), 4, MidpointRounding.AwayFromZero);

            labelS.Text = $"S СЕГМЕНТА: {circleS}";

            saveToXml(circleS, totalPoints);

            panelDrawSpace.Invalidate();
        }

        private void saveToXml(double saveCircleS, int allPoints)
        {
            XmlElement item = savedData.CreateElement("item");
            savedItems.AppendChild(item);

            XmlAttribute savedS = savedData.CreateAttribute("S");
            savedS.Value = saveCircleS.ToString();
            item.Attributes.Append(savedS);

            XmlAttribute savedTotalDots = savedData.CreateAttribute("TotalDots");
            savedTotalDots.Value = allPoints.ToString();
            item.Attributes.Append(savedTotalDots);

            savedData.Save("SavedData.xml");
        }

        private void acceptButton_MouseHover(object sender, EventArgs e)
        {
            acceptButton.BackgroundImage = Resources.btn_accept_highlighted;
        }
        private void acceptButton_MouseLeave(object sender, EventArgs e)
        {
            acceptButton.BackgroundImage = Resources.btn_accept;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            points.Clear();
            labelS.Text = "S СЕГМЕНТА:";
            panelDrawSpace.Invalidate();
            labelMathS.Visible = false;
            buttonClear.Visible = false;
        }
        private void buttonClear_MouseHover(object sender, EventArgs e)
        {
            buttonClear.BackgroundImage = Resources.buttonHovered;
        }
        private void buttonClear_MouseLeave(object sender, EventArgs e)
        {
            buttonClear.BackgroundImage = Resources.button;
        }
    }
}
