using System;
using System.Windows.Forms;

namespace DAT.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CloseForm(object sender, EventArgs e) => Close();
    }
}
