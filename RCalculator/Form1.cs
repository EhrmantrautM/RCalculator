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
            txtbx.Text = "0";
            if (txtbx.Text !="0")
            {
                txtbx.Text = txtbx.Text.Remove(txtbx.TextLength -1);
            }          
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
       
        private void RCalculator_Load(object sender, EventArgs e)
        {
            fb.Visible = false;
            yt.Visible = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            fb.Visible = false;
            yt.Visible = false;
        }

        private void btnyt_Click(object sender, EventArgs e)
        {
            yt.Visible = true;
            yt.Size = new Size(yt.Size.Width, 344);
            yt.Size = new Size(yt.Size.Height, 534);
            fb.Visible = false;
            back.Visible = true;
        }         
            private void btnfb_Click(object sender, EventArgs e)
        {
            fb.Visible = true;
            fb.Size = new Size(fb.Size.Width, 342);
            fb.Size = new Size(fb.Size.Height, 527);
            yt.Hide();           
        }


    }
}
    



