using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCalculator
{
    public partial class RCalculator : Form
    {
        calcClass ray = new calcClass();

        public RCalculator()
        {
            InitializeComponent();

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtbx.Text =="0")
            {
                txtbx.Clear();
            }
            if (ray.OperationPress1)
            {
                ray.Num1 = txtbx.Text;
                txtbx.Text = "";
            }
            txtbx.Text += "1";
            ray.OperationPress1 = false;

        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtbx.Text == "0")
            {
                txtbx.Clear();
            }
            if (ray.OperationPress1)
            {
                ray.Num1 = txtbx.Text;
                txtbx.Text = "";
            }
            txtbx.Text += "2";
            ray.OperationPress1 = false;

        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtbx.Text == "0")
            {
                txtbx.Clear();
            }
            if (ray.OperationPress1)
            {
                ray.Num1 = txtbx.Text;
                txtbx.Text = "";
            }
            txtbx.Text += "3";
            ray.OperationPress1 = false;
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtbx.Text == "0")
            {
                txtbx.Clear();
            }
            if (ray.OperationPress1)
            {
                ray.Num1 = txtbx.Text;
                txtbx.Text = "";
            }
            txtbx.Text += "4";
            ray.OperationPress1 = false;
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtbx.Text == "0")
            {
                txtbx.Clear();
            }
            if (ray.OperationPress1)
            {
                ray.Num1 = txtbx.Text;
                txtbx.Text = "";
            }
            txtbx.Text += "5";
            ray.OperationPress1 = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtbx.Text == "0")
            {
                txtbx.Clear();
            }
            if (ray.OperationPress1)
            {
                ray.Num1 = txtbx.Text;
                txtbx.Text = "";
            }
            txtbx.Text += "6";
            ray.OperationPress1 = false;
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtbx.Text == "0")
            {
                txtbx.Clear();
            }
            if (ray.OperationPress1)
            {
                ray.Num1 = txtbx.Text;
                txtbx.Text = "";
            }
            txtbx.Text += "7";
            ray.OperationPress1 = false;
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtbx.Text == "0")
            {
                txtbx.Clear();
            }
            if (ray.OperationPress1)
            {
                ray.Num1 = txtbx.Text;
                txtbx.Text = "";
            }
            txtbx.Text += "8";
            ray.OperationPress1 = false;
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtbx.Text == "0")
            {
                txtbx.Clear();
            }
            if (ray.OperationPress1)
            {
                ray.Num1 = txtbx.Text;
                txtbx.Text = "";
            }
            txtbx.Text += "9";
            ray.OperationPress1 = false;
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtbx.Text == "0")
            {
                txtbx.Clear();
            }
            if (ray.OperationPress1)
            {
                ray.Num1 = txtbx.Text;
                txtbx.Text = "";
            }
            txtbx.Text += "0";
            ray.OperationPress1 = false;
        }
        private void btnpls_Click(object sender, EventArgs e)
        {
            ray.Operation = "+";
            ray.OperationPress1 = true;

        }
        private void btnmns_Click(object sender, EventArgs e)
        {
            ray.Operation = "-";
            ray.OperationPress1 = true;
        }
        private void btndiv_Click(object sender, EventArgs e)
        {
            ray.Operation = "/";
            ray.OperationPress1 = true;
        }
        private void btntms_Click(object sender, EventArgs e)
        {
            ray.Operation = "*";
            ray.OperationPress1 = true;
        }
        private void btnequal_Click(object sender, EventArgs e)
        {
            switch (ray.Operation)
            {
                case "+":
                    txtbx.Text = (float.Parse(ray.Num1) + float.Parse(txtbx.Text)).ToString();
                    break;
                case "-":
                    txtbx.Text = (float.Parse(ray.Num1) - float.Parse(txtbx.Text)).ToString();
                    break;
                case "/":
                    txtbx.Text = (float.Parse(ray.Num1) / float.Parse(txtbx.Text)).ToString();
                    break;
                case "*":
                    txtbx.Text = (float.Parse(ray.Num1) * float.Parse(txtbx.Text)).ToString();
                    break;
                default:
                    break;
            }
            btnCE.Enabled = false;
            btndel.Enabled = false;
        }
        private void btnsqrt_Click(object sender, EventArgs e)
        {
            double sqrt = double.Parse(txtbx.Text);
            txtbx.Text = "";
            sqrt = Math.Sqrt(sqrt);
            txtbx.Text = System.Convert.ToString(sqrt);
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (txtbx.Text.Length > 1)
            {
                txtbx.Text = txtbx.Text.Remove(txtbx.Text.Length - 1);
            }
        }
        private void btnCE_Click(object sender, EventArgs e)
        {
            if (txtbx.Text.Length > 0)
            {
                txtbx.Text = txtbx.Text.Remove(txtbx.Text.Length - 1);
            }
        }
        private void btnC_Click_1(object sender, EventArgs e)
        {
            txtbx.Text = "0";
            btnCE.Enabled = true;
            btndel.Enabled = true;

        }
        private void btnngtn_Click(object sender, EventArgs e)
        {
            double ngtn = double.Parse(txtbx.Text);
            txtbx.Text = "";
            ngtn = ngtn * -1;
            txtbx.Text = System.Convert.ToString(ngtn);
        }
        private void btnrecip_Click(object sender, EventArgs e)
        {
            double recip = double.Parse(txtbx.Text);
            txtbx.Text = "";
            recip = 1 / recip;
            txtbx.Text = System.Convert.ToString(recip);
        }
        private void btnpercent_Click(object sender, EventArgs e)
        {
            double prcnt = double.Parse(txtbx.Text);
            txtbx.Text = "";
            prcnt = prcnt / 100;
            txtbx.Text = System.Convert.ToString(prcnt);
        }
        private void btnpoint_Click(object sender, EventArgs e)
        {
            txtbx.Text = txtbx.Text + "." + ray.Num2;
        }
        //extras


        }
    }
    



