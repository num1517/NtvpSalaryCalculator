namespace AccountingView
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmployeesGroupBox = new System.Windows.Forms.GroupBox();
            this.WorkersGridView = new System.Windows.Forms.DataGridView();
            this.Firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.AddRandomWorker = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EmployeesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WorkersGridView)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeesGroupBox
            // 
            this.EmployeesGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.EmployeesGroupBox.Controls.Add(this.WorkersGridView);
            this.EmployeesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmployeesGroupBox.Location = new System.Drawing.Point(0, 24);
            this.EmployeesGroupBox.Margin = new System.Windows.Forms.Padding(50);
            this.EmployeesGroupBox.Name = "EmployeesGroupBox";
            this.EmployeesGroupBox.Size = new System.Drawing.Size(474, 280);
            this.EmployeesGroupBox.TabIndex = 0;
            this.EmployeesGroupBox.TabStop = false;
            this.EmployeesGroupBox.Text = "Workers";
            // 
            // WorkersGridView
            // 
            this.WorkersGridView.AllowUserToAddRows = false;
            this.WorkersGridView.AllowUserToDeleteRows = false;
            this.WorkersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Firstname,
            this.Surname,
            this.Salary});
            this.WorkersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WorkersGridView.Location = new System.Drawing.Point(3, 16);
            this.WorkersGridView.Name = "WorkersGridView";
            this.WorkersGridView.ReadOnly = true;
            this.WorkersGridView.Size = new System.Drawing.Size(468, 261);
            this.WorkersGridView.TabIndex = 0;
            // 
            // Firstname
            // 
            this.Firstname.HeaderText = "Firstname";
            this.Firstname.Name = "Firstname";
            this.Firstname.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 269);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(474, 35);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel2.Controls.Add(this.AddButton);
            this.flowLayoutPanel2.Controls.Add(this.RemoveButton);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(249, 29);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(110, 25);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add worker";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(119, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(110, 25);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove worker";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.flowLayoutPanel4.Controls.Add(this.AddRandomWorker);
            this.flowLayoutPanel4.Controls.Add(this.EditButton);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(258, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(213, 29);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // AddRandomWorker
            // 
            this.AddRandomWorker.Location = new System.Drawing.Point(110, 3);
            this.AddRandomWorker.Name = "AddRandomWorker";
            this.AddRandomWorker.Size = new System.Drawing.Size(100, 25);
            this.AddRandomWorker.TabIndex = 3;
            this.AddRandomWorker.Text = "Add random";
            this.AddRandomWorker.UseVisualStyleBackColor = true;
            this.AddRandomWorker.Click += new System.EventHandler(this.AddRandomWorker_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(4, 3);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(100, 25);
            this.EditButton.TabIndex = 4;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(474, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.toolStripSeparator1,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(474, 304);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.EmployeesGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Accounting";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.EmployeesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WorkersGridView)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox EmployeesGroupBox;
        private System.Windows.Forms.DataGridView WorkersGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button AddRandomWorker;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.Button EditButton;
    }
}

