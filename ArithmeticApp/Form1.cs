using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArithmeticApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double res;
            res = conNum1() + conNum2();
            txt_res.Text = res.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void txt_num1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_num2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            double res;
            res = conNum1() - conNum2();
            txt_res.Text = res.ToString();


        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            double res;
            res = conNum1() * conNum2();
            txt_res.Text = res.ToString();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            double res;
            res = conNum1() / conNum2();
            txt_res.Text = res.ToString();
        }

        private void txt_res_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            txt_res.Text = "";
        }
        private double conNum1()
        {
            return Convert.ToDouble(txt_num1.Text);
        }
        private double conNum2()
        {
            return Convert.ToDouble(txt_num2.Text);
        }
    }
}
