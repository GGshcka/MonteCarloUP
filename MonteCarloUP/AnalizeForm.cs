using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml;

namespace MonteCarloUP
{
    public partial class AnalizeForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public AnalizeForm()
        {
            InitializeComponent();

            XmlDocument savedData = new XmlDocument();
            savedData.Load("SavedData.xml");

            int pointsNum = 0;
            Series seriesAnalize = new Series("SeriesAnalize");

            XmlNodeList itemList = savedData.GetElementsByTagName("item");

            foreach (XmlNode item in itemList)
            {
                double savedS = Convert.ToDouble(item.Attributes["S"].Value);

                seriesAnalize.Points.AddXY(pointsNum, savedS);
                pointsNum++;
            }

            if (!chartAnalize.Series.Contains(seriesAnalize))
            {
                chartAnalize.Series.Add(seriesAnalize);
            }
        }

        private void analizeForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void analizeForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void analizeForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void buttonClose_Click (object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
