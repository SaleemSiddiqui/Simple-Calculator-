using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {

        double pie = 3.15, first;
        string checks = "true";
        char check='t';


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + ".";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void creditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Invented by Saleem Siddiqui");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            display.Text = display.Text+"0";
        }

        private void display_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void one_Click(object sender, EventArgs e)
        {
            display.Text = display.Text+"1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            display.Text = display.Text + "9";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(display.Text);
            check = '/';
        }

        private void add_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(display.Text);
            check = '+';
            display.Text = "";
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(display.Text);
            check = '-';
            display.Text = "";
        }

        private void product_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(display.Text);
            check = '*';
            display.Text = "";
        }

        private void cube_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(display.Text);
            display.Text = Convert.ToString(first * first * first);
        }

        private void square_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(display.Text);
            display.Text = Convert.ToString(first * first);
        }

        private void cos_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(display.Text);
            display.Text = Convert.ToString(Math.Cos(first));
        }

        private void sin_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(display.Text);
            display.Text = Convert.ToString(Math.Sin(first));
        }

        private void tan_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(display.Text);
            display.Text = Convert.ToString(Math.Tan(first));
        }

        private void tansin_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(display.Text);
            display.Text = Convert.ToString(1/Math.Tan(first));
        }

        private void sinsin_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(display.Text);
            display.Text = Convert.ToString(1/Math.Sin(first));
        }

        private void cosin_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(display.Text);
            display.Text = Convert.ToString(1/Math.Cos(first));
        }

        private void percentage_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(display.Text);
            check = '%';
            display.Text = "";
        }

        private void pi_Click(object sender, EventArgs e)
        {
            display.Text = "3.15";
        }

        private void log_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(display.Text);
            display.Text = Convert.ToString(Math.Log(first));
        }

        private void binary_Click(object sender, EventArgs e)
        {
           
        }

        private void equal_Click(object sender, EventArgs e)
        {
            double second = Convert.ToDouble(display.Text);
            if (check == '+')
            {
                display.Text = Convert.ToString(first + second);
            }
            else
                if (check == '-')
                {
                    display.Text = Convert.ToString(first - second);
                }
                else
                    if (check == '*')
                    {
                        display.Text = Convert.ToString(first * second);
                    }
                    else
                        if (check == '/')
                        {
                            display.Text = Convert.ToString(first / second);
                        }
                        else
                            if (check == '%')
                            {
                                display.Text = Convert.ToString(((first / second)*100)+"%");
                            }
                            else
                                if (check == '^')
                                {
                                    double p=1;
                                    for (double i = second; i > 0; i--)
                                        p = p * first;
                                    display.Text = Convert.ToString(p);
                                }
                                
                                    
                
        }

        private void rmove_Click(object sender, EventArgs e)
        {
            display.Text = "";
        }

        private void npower_Click(object sender, EventArgs e)
        {
            first = Convert.ToDouble(display.Text);
            check = '^';
            display.Text = "";
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            double fact = 1;
            first = Convert.ToDouble(display.Text);
            for (double i = first; i > 0; i--)
                fact = fact * i;
            display.Text = Convert.ToString(fact);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
