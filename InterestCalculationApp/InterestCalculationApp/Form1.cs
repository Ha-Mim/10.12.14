using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestCalculationApp
{
    public partial class Form1 : Form
    {
         private string bankName;
       
       
        public Form1()
        {
            InitializeComponent();
             

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

              bankName = comboBox1.Text;
        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
             Console.ReadLine();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Console.ReadLine();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "BRAC")
                textBox3.Text = (double.Parse(textBox2.Text)*double.Parse(textBox1.Text)*.06).ToString();

            else if (comboBox1.Text == "DBBL")
                textBox3.Text = (double.Parse(textBox2.Text)*double.Parse(textBox1.Text)*.07).ToString();
            else if (comboBox1.Text == "HSBC")
                textBox3.Text = (double.Parse(textBox2.Text)*double.Parse(textBox1.Text)*.08).ToString();
            
           

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
