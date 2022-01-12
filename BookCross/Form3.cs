using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BookCross
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public List<string> GetTextboxes()
        {
            List<string> dataReader = new List<string>();
            dataReader.Add(textBox1.Text);
            return dataReader;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }
    }
}
