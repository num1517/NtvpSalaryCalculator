using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using AccountingModel.AccountingTypes;
using AccountingModel.Utility;

namespace AccountingView
{
    public partial class MainForm : Form
    {
        List<Worker> WorkerList = new List<Worker> ();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddWorkerForm addWorkerForm = new AddWorkerForm();
            addWorkerForm.ShowDialog();
            if (addWorkerForm.newWorker != null)
            {
                WorkerList.Add(addWorkerForm.newWorker);
                WorkersGridView.Rows.Add(
                    addWorkerForm.newWorker.Firstname, 
                    addWorkerForm.newWorker.Surname, 
                    addWorkerForm.newWorker.GetSalaryValue());
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Worker worker in WorkerList)
                {
                    if (worker.Firstname 
                        == WorkersGridView.CurrentRow.Cells[0].Value.ToString()
                        && worker.Surname 
                        == WorkersGridView.CurrentRow.Cells[1].Value.ToString()
                        && worker.GetSalaryValue().ToString() 
                        == WorkersGridView.CurrentRow.Cells[2].Value.ToString())
                    {
                        WorkersGridView.Rows.Remove(WorkersGridView.CurrentRow);
                        WorkerList.Remove(worker);
                        break;
                    }
                }
            }
            catch(ArgumentNullException)
            {
                MessageBox.Show("Something went wrong");
            }
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream fileStream = null; 
            OpenFileDialog openWorkersFileDialog = new OpenFileDialog();

            openWorkersFileDialog.InitialDirectory = "c:\\"; 
            openWorkersFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; 
            openWorkersFileDialog.FilterIndex = 2; 
            openWorkersFileDialog.RestoreDirectory = true; 

            if (openWorkersFileDialog.ShowDialog() == DialogResult.OK) 
            { 
                try 
                { 
                    if ((fileStream = openWorkersFileDialog.OpenFile()) != null) 
                    { 
                        using (fileStream) 
                        {
                            Serializer serializer = new Serializer();
                            WorkerList = serializer.Deserialize(fileStream);
                            fileStream.Close();
                            WorkersGridView.Rows.Clear();
                            foreach (Worker worker in WorkerList) 
                            {
                                WorkersGridView.Rows.Add(worker.Firstname, 
                                    worker.Surname, worker.GetSalaryValue());
                            }
                        } 
                    } 
                } 
                catch (Exception ex) 
                { 
                    MessageBox.Show("Error: Could not read file from disk. Original error: " 
                        + ex.Message); 
                } 
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream fileStream;
            SaveFileDialog saveWorkersFileDialog = new SaveFileDialog();

            saveWorkersFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveWorkersFileDialog.FilterIndex = 2;
            saveWorkersFileDialog.RestoreDirectory = true;

            if (saveWorkersFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((fileStream = saveWorkersFileDialog.OpenFile()) != null)
                {
                    
                    Serializer serializer = new Serializer();
                    serializer.Serialize(WorkerList, fileStream);
                    fileStream.Close();
                }
            }
        }

        private void AddRandomWorker_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string name = "Firstname" + random.Next(1, 100);
            string surname = "Surname" + random.Next(1, 100);
            Worker worker;

            if (random.Next(0, 2) == 1)
            {
                worker = new HourlyWorker(name, surname, 
                    random.Next(30, 1000), random.Next(80, 200));
            }
            else
            {
                worker = new MonthlyWorker(name, surname, 
                    random.Next(10000,100000),
                    random.Next(10, 200)*0.01,
                    random.Next(0,5000));
            }
            WorkerList.Add(worker);
            WorkersGridView.Rows.Add(worker.Firstname, worker.Surname, 
                worker.GetSalaryValue());
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Worker selectedWorker = null;
            try
            {
                foreach (Worker worker in WorkerList)
                {
                    if (worker.Firstname 
                        == WorkersGridView.CurrentRow.Cells[0].Value.ToString()
                        && worker.Surname 
                        == WorkersGridView.CurrentRow.Cells[1].Value.ToString()
                        && worker.GetSalaryValue().ToString() 
                        == WorkersGridView.CurrentRow.Cells[2].Value.ToString())
                    {
                        selectedWorker = worker;
                        break;
                    }
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Wrong");
            }
            if (selectedWorker != null)
            {
                AddWorkerForm EditWorkerForm = new AddWorkerForm(selectedWorker);
                EditWorkerForm.Text = "Edit worker";
                EditWorkerForm.ShowDialog();
                if (EditWorkerForm.newWorker != null)
                {
                    WorkerList.Remove(selectedWorker);
                    WorkerList.Add(EditWorkerForm.newWorker);
                    WorkersGridView.CurrentRow.SetValues(EditWorkerForm.newWorker.Firstname, 
                        EditWorkerForm.newWorker.Surname, 
                        EditWorkerForm.newWorker.GetSalaryValue());
                }
            }
        }
    }
}
