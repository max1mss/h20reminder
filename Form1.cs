﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Newtonsoft.Json;

//https://www.hydrationforhealth.com/en/hydration-tools/hydration-calculator/
//https://www.wku.edu/news/articles/index.php?view=article&articleid=2762&return=archive

namespace H2Oreminder
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

        private void button1_Click(object sender, EventArgs e)
        {
           
            // Check if any radio button is checked
            if (radioButton1.Checked)
            {
                // Instantiate and show Form3
                Form4 form4 = new Form4();
                form4.Show();
            }
            else if (radioButton2.Checked)
            {
                // Instantiate and show Form2
                Form2 form2 = new Form2();
                form2.Show();
            }
            else
            {
                // Show message box if neither radio button is checked
                MessageBox.Show("Please select an option first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;
            }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
            }
            



        }


        
    }
}

    

        
       