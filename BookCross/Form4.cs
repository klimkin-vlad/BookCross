using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BookCross
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public List<string> GetTextboxes()
        {
            List<string> dataBook = new List<string>();
            dataBook.Add(textBox1.Text);
            dataBook.Add(textBox2.Text);
            return dataBook;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
