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
        String num2 = ""; 

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
            txtbx.Text += "3";
            OperationPress = false;
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (OperationPress)
            {
                num1 = txtbx.Text;
                txtbx.Text = "";
            }
            txtbx.Text += "4";
            OperationPress = false;
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (OperationPress)
            {
                num1 = txtbx.Text;
                txtbx.Text = "";
            }
            txtbx.Text += "5";
            OperationPress = false;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (OperationPress)
            {
                num1 = txtbx.Text;
                txtbx.Text = "";
            }
            txtbx.Text += "6";
            OperationPress = false;
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (OperationPress)
            {
                num1 = txtbx.Text;
                txtbx.Text = "";
            }
            txtbx.Text += "7";
            OperationPress = false;
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (OperationPress)
            {
                num1 = txtbx.Text;
                txtbx.Text = "";
            }
            txtbx.Text += "8";
            OperationPress = false;
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (OperationPress)
            {
                num1 = txtbx.Text;
                txtbx.Text = "";
            }
            txtbx.Text += "9";
            OperationPress = false;
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (OperationPress)
            {
                num1 = txtbx.Text;
                txtbx.Text = "";
            }
            txtbx.Text += "0";
            OperationPress = false;
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
                    txtbx.Text = (float.Parse(num1) * float.Parse(txtbx.Text)).ToString();
                    break;
                default:
                    break;
            }
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
            if (txtbx.Text.Length > 1)
            {
                txtbx.Text = txtbx.Text.Remove(txtbx.Text.Length - 1);
            }
        }
        private void btnC_Click_1(object sender, EventArgs e)
        {
            txtbx.Text = "0";
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
            txtbx.Text = txtbx.Text + "." + num2;
        }
        //extras
   

        private void back_Click(object sender, EventArgs e)
        {
            fb.Visible = false;
            ytb.Visible = false;
        }
        private void btnfb_Click(object sender, EventArgs e)
        {
            fb.Visible = true;
            fb.Size = new Size(fb.Size.Width, 344);
            fb.Size = new Size(fb.Size.Height, 512);
            ytb.Visible = false;            
        }
        private void btnytb_Click(object sender, EventArgs e)
        {
            ytb.Visible = true;
            ytb.Size = new Size(ytb.Size.Width, 344);
            ytb.Size = new Size(ytb.Size.Height, 512);
            fb.Visible = false;
        }

        private void RCalculator_Load(object sender, EventArgs e)
        {
            
        }
    
    }
}
    



