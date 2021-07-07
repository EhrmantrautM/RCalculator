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
        String operation = "";
        Boolean OperationPress = false;
        String num1 = "";

        public RCalculator()
        {
            InitializeComponent();
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (OperationPress)
            {
                num1 = txtbx.Text;
                txtbx.Text = "";
            }
            txtbx.Text += "1";
            OperationPress = false;
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (OperationPress)
            {
                num1 = txtbx.Text;
                txtbx.Text = "";
            }
            txtbx.Text += "2";
            OperationPress = false;
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (OperationPress)
            {
                num1 = txtbx.Text;
                txtbx.Text = "";
            }
            txtbx.Text = txtbx.Text + "3";
            OperationPress = false;
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            txtbx.Text = txtbx.Text + "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            txtbx.Text = txtbx.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtbx.Text = txtbx.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtbx.Text = txtbx.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtbx.Text = txtbx.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtbx.Text = txtbx.Text + "9";
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            txtbx.Text = txtbx.Text + "0";
        }
        private void btnpls_Click(object sender, EventArgs e)
        {
            operation = "+";
            OperationPress = true;
        }
        private void btnmns_Click(object sender, EventArgs e)
        {
            operation = "-";
            OperationPress = true;
        }
        private void btndiv_Click(object sender, EventArgs e)
        {
            operation = "/";
            OperationPress = true;
        }
        private void btntms_Click(object sender, EventArgs e)
        {
            operation = "*";
            OperationPress = true;
        }
        private void btnx2_Click(object sender, EventArgs e)
        {

        }
        private void btnequal_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtbx.Text = (float.Parse(num1) + float.Parse(txtbx.Text)).ToString();
                    break;
                case "-":
                    txtbx.Text = (float.Parse(num1) - float.Parse(txtbx.Text)).ToString();
                    break;
                case "/":
                    txtbx.Text = (float.Parse(num1) / float.Parse(txtbx.Text)).ToString();
                    break;
                case "*":
                    txtbx.Text = (float.Parse(num1) / float.Parse(txtbx.Text)).ToString();
                    break;
                default:
                    break;
            }   

        }

 
        }
    }


       
    
