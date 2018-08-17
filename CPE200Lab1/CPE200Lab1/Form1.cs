using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPE200Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected void btn(object sender,EventArgs e)
        {
            Button click = (Button)sender;
            if (click.Text == "C")
            {
                lblDisplay.Clear();
            }
            else
            {
                lblDisplay.Text == click.Text.ToString();
            }
        }
        private void btn1_Click(object sender, EventArgs e)
        {

        }
    }
}
