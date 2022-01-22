using System;
using System.Windows.Forms;

namespace BookCross
{
    public partial class ReaderForm : Form
    {
        public ReaderForm(ReaderPresenter called)
        {
            InitializeComponent();
            presenter = called;
        }

        ReaderPresenter presenter;

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

        private void OkButton_Click(object sender, EventArgs e)
        {
            presenter.Add();
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void anyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "")
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
