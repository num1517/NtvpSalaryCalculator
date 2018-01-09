using System;
using System.Windows.Forms;
using AccountingModel.AccountingTypes;

namespace AccountingView
{
    public partial class AddWorkerForm : Form
    {
        public Worker newStaff = null;

        public AddWorkerForm()
        {
            InitializeComponent();
        }

        public AddWorkerForm(Worker staff)
        {
            InitializeComponent();
            salaryControl1.SetStaff(staff);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            newStaff = salaryControl1.GetSalary();
            if (newStaff != null)
            {
                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
