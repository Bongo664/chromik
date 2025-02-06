using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text += "3";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox2.Text += "4";
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox2.Text += "5";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox2.Text += "6";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox2.Text += "7";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox2.Text += "8";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textBox2.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox2.Text += "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

    }
}
