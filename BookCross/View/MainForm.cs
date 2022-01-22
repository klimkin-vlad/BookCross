using System;
using System.Collections.Generic;
using System.Data;
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

        public void SetTableValues(DataTable sourceTable)
        {
            mainTable.DataSource = sourceTable;
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
