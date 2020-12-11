using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
            if (textBox1.Text != "DELETE" && textBox1.Text != "BLUE" )
            {
                label2.Text = textBox1.Text;
            }
            else if (textBox1.Text == "DELETE")
            {
                label2.Text = "[EMPTY]";
            }
            else if (label2.Text == "BLUE")
            {
                label2.Text = "[EMPTY]";
                label2.ForeColor = Color.Blue;
            }

            label2.Text = textBox1.Text;
            if (textBox1.Text != "DELETE" && textBox1.Text != "RED")
            {
                label2.Text = textBox1.Text;
            }
            else if (textBox1.Text == "DELETE")
            {
                label2.Text = "[EMPTY]";
            }
            else if (label2.Text == "RED")
            {
                label2.Text = "[EMPTY]";
                label2.ForeColor = Color.Red;
            }

            label2.Text = textBox1.Text;
            if (textBox1.Text != "DELETE" && textBox1.Text != "GREEN")
            {
                label2.Text = textBox1.Text;
            }
            else if (textBox1.Text == "DELETE")
            {
                label2.Text = "[EMPTY]";
            }
            else if (label2.Text == "GREEN")
            {
                label2.Text = "[EMPTY]";
                label2.ForeColor = Color.Green;
            }

            if (textBox1.Text == "SHOWN" )
            {
                label2.Visible = true;
            }
            else if (textBox1.Text == "HIDE")
            {
                label2.Visible = false;
            }



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
