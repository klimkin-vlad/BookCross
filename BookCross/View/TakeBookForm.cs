using System;
using System.Windows.Forms;

namespace BookCross
{
    public partial class TakeBookForm : Form
    {
        public TakeBookForm(TakeBookPresenter called)
        {
            InitializeComponent();
            presenter = called;
        }

        TakeBookPresenter presenter;

        public string author
        {
            get
            {
                return authorTextBox.Text;
            }
            set
            {
                authorTextBox.Text = value;
            }
        }

        public string bookName
        {
            get
            {
                return nameTextBox.Text;
            }
            set
            {
                nameTextBox.Text = value;
            }
        }

        public string year
        {
            get
            {
                return yearTextBox.Text;
            }
            set
            {
                yearTextBox.Text = value;
            }
        }

        public string place
        {
            get
            {
                return placeComboBox.Text;
            }
            set
            {
                placeComboBox.Text = value;
            }
        }

        public string reader
        {
            get
            {
                return readerComboBox.Text;
            }
            set
            {
                readerComboBox.Text = value;
            }
        }

        public void AddReader(string info)
        {
            readerComboBox.Items.Add(info);
        }

        public void AddPlace(string info)
        {
            placeComboBox.Items.Add(info);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            presenter.Take();
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReaderComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((readerComboBox.Text != "") && (placeComboBox.Text != ""))
            {
                okButton.Enabled = true;
            }
            else
            {
                okButton.Enabled = false;
            }
        }

        private void PlaceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((readerComboBox.Text != "") && (placeComboBox.Text != ""))
            {
                okButton.Enabled = true;
            }
            else
            {
                okButton.Enabled = false;
            }
        }
    }
}
