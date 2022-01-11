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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Reader> allReaders;
        Books allBooks;
        List<Place> allPlaces;

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            string toShow;
            int index = 0;
            dataGridView1.Columns.Add("№", "№");
            dataGridView1.Columns.Add("ФИО", "ФИО");
            foreach (Reader current in allReaders)
            {
                toShow = current.GetName();
                dataGridView1[index, 0].Value = index + 1;
                dataGridView1[index, 1].Value = toShow;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            List<string> toShow;
            int index = allBooks.Count();
            dataGridView1.Columns.Add("№", "№");
            dataGridView1.Columns.Add("Автор", "Автор");
            dataGridView1.Columns.Add("Название", "Название");
            dataGridView1.Columns.Add("Год", "Год");
            while (index > 0)
            {
                toShow = allBooks.GetAll(index);
                dataGridView1[index, 0].Value = index + 1;
                dataGridView1[index, 1].Value = toShow[0];
                dataGridView1[index, 2].Value = toShow[1];
                dataGridView1[index, 3].Value = toShow[2];
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            string toShow1, toShow2;
            int index = 0;
            dataGridView1.Columns.Add("№", "№");
            dataGridView1.Columns.Add("Место отправления", "Место отправления");
            dataGridView1.Columns.Add("Место прибытия", "Место прибытия");
            foreach (Place current in allPlaces)
            {
                toShow1 = current.GetDeparture();
                toShow2 = current.GetArrival();
                dataGridView1[index, 0].Value = index + 1;
                dataGridView1[index, 1].Value = toShow1;
                dataGridView1[index, 2].Value = toShow2;
            }
        }
    }
}
