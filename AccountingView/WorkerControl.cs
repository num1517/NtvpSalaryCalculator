﻿using System;
using System.Windows.Forms;
using AccountingModel.AccountingTypes;

namespace AccountingView
{
    public partial class WorkerControl : UserControl
    {
        private Worker _newWorker = null;

        public Worker NewWorker
        {
            get
            {
                try
                {
                    if (HourlySalaryRadioButton.Checked)
                    {
                        _newWorker = new HourlyWorker(FirstnameTextBox.Text,
                            SurnameTextBox.Text, Convert.ToDouble(HourPriceTextBox.Text),
                            Convert.ToDouble(HoursWorkedTextBox.Text));
                    }
                    if (MonthlyWageRadioButton.Checked == true)
                    {
                        _newWorker = new MonthlyWorker(FirstnameTextBox.Text,
                            SurnameTextBox.Text, Convert.ToDouble(RewardTextBox.Text),
                            Convert.ToDouble(RateTextBox.Text),
                            Convert.ToDouble(BountyTextBox.Text));
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
                return _newWorker;
            }

            set
            {
                _newWorker = value;
                FirstnameTextBox.Text = _newWorker.Firstname;
                SurnameTextBox.Text = _newWorker.Surname;
            }
        }

        public WorkerControl()
        {
            InitializeComponent();
            HourPriceTextBox.KeyPress += new KeyPressEventHandler(IsNumberOrDotPressed);
            RewardTextBox.KeyPress += new KeyPressEventHandler(IsNumberOrDotPressed);
            RateTextBox.KeyPress += new KeyPressEventHandler(IsNumberOrDotPressed);
            BountyTextBox.KeyPress += new KeyPressEventHandler(IsNumberOrDotPressed);
            FirstnameTextBox.KeyPress += new KeyPressEventHandler(IsString);
            SurnameTextBox.KeyPress += new KeyPressEventHandler(IsString);
            HoursWorkedTextBox.KeyPress += new KeyPressEventHandler(IsNumber);
        }

        private void SalaryControl_Load(object sender, EventArgs e)
        {
            HourlyWorkerGroupBox.Enabled = false;
            MonthlyWorkerGroupBox.Enabled = false;
            BountyTextBox.Enabled = false;
            BountyTextBox.Text = "0";
        }

        private void IsNumberOrDotPressed(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsControl(e.KeyChar))
                && !(Char.IsDigit(e.KeyChar))
                && !((e.KeyChar == '.')
                && (((TextBox)sender).Text.IndexOf(".") == -1)
                && (((TextBox)sender).Text.IndexOf(",") == -1))
                && !((e.KeyChar == ',')
                && (((TextBox)sender).Text.IndexOf(",") == -1)
                && (((TextBox)sender).Text.IndexOf(".") == -1))
                )
            {
                e.Handled = true;
            }
        }

        private void IsNumber(object sender, KeyPressEventArgs n)
        {
            if (!(Char.IsControl(n.KeyChar))
                && !(Char.IsDigit(n.KeyChar))
                )
            {
                n.Handled = true;
            }
        }

        private void IsString(object sender, KeyPressEventArgs s)
        {
            if (!(Char.IsControl(s.KeyChar))
                && !(Char.IsLetter(s.KeyChar))
                && !((s.KeyChar == '-')
                && (((TextBox)sender).Text.IndexOf("-") == -1))
                )
            {
                s.Handled = true;
            }
        }

        private void HourlySalaryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            HourlyWorkerGroupBox.Enabled = true;
            MonthlyWorkerGroupBox.Enabled = false;
        }

        private void MonthlySalaryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MonthlyWorkerGroupBox.Enabled = true;
            HourlyWorkerGroupBox.Enabled = false;
        }

        private void BountyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (BountyCheckBox.Checked)
            {
                BountyTextBox.Enabled = true;
            }
            else
            {
                BountyTextBox.Enabled = false;
                BountyTextBox.Text = "0";
            }
        }
    }
}
