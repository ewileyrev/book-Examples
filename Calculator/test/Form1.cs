using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 num1 = Convert.ToInt32(textBox1.Text);
            Int32 num2 = Convert.ToInt32(textBox2.Text);
            Int32 result = num1 - num2;
            label2.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int32 num1 = Convert.ToInt32(textBox1.Text);
            Int32 num2 = Convert.ToInt32(textBox2.Text);
            Int32 result = num1 + num2;
            label2.Text = result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Int32 num1 = Convert.ToInt32(textBox1.Text);
            Int32 num2 = Convert.ToInt32(textBox2.Text);
            Int32 result = num1 * num2;
            label2.Text = result.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Int32 num1 = Convert.ToInt32(textBox1.Text);
            Int32 num2 = Convert.ToInt32(textBox2.Text);
            Int32 result = num1 / num2;
            label2.Text = result.ToString();
        }
    }
}
