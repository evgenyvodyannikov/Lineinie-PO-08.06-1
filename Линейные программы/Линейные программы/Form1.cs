using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Линейные_программы
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                const double inch = 2.54;
                double s = Double.Parse(textBox1.Text);
                textBox2.Text = Convert.ToString(s * inch / 100);
                textBox3.Text = Convert.ToString(s * inch);
                textBox4.Text = Convert.ToString(s * inch * 10);
            }
            catch
            {
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {
                if (textBox1.Text.Length == 4 && textBox1.Text.Length <= 4)
                {
                    e.Handled = true;
                }
                return;
            }
            if (e.KeyChar == ',')
            {
                if ((textBox1.Text.IndexOf(',') != -1) || (textBox1.Text.Length == 0)) 
                {
                    e.Handled = true;
                }
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Back)
                {
                    return;
                }
            }
            e.Handled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
