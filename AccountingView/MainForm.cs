using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using AccountingModel.AccountingTypes;

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
            if (addWorkerForm.newStaff != null)
            {
                WorkerList.Add(addWorkerForm.newStaff);
                WorkersGridView.Rows.Add(
                    addWorkerForm.newStaff.Firstname, 
                    addWorkerForm.newStaff.Surname, 
                    addWorkerForm.newStaff.GetSalaryValue());
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Worker staff in WorkerList)
                {
                    if (staff.Firstname 
                        == WorkersGridView.CurrentRow.Cells[0].Value.ToString()
                        && staff.Surname 
                        == WorkersGridView.CurrentRow.Cells[1].Value.ToString()
                        && staff.GetSalaryValue().ToString() 
                        == WorkersGridView.CurrentRow.Cells[2].Value.ToString())
                    {
                        WorkersGridView.Rows.Remove(WorkersGridView.CurrentRow);
                        WorkerList.Remove(staff);
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
                            var settings = new JsonSerializerSettings 
                            { 
                                TypeNameHandling = TypeNameHandling.All 
                            }; 
                            StreamReader streamReader = new StreamReader(fileStream);
                            WorkerList = 
                                JsonConvert.DeserializeObject<List<Worker>>(
                                    streamReader.ReadLine(), settings); 
                            streamReader.Close(); 
                            fileStream.Close();
                            WorkersGridView.Rows.Clear();
                            foreach (Worker staff in WorkerList) 
                            {
                                WorkersGridView.Rows.Add(staff.Firstname, 
                                    staff.Surname, staff.GetSalaryValue());
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
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            }; 
            string workersSerializedToString = 
                JsonConvert.SerializeObject(WorkerList, settings);
            Stream fileStream;
            SaveFileDialog saveWorkersFileDialog = new SaveFileDialog();

            saveWorkersFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveWorkersFileDialog.FilterIndex = 2;
            saveWorkersFileDialog.RestoreDirectory = true;

            if (saveWorkersFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((fileStream = saveWorkersFileDialog.OpenFile()) != null)
                {
                    StreamWriter streamWriter = new StreamWriter(fileStream);
                    streamWriter.WriteLine(workersSerializedToString);
                    streamWriter.Flush();
                    streamWriter.Close();
                    fileStream.Close();
                }
            }
        }

        private void AddRandomWorker_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string name = "Имя" + random.Next(1, 100);
            string surname = "Фамилия" + random.Next(1, 100);
            Worker staff;

            if (random.Next(0, 2) == 1)
            {
                staff = new HourlyWorker(name, surname, 
                    random.Next(1, 300), random.Next(80, 200));
            }
            else
            {
                staff = new MonthlyWorker(name, surname, 
                    random.Next(10000,100000),
                    random.Next(10, 200)*0.01,
                    random.Next(0,5000));
            }
            WorkerList.Add(staff);
            WorkersGridView.Rows.Add(staff.Firstname, staff.Surname, 
                staff.GetSalaryValue());
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            Worker selectedStaff = null;
            try
            {
                foreach (Worker staff in WorkerList)
                {
                    if (staff.Firstname 
                        == WorkersGridView.CurrentRow.Cells[0].Value.ToString()
                        && staff.Surname 
                        == WorkersGridView.CurrentRow.Cells[1].Value.ToString()
                        && staff.GetSalaryValue().ToString() 
                        == WorkersGridView.CurrentRow.Cells[2].Value.ToString())
                    {
                        selectedStaff = staff;
                        break;
                    }
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Wrong");
            }
            if (selectedStaff != null)
            {
                AddWorkerForm EditWorkerForm = new AddWorkerForm(selectedStaff);
                EditWorkerForm.ShowDialog();
                if (EditWorkerForm.newStaff != null)
                {
                    WorkerList.Remove(selectedStaff);
                    WorkerList.Add(EditWorkerForm.newStaff);
                    WorkersGridView.CurrentRow.SetValues(EditWorkerForm.newStaff.Firstname, 
                        EditWorkerForm.newStaff.Surname, 
                        EditWorkerForm.newStaff.GetSalaryValue());
                }
            }
        }
    }
}
