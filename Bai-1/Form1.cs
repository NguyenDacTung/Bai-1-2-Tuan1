using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_0._1
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                float.Parse(txtNum1.Text);
                float.Parse(txtNum2.Text);
            }
            catch(Exception ex) {
                MessageBox.Show("Vui lòng nhập số hợp lệ");
                return;
            }
            txtKetqua.Text = (float.Parse(txtNum1.Text) + float.Parse(txtNum2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                float.Parse(txtNum1.Text);
                float.Parse(txtNum2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ");
                return;
            }
            txtKetqua.Text = (float.Parse(txtNum1.Text) - float.Parse(txtNum2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                float.Parse(txtNum1.Text);
                float.Parse(txtNum2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ");
                return;
            }
            txtKetqua.Text = (float.Parse(txtNum1.Text) * float.Parse(txtNum2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                float.Parse(txtNum1.Text);
                float.Parse(txtNum2.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ");
                return;
            }
            txtKetqua.Text = (float.Parse(txtNum1.Text) / float.Parse(txtNum2.Text)).ToString();
        }
    }
}
