using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoTimeApps
{
    public partial class showTwoTimesTextBox : Form
    {
        public showTwoTimesTextBox()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void showTwoTimesButton_Click(object sender, EventArgs e)
        {
            double aNumber = Convert.ToDouble(aNumberTextBox.Text);
            double result = GetDouble(aNumber);
            twoTimesTextBox.Text = result.ToString();
        }
       

        private double GetDouble(double Number)
        {
            double result = Number*2;
            return result;
        }

    }
}
