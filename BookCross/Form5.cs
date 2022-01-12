using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookCross
{
    public partial class Form5 : Form
    {
        public Form5(string author, string name, string year)
        {
            InitializeComponent();
            textBox1.Text = author;
            textBox2.Text = name;
            textBox3.Text = year;
        }

        public void AddReaders(int index, string name)
        {
            string reader = index + " (" + name + ")";
            comboBox1.Items.Add(reader);
        }

        public void AddPlaces(int index, string departure, string arrival)
        {
            string place = index + " (" + departure + " " + arrival + ")";
            comboBox2.Items.Add(place);
        }

        private void comboBox1_TextUpdate(object sender, EventArgs e)
        {
            if ((comboBox1.Text != "") && (comboBox2.Text != ""))
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
