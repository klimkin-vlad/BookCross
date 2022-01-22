using System;
using System.Windows.Forms;

namespace BookCross
{
    public partial class BookForm : Form
    {
        public BookForm(BookPresenter called)
        {
            InitializeComponent();
            presenter = called;
        }

        BookPresenter presenter;

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

        public string name
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((authorTextBox.Text != "") && (nameTextBox.Text != "") && (yearTextBox.Text != ""))
            {
                okButton.Enabled = true;
            }
            else
            {
                okButton.Enabled = false;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            presenter.Add();
            Close();
        }
    }
}
