using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H2Oreminder
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = numericUpDown1.Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int value))
            {
                if (value >= numericUpDown1.Minimum && value <= numericUpDown1.Maximum)
                {
                    numericUpDown1.Value = value;
                }
                else if (value < numericUpDown1.Minimum)
                {
                    numericUpDown1.Value = numericUpDown1.Minimum;
                }
                else
                {
                    numericUpDown1.Value = numericUpDown1.Maximum;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox2.Text, out int value))
            {
                if (value >= numericUpDown2.Minimum && value <= numericUpDown2.Maximum)
                {
                    numericUpDown2.Value = value;
                }
                else if (value < numericUpDown2.Minimum)
                {
                    numericUpDown2.Value = numericUpDown2.Minimum;
                }
                else
                {
                    numericUpDown2.Value = numericUpDown2.Maximum;
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox3.Text, out int value))
            {
                if (value >= numericUpDown3.Minimum && value <= numericUpDown3.Maximum)
                {
                    numericUpDown3.Value = value;
                }
                else if (value < numericUpDown3.Minimum)
                {
                    numericUpDown3.Value = numericUpDown3.Minimum;
                }
                else
                {
                    numericUpDown3.Value = numericUpDown3.Maximum;
                }
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            textBox2.Text = numericUpDown2.Value.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            textBox3.Text = numericUpDown3.Value.ToString();
        }
    }
}
