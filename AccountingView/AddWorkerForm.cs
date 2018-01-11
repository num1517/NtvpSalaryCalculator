using System;
using System.Windows.Forms;
using AccountingModel.AccountingTypes;

namespace AccountingView
{
    public partial class AddWorkerForm : Form
    {
        public Worker newWorker = null;

        public AddWorkerForm()
        {
            InitializeComponent();
        }

        public AddWorkerForm(Worker worker)
        {
            InitializeComponent();
            workerControl1.NewWorker = worker;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            newWorker = workerControl1.NewWorker;
            if (newWorker != null)
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
