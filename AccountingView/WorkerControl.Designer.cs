﻿namespace AccountingView
{
    partial class WorkerControl
    {
        /// <summary> 
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.FirstnameLabel = new System.Windows.Forms.Label();
            this.SurnameLabel = new System.Windows.Forms.Label();
            this.FirstnameTextBox = new System.Windows.Forms.TextBox();
            this.SurnameTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MonthlyWageRadioButton = new System.Windows.Forms.RadioButton();
            this.HourlySalaryRadioButton = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.HourlyWorkerGroupBox = new System.Windows.Forms.GroupBox();
            this.HourPriceLabel = new System.Windows.Forms.Label();
            this.HourPriceTextBox = new System.Windows.Forms.TextBox();
            this.HoursWorkedLabel = new System.Windows.Forms.Label();
            this.HoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.MonthlyWorkerGroupBox = new System.Windows.Forms.GroupBox();
            this.RewardLabel = new System.Windows.Forms.Label();
            this.RateLabel = new System.Windows.Forms.Label();
            this.BountyTextBox = new System.Windows.Forms.TextBox();
            this.BountyCheckBox = new System.Windows.Forms.CheckBox();
            this.RateTextBox = new System.Windows.Forms.TextBox();
            this.RewardTextBox = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.HourlyWorkerGroupBox.SuspendLayout();
            this.MonthlyWorkerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(495, 370);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.FirstnameLabel);
            this.groupBox2.Controls.Add(this.SurnameLabel);
            this.groupBox2.Controls.Add(this.FirstnameTextBox);
            this.groupBox2.Controls.Add(this.SurnameTextBox);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.MinimumSize = new System.Drawing.Size(0, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 49);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Worker";
            // 
            // FirstnameLabel
            // 
            this.FirstnameLabel.AutoSize = true;
            this.FirstnameLabel.Location = new System.Drawing.Point(6, 21);
            this.FirstnameLabel.Name = "FirstnameLabel";
            this.FirstnameLabel.Size = new System.Drawing.Size(52, 13);
            this.FirstnameLabel.TabIndex = 0;
            this.FirstnameLabel.Text = "Firstname";
            // 
            // SurnameLabel
            // 
            this.SurnameLabel.AutoSize = true;
            this.SurnameLabel.Location = new System.Drawing.Point(188, 19);
            this.SurnameLabel.Name = "SurnameLabel";
            this.SurnameLabel.Size = new System.Drawing.Size(49, 13);
            this.SurnameLabel.TabIndex = 1;
            this.SurnameLabel.Text = "Surname";
            // 
            // FirstnameTextBox
            // 
            this.FirstnameTextBox.Location = new System.Drawing.Point(64, 16);
            this.FirstnameTextBox.Name = "FirstnameTextBox";
            this.FirstnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstnameTextBox.TabIndex = 2;
            // 
            // SurnameTextBox
            // 
            this.SurnameTextBox.Location = new System.Drawing.Point(243, 16);
            this.SurnameTextBox.Name = "SurnameTextBox";
            this.SurnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.SurnameTextBox.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MonthlyWageRadioButton);
            this.groupBox1.Controls.Add(this.HourlySalaryRadioButton);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 58);
            this.groupBox1.MinimumSize = new System.Drawing.Size(0, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salary type";
            // 
            // MonthlyWageRadioButton
            // 
            this.MonthlyWageRadioButton.AutoSize = true;
            this.MonthlyWageRadioButton.Location = new System.Drawing.Point(99, 19);
            this.MonthlyWageRadioButton.Name = "MonthlyWageRadioButton";
            this.MonthlyWageRadioButton.Size = new System.Drawing.Size(62, 17);
            this.MonthlyWageRadioButton.TabIndex = 5;
            this.MonthlyWageRadioButton.TabStop = true;
            this.MonthlyWageRadioButton.Text = "Monthly";
            this.MonthlyWageRadioButton.UseVisualStyleBackColor = true;
            this.MonthlyWageRadioButton.CheckedChanged += new System.EventHandler(this.MonthlySalaryRadioButton_CheckedChanged);
            // 
            // HourlySalaryRadioButton
            // 
            this.HourlySalaryRadioButton.AutoSize = true;
            this.HourlySalaryRadioButton.Location = new System.Drawing.Point(9, 19);
            this.HourlySalaryRadioButton.Name = "HourlySalaryRadioButton";
            this.HourlySalaryRadioButton.Size = new System.Drawing.Size(55, 17);
            this.HourlySalaryRadioButton.TabIndex = 4;
            this.HourlySalaryRadioButton.TabStop = true;
            this.HourlySalaryRadioButton.Text = "Hourly";
            this.HourlySalaryRadioButton.UseVisualStyleBackColor = true;
            this.HourlySalaryRadioButton.CheckedChanged += new System.EventHandler(this.HourlySalaryRadioButton_CheckedChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.HourlyWorkerGroupBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.MonthlyWorkerGroupBox, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 113);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(489, 254);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // HourlyWorkerGroupBox
            // 
            this.HourlyWorkerGroupBox.Controls.Add(this.HourPriceLabel);
            this.HourlyWorkerGroupBox.Controls.Add(this.HourPriceTextBox);
            this.HourlyWorkerGroupBox.Controls.Add(this.HoursWorkedLabel);
            this.HourlyWorkerGroupBox.Controls.Add(this.HoursWorkedTextBox);
            this.HourlyWorkerGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.HourlyWorkerGroupBox.Location = new System.Drawing.Point(3, 3);
            this.HourlyWorkerGroupBox.MinimumSize = new System.Drawing.Size(0, 70);
            this.HourlyWorkerGroupBox.Name = "HourlyWorkerGroupBox";
            this.HourlyWorkerGroupBox.Size = new System.Drawing.Size(238, 100);
            this.HourlyWorkerGroupBox.TabIndex = 0;
            this.HourlyWorkerGroupBox.TabStop = false;
            this.HourlyWorkerGroupBox.Text = "Hourly Worker";
            // 
            // HourPriceLabel
            // 
            this.HourPriceLabel.AutoSize = true;
            this.HourPriceLabel.Location = new System.Drawing.Point(6, 19);
            this.HourPriceLabel.Name = "HourPriceLabel";
            this.HourPriceLabel.Size = new System.Drawing.Size(73, 13);
            this.HourPriceLabel.TabIndex = 6;
            this.HourPriceLabel.Text = "Price per hour";
            // 
            // HourPriceTextBox
            // 
            this.HourPriceTextBox.Location = new System.Drawing.Point(91, 16);
            this.HourPriceTextBox.Name = "HourPriceTextBox";
            this.HourPriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.HourPriceTextBox.TabIndex = 6;
            // 
            // HoursWorkedLabel
            // 
            this.HoursWorkedLabel.AutoSize = true;
            this.HoursWorkedLabel.Location = new System.Drawing.Point(6, 45);
            this.HoursWorkedLabel.Name = "HoursWorkedLabel";
            this.HoursWorkedLabel.Size = new System.Drawing.Size(73, 13);
            this.HoursWorkedLabel.TabIndex = 7;
            this.HoursWorkedLabel.Text = "Hours worked";
            // 
            // HoursWorkedTextBox
            // 
            this.HoursWorkedTextBox.Location = new System.Drawing.Point(91, 42);
            this.HoursWorkedTextBox.Name = "HoursWorkedTextBox";
            this.HoursWorkedTextBox.Size = new System.Drawing.Size(100, 20);
            this.HoursWorkedTextBox.TabIndex = 7;
            // 
            // MonthlyWorkerGroupBox
            // 
            this.MonthlyWorkerGroupBox.Controls.Add(this.RewardLabel);
            this.MonthlyWorkerGroupBox.Controls.Add(this.RateLabel);
            this.MonthlyWorkerGroupBox.Controls.Add(this.BountyTextBox);
            this.MonthlyWorkerGroupBox.Controls.Add(this.BountyCheckBox);
            this.MonthlyWorkerGroupBox.Controls.Add(this.RateTextBox);
            this.MonthlyWorkerGroupBox.Controls.Add(this.RewardTextBox);
            this.MonthlyWorkerGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.MonthlyWorkerGroupBox.Location = new System.Drawing.Point(247, 3);
            this.MonthlyWorkerGroupBox.Name = "MonthlyWorkerGroupBox";
            this.MonthlyWorkerGroupBox.Size = new System.Drawing.Size(239, 100);
            this.MonthlyWorkerGroupBox.TabIndex = 0;
            this.MonthlyWorkerGroupBox.TabStop = false;
            this.MonthlyWorkerGroupBox.Text = "Monthly Worker";
            // 
            // RewardLabel
            // 
            this.RewardLabel.AutoSize = true;
            this.RewardLabel.Location = new System.Drawing.Point(6, 22);
            this.RewardLabel.Name = "RewardLabel";
            this.RewardLabel.Size = new System.Drawing.Size(44, 13);
            this.RewardLabel.TabIndex = 8;
            this.RewardLabel.Text = "Reward";
            // 
            // RateLabel
            // 
            this.RateLabel.AutoSize = true;
            this.RateLabel.Location = new System.Drawing.Point(6, 48);
            this.RateLabel.Name = "RateLabel";
            this.RateLabel.Size = new System.Drawing.Size(30, 13);
            this.RateLabel.TabIndex = 9;
            this.RateLabel.Text = "Rate";
            // 
            // BountyTextBox
            // 
            this.BountyTextBox.Location = new System.Drawing.Point(98, 71);
            this.BountyTextBox.Name = "BountyTextBox";
            this.BountyTextBox.Size = new System.Drawing.Size(100, 20);
            this.BountyTextBox.TabIndex = 11;
            // 
            // BountyCheckBox
            // 
            this.BountyCheckBox.AutoSize = true;
            this.BountyCheckBox.Location = new System.Drawing.Point(6, 73);
            this.BountyCheckBox.Name = "BountyCheckBox";
            this.BountyCheckBox.Size = new System.Drawing.Size(59, 17);
            this.BountyCheckBox.TabIndex = 10;
            this.BountyCheckBox.Text = "Bounty";
            this.BountyCheckBox.UseVisualStyleBackColor = true;
            this.BountyCheckBox.CheckedChanged += new System.EventHandler(this.BountyCheckBox_CheckedChanged);
            // 
            // RateTextBox
            // 
            this.RateTextBox.Location = new System.Drawing.Point(98, 45);
            this.RateTextBox.Name = "RateTextBox";
            this.RateTextBox.Size = new System.Drawing.Size(100, 20);
            this.RateTextBox.TabIndex = 9;
            // 
            // RewardTextBox
            // 
            this.RewardTextBox.Location = new System.Drawing.Point(98, 19);
            this.RewardTextBox.Name = "RewardTextBox";
            this.RewardTextBox.Size = new System.Drawing.Size(100, 20);
            this.RewardTextBox.TabIndex = 8;
            // 
            // WorkerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.Name = "WorkerControl";
            this.Size = new System.Drawing.Size(495, 370);
            this.Load += new System.EventHandler(this.SalaryControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.HourlyWorkerGroupBox.ResumeLayout(false);
            this.HourlyWorkerGroupBox.PerformLayout();
            this.MonthlyWorkerGroupBox.ResumeLayout(false);
            this.MonthlyWorkerGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label FirstnameLabel;
        private System.Windows.Forms.Label SurnameLabel;
        private System.Windows.Forms.TextBox FirstnameTextBox;
        private System.Windows.Forms.TextBox SurnameTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton MonthlyWageRadioButton;
        private System.Windows.Forms.RadioButton HourlySalaryRadioButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox HourlyWorkerGroupBox;
        private System.Windows.Forms.Label HourPriceLabel;
        private System.Windows.Forms.TextBox HourPriceTextBox;
        private System.Windows.Forms.Label HoursWorkedLabel;
        private System.Windows.Forms.TextBox HoursWorkedTextBox;
        private System.Windows.Forms.GroupBox MonthlyWorkerGroupBox;
        private System.Windows.Forms.Label RewardLabel;
        private System.Windows.Forms.Label RateLabel;
        private System.Windows.Forms.TextBox BountyTextBox;
        private System.Windows.Forms.CheckBox BountyCheckBox;
        private System.Windows.Forms.TextBox RateTextBox;
        private System.Windows.Forms.TextBox RewardTextBox;

    }
}
