using MonteCarloUP.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonteCarloUP
{
    public partial class IntroForm : Form
    {
        int i = 20;

        public IntroForm()
        {
            InitializeComponent();

            timerTimeCounter.Start();
        }

        private void buttonToStart_Click(object sender, EventArgs e)
        {

        }
        private void buttonToStart_MouseHover(object sender, EventArgs e)
        {
            buttonToStart.BackgroundImage = Resources.buttonHovered;
        }
        private void buttonToStart_MouseLeave(object sender, EventArgs e)
        {
            buttonToStart.BackgroundImage = Resources.button;
        }

        private void timerTimeCounter_Tick(object sender, EventArgs e)
        {
            i--;
            labelTimeCounter.Text = i.ToString();
            if (i == 0)
            {
                this.Close();
            }
        }
    }
}
