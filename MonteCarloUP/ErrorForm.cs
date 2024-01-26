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
    public partial class ErrorForm : Form
    {
        public ErrorForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click (object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonOK_MouseHover(object sender, EventArgs e)
        {
            buttonOK.BackgroundImage = Resources.buttonHovered;
        }
        private void buttonOK_MouseLeave(object sender, EventArgs e)
        {
            buttonOK.BackgroundImage = Resources.button;
        }
    }
}
