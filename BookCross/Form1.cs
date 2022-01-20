using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BookCross
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Readers allReaders;
        Books allBooks;
        Places allPlaces;
        int mode = 0;

        public void Prepare(int chooser)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            mode = chooser;
        }

        public void AddColumns(List<string> columns)
        {
            foreach (string column in columns)
            {
                dataGridView1.Columns.Add(column, column);
            }
        }

        public void SetValues(int index1, List<string> values)
        {
            int index2 = 0;
            dataGridView1.Rows.Add();
            dataGridView1.Rows[index1].Cells[0].Value = index1 + 1;
            foreach (string value in values)
            {
                index2 += 1;
                dataGridView1.Rows[index1].Cells[index2].Value = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prepare(1);
            button4.Enabled = true;
            List<string> toShow;
            int index = allReaders.Count();
            AddColumns(new List<string> { "№", "ФИО" });
            while (index > 1)
            {
                toShow = new List<string> { allReaders.GetName(index) };
                SetValues(index, toShow);
                index -= 1;
            }
            button5.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prepare(2);
            button4.Enabled = true;
            List<string> toShow;
            int index = allBooks.Count();
            AddColumns(new List<string> { "№", "Автор", "Название", "Год", "Статус" });
            while (index > 1)
            {
                toShow = allBooks.GetAll(index);
                if (allBooks.GetStatus(index))
                {
                    toShow.Add("Взята");
                }
                else
                {
                    toShow.Add("Свободна");
                }
                SetValues(index, toShow);
                index -= 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Prepare(3);
            button4.Enabled = true;
            List<string> toShow;
            int index = allPlaces.Count();
            AddColumns(new List<string> { "№", "Место отправления", "Место прибытия" });
            while (index > 1)
            {
                toShow = new List<string>();
                SetValues(index, toShow);
                index -= 1;
            }
            button5.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            allReaders = new Readers();
            allBooks = new Books();
            allPlaces = new Places();
        }

        public void AddReader()
        {
            Form3 dialog = new Form3();
            dialog.Owner = this;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                List<string> dataReader = dialog.GetTextboxes();
                allReaders.Add(allReaders.Count(), dataReader[0]);
            }
        }

        public void PublishBook()
        {
            Form2 dialog = new Form2();
            dialog.Owner = this;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                List<string> dataBook = dialog.GetTextboxes();
                allBooks.Publish(dataBook[0], dataBook[1], dataBook[2]);
            }
        }

        public void AddPlace()
        {
            Form4 dialog = new Form4();
            dialog.Owner = this;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                List<string> dataPlace = dialog.GetTextboxes();
                allPlaces.Add(allReaders.Count(), dataPlace[0], dataPlace[1]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> toShow = new List<string>();
            if (mode == 1)
            {
                AddReader();
                toShow.Add(allReaders.GetName(allReaders.Count()));
                SetValues(allReaders.Count() - 1, toShow);
            }
            else if (mode == 2)
            {
                PublishBook();
                toShow.Add(allBooks.GetAuthor(allBooks.Count()));
                toShow.Add(allBooks.GetName(allBooks.Count()));
                toShow.Add(allBooks.GetYear(allBooks.Count()));
                SetValues(allBooks.Count() - 1, toShow);
            }
            else if (mode == 3)
            {
                AddPlace();
                toShow.Add(allPlaces.GetDeparture(allPlaces.Count()));
                toShow.Add(allPlaces.GetArrival(allPlaces.Count()));
                SetValues(allPlaces.Count() - 1, toShow);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string author = allBooks.GetAuthor(allBooks.Count() - 1);
            string name = allBooks.GetName(allBooks.Count() - 1);
            string year = allBooks.GetYear(allBooks.Count() - 1);
            Form5 dialog = new Form5(author, name, year);
            dialog.Owner = this;
            int index = allReaders.Count();
            while (index > 1)
            {
                dialog.AddReaders(index, allReaders.GetName(index));
                index -= 1;
            }
            index = allPlaces.Count();
            while (index > 1)
            {
                dialog.AddPlaces(index, allPlaces.GetDeparture(index), allPlaces.GetArrival(index));
                index -= 1;
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (mode == 2)
            {
                if ((string)dataGridView1.CurrentRow.Cells[3].Value != "Взята")
                {
                    button5.Enabled = true;
                }
                else
                {
                    button5.Enabled = false;
                }
            }
        }
    }
}
