using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }


        private void tbNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            getResult();
            label2.Text = getResult().ToString();

        }
        
        double getResult()
        {
            double num1=0, num2=0, result=0;
            num1 = Double.Parse(tbNum1.Text);
            num2 = Double.Parse(tbNum2.Text);
            switch (comboBox1.Text)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "b":
                    result = num1 - num2;
                    break;
                case "c":
                    result = num1 * num2;
                    break;
                case "d":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    break;
            }
            return result;
            
        }
        
       

        private void tbNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
