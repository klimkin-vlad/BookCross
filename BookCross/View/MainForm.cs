using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BookCross
{
    public partial class MainForm : Form
    {
        public MainForm(MainPresenter called)
        {
            InitializeComponent();
            presenter = called;
        }

        MainPresenter presenter;

        public void Clear()
        {
            mainTable.Rows.Clear();
            mainTable.Columns.Clear();
        }

        public void SetHeaders(List<string> headers)
        {
            foreach (string column in headers)
            {
                mainTable.Columns.Add(column, column);
            }
        }

        public void SetTableValues(List<List<string>> items)
        {
            DataGridViewRow row;
            DataGridViewCell cell;
            foreach (List<string> item in items)
            {
                row = new DataGridViewRow();
                foreach (string property in item)
                {
                    cell = new DataGridViewTextBoxCell
                    {
                        Value = property
                    };
                    row.Cells.Add(cell);
                }
                mainTable.Rows.Add(row);
            }
        }

        public List<string> GetCurrentRow()
        {
            List<string> rowData = new List<string>();
            DataGridViewRow row = mainTable.CurrentRow;
            foreach (DataGridViewCell cell in row.Cells)
            {
                rowData.Add((string)cell.Value);
            }
            return rowData;
        }

        private void ShowReaderButton_Click(object sender, EventArgs e)
        {
            presenter.ChangeModeToReader();
            addButton.Enabled = true;
            takeButton.Enabled = false;
        }

        private void ShowBookButton_Click(object sender, EventArgs e)
        {
            presenter.ChangeModeToBook();
            addButton.Enabled = true;
        }

        private void ShowPlaceButton_Click(object sender, EventArgs e)
        {
            presenter.ChangeModeToPlace();
            addButton.Enabled = true;
            takeButton.Enabled = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            presenter.Add((int)DialogResult.OK);
        }

        private void TakeButton_Click(object sender, EventArgs e)
        {
            presenter.Take((int)DialogResult.OK);
        }

        private void MainTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Проверка на наличие выделения
            if (mainTable.CurrentRow != null)
            {
                if ((string)mainTable.CurrentRow.Cells[3].Value == "Взята")
                {
                    takeButton.Enabled = false;
                }
                else
                {
                    takeButton.Enabled = true;
                }
            }
        }
    }
}
