using System;
using System.Windows.Forms;

namespace BookCross
{
    public partial class PlaceForm : Form
    {
        public PlaceForm(PlacePresenter called)
        {
            InitializeComponent();
            presenter = called;
        }

        PlacePresenter presenter;

        public string departure
        {
            get
            {
                return departureTextBox.Text;
            }
            set
            {
                departureTextBox.Text = value;
            }
        }

        public string arrival
        {
            get
            {
                return arrivalTextBox.Text;
            }
            set
            {
                arrivalTextBox.Text = value;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((departureTextBox.Text != "") && (arrivalTextBox.Text != ""))
            {
                okButton.Enabled = true;
            }
            else
            {
                okButton.Enabled = false;
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
    }
}
