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
        public RCalculator()
        {
            InitializeComponent();
        }

        private void calculator(object sender, EventArgs e)
        {

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            txtbx.Text = txtbx.Text + 1;
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            txtbx.Text = txtbx.Text + 2;
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            txtbx.Text = txtbx.Text + 3;
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            txtbx.Text = txtbx.Text + 4;
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            txtbx.Text = txtbx.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtbx.Text = txtbx.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtbx.Text = txtbx.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtbx.Text = txtbx.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtbx.Text = txtbx.Text + 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtbx.Text = txtbx.Text + 0;
        }

        private void btnpls_Click(object sender, EventArgs e)
        {

        }
        private void btnmns_Click(object sender, EventArgs e)
        {

        }
        private void btndiv_Click(object sender, EventArgs e)
        {

        }
        private void btntms_Click(object sender, EventArgs e)
        {
          
        }
        private void btneq_Click(object sender, EventArgs e)
        {

        }
        private void txtbox(object sender, EventArgs e)
        {
             
        }

        
    }
}