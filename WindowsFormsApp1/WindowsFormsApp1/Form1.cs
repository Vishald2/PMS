using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long simpleInterest;

            long principal, rate, duration;

            principal = long.Parse(txtPrincipal.Text);

            rate = long.Parse(txtRate.Text);

            duration = long.Parse(txtDuration.Text);

            simpleInterest = principal * rate * duration / 100;

            lblResult.Text = simpleInterest.ToString();

        }
    }
}
