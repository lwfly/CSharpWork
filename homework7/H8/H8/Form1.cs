using System;
using System.Drawing;
using System.Windows.Forms;

namespace H8
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private int n;
        private double length;
        private int num1;
        private int num2;
        private double th1;
        private double th2;
        private double per1;
        private double per2;
        private ColorDialog color = new ColorDialog();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (graphics == null)
                graphics = TreePanel.CreateGraphics();

            if (JudgeUnNull())
            {
                n = int.Parse(textHeight.Text);
                length = int.Parse(textLength.Text);
                num1 = int.Parse(textTh1.Text);
                num2 = int.Parse(textTh2.Text);
                th1 = num1 * Math.PI / 180;
                th2 = num2 * Math.PI / 180;
                per1 = double.Parse(textPer1.Text);
                per2 = double.Parse(textPer2.Text);
                while(!JudgeLegal())
                {
                    LblWarning.Text = "invaild input";
                    ClearInvaildInput();
                    return;
                }
                LblWarning.Text = "";
                graphics.Clear(Form.DefaultBackColor);
                DrawCayleyTree(n, TreePanel.Width/2, TreePanel.Height *4/ 5, length, -Math.PI / 2);

            }
            else
            {
                LblWarning.Text = "input every parameter";
                return;
            }

        }

        public bool JudgeUnNull()
        {
            if (textHeight.Text == string.Empty || textLength.Text == string.Empty || textTh1.Text == string.Empty || textTh2.Text == string.Empty || textPer1.Text == string.Empty || textPer2.Text == string.Empty)
            {
                return false;
            }
            else return true;
        }

        public bool JudgeLegal()
        {
            if (num1 <= 90 && num1 >= 0 && num2 <= 90 && num2 >= 0 && per1 > 0 && per1 < 1 && per2 > 0 && per2 < 1 && n<=20 && n>0 && length>0 && length<=200)
                return true;
            else
                return false;
        }

        public void ClearInvaildInput()
        {
            if (!(num1 <= 90 && num1 >= 0))
                textTh1.Clear();
            if (!(num2 <= 90 && num2 >= 0))
                textTh2.Clear();
            if (!(per1 > 0 && per1 < 1))
                textPer1.Clear();
            if (!(per2 > 0 && per2 < 1))
                textPer2.Clear();
            if (!(n <= 20 && n > 0))
                textHeight.Clear();
            if (!(length > 0 && length <= 200))
                textLength.Clear();   
        }


       
        void DrawCayleyTree(int n, double x0,double y0,double length,double th)
        {
            if (n == 0)
                return;
            double x1 = x0 + length * Math.Cos(th);
            double y1 = y0 + length * Math.Sin(th);

            DrawLine(x0, y0, x1, y1);

            DrawCayleyTree(n - 1, x1, y1, per1 * length, th + th1);
            DrawCayleyTree(n - 1, x1, y1, per2 * length, th - th2);
        }

        void DrawLine(double x0,double y0,double x1,double y1)
        {
            Pen p = new Pen(color.Color);
            graphics.DrawLine(p, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void textHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != 8) && (e.KeyChar != 46))
            {
                e.Handled = true;
                LblWarning.Text = "input numbers";
            }
            else if(e.KeyChar == 46)
            {
                e.Handled = true;
                LblWarning.Text = "input integer";
            }
            else
                LblWarning.Text = "";
        }

        private void textPer1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != 8) && (e.KeyChar != 46))
            {
                e.Handled = true;
                LblWarning.Text = "input numbers";
            }
            else
                LblWarning.Text = "";
        }

        private void BtnColorDialog_Click(object sender, EventArgs e)
        {
            color.ShowDialog();
        }
    }
}
