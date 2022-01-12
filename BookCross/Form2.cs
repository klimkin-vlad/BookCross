using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BookCross
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Form1 main = Owner as Form1;
        }

        public List<string> GetTextboxes()
        {
            List<string> dataBook = new List<string>();
            dataBook.Add(textBox1.Text);
            dataBook.Add(textBox2.Text);
            dataBook.Add(textBox3.Text);
            return dataBook;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != "") && (textBox3.Text != ""))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
