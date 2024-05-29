namespace EmployeeAttendanceSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Write_LoadDatabtn = new Button();
            Write_Savebtn = new Button();
            Write_DeleteLastbtn = new Button();
            Write_ClearAllbtn = new Button();
            Write_Datelbl = new Label();
            Write_Namelbl = new Label();
            Write_Posadalbl = new Label();
            Write_Arrivelbl = new Label();
            Write_Leavelbl = new Label();
            Write_Nametxb = new TextBox();
            Write_Posadatxb = new TextBox();
            Write_dateTimePicker = new DateTimePicker();
            Write_ArriveTimePicker = new DateTimePicker();
            Write_LeaveTimePicker = new DateTimePicker();
            tabControl1 = new TabControl();
            WritePage = new TabPage();
            Write_dataGridView = new DataGridView();
            PIB = new DataGridViewTextBoxColumn();
            Posada = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Arrival = new DataGridViewTextBoxColumn();
            Leave = new DataGridViewTextBoxColumn();
            SearchPage = new TabPage();
            Search_Sortchb = new CheckBox();
            Search_ToTimePicker = new DateTimePicker();
            Search_FromTimePicker = new DateTimePicker();
            Search_dataGridView = new DataGridView();
            Search_Exportbtn = new Button();
            Search_Savebtn = new Button();
            Searchbtn = new Button();
            Search_resultlbl = new Label();
            Search_Amountlbl = new Label();
            Search_TodateTimePicker = new DateTimePicker();
            Search_FromdateTimePicker = new DateTimePicker();
            Search_byTimechb = new CheckBox();
            Search_byDatechb = new CheckBox();
            tabControl1.SuspendLayout();
            WritePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Write_dataGridView).BeginInit();
            SearchPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Search_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // Write_LoadDatabtn
            // 
            Write_LoadDatabtn.Location = new Point(78, 316);
            Write_LoadDatabtn.Name = "Write_LoadDatabtn";
            Write_LoadDatabtn.Size = new Size(201, 34);
            Write_LoadDatabtn.TabIndex = 1;
            Write_LoadDatabtn.Text = "Load data";
            Write_LoadDatabtn.UseVisualStyleBackColor = true;
            Write_LoadDatabtn.Click += Write_LoadDatabtn_Click;
            // 
            // Write_Savebtn
            // 
            Write_Savebtn.Location = new Point(78, 356);
            Write_Savebtn.Name = "Write_Savebtn";
            Write_Savebtn.Size = new Size(201, 34);
            Write_Savebtn.TabIndex = 2;
            Write_Savebtn.Text = "Save";
            Write_Savebtn.UseVisualStyleBackColor = true;
            Write_Savebtn.Click += Write_Savebtn_Click;
            // 
            // Write_DeleteLastbtn
            // 
            Write_DeleteLastbtn.Location = new Point(78, 396);
            Write_DeleteLastbtn.Name = "Write_DeleteLastbtn";
            Write_DeleteLastbtn.Size = new Size(201, 34);
            Write_DeleteLastbtn.TabIndex = 3;
            Write_DeleteLastbtn.Text = "Delete last";
            Write_DeleteLastbtn.UseVisualStyleBackColor = true;
            Write_DeleteLastbtn.Click += Write_DeleteLastbtn_Click;
            // 
            // Write_ClearAllbtn
            // 
            Write_ClearAllbtn.Location = new Point(78, 436);
            Write_ClearAllbtn.Name = "Write_ClearAllbtn";
            Write_ClearAllbtn.Size = new Size(201, 34);
            Write_ClearAllbtn.TabIndex = 4;
            Write_ClearAllbtn.Text = "Clear all";
            Write_ClearAllbtn.UseVisualStyleBackColor = true;
            Write_ClearAllbtn.Click += Write_ClearAllbtn_Click;
            // 
            // Write_Datelbl
            // 
            Write_Datelbl.AutoSize = true;
            Write_Datelbl.Location = new Point(16, 16);
            Write_Datelbl.Name = "Write_Datelbl";
            Write_Datelbl.Size = new Size(41, 20);
            Write_Datelbl.TabIndex = 5;
            Write_Datelbl.Text = "Date";
            // 
            // Write_Namelbl
            // 
            Write_Namelbl.AutoSize = true;
            Write_Namelbl.Location = new Point(16, 74);
            Write_Namelbl.Name = "Write_Namelbl";
            Write_Namelbl.Size = new Size(36, 20);
            Write_Namelbl.TabIndex = 6;
            Write_Namelbl.Text = "ПІБ:";
            // 
            // Write_Posadalbl
            // 
            Write_Posadalbl.AutoSize = true;
            Write_Posadalbl.Location = new Point(16, 119);
            Write_Posadalbl.Name = "Write_Posadalbl";
            Write_Posadalbl.Size = new Size(60, 20);
            Write_Posadalbl.TabIndex = 7;
            Write_Posadalbl.Text = "Посада";
            // 
            // Write_Arrivelbl
            // 
            Write_Arrivelbl.AutoSize = true;
            Write_Arrivelbl.Location = new Point(16, 174);
            Write_Arrivelbl.Name = "Write_Arrivelbl";
            Write_Arrivelbl.Size = new Size(99, 20);
            Write_Arrivelbl.TabIndex = 8;
            Write_Arrivelbl.Text = "Час приходу:";
            // 
            // Write_Leavelbl
            // 
            Write_Leavelbl.AutoSize = true;
            Write_Leavelbl.Location = new Point(16, 243);
            Write_Leavelbl.Name = "Write_Leavelbl";
            Write_Leavelbl.Size = new Size(79, 20);
            Write_Leavelbl.TabIndex = 9;
            Write_Leavelbl.Text = "Час уходу:";
            // 
            // Write_Nametxb
            // 
            Write_Nametxb.Location = new Point(121, 67);
            Write_Nametxb.Name = "Write_Nametxb";
            Write_Nametxb.Size = new Size(177, 27);
            Write_Nametxb.TabIndex = 10;
            // 
            // Write_Posadatxb
            // 
            Write_Posadatxb.Location = new Point(121, 119);
            Write_Posadatxb.Name = "Write_Posadatxb";
            Write_Posadatxb.Size = new Size(177, 27);
            Write_Posadatxb.TabIndex = 11;
            // 
            // Write_dateTimePicker
            // 
            Write_dateTimePicker.Format = DateTimePickerFormat.Short;
            Write_dateTimePicker.Location = new Point(121, 17);
            Write_dateTimePicker.Name = "Write_dateTimePicker";
            Write_dateTimePicker.Size = new Size(177, 27);
            Write_dateTimePicker.TabIndex = 12;
            // 
            // Write_ArriveTimePicker
            // 
            Write_ArriveTimePicker.CustomFormat = "HH:mm";
            Write_ArriveTimePicker.Format = DateTimePickerFormat.Custom;
            Write_ArriveTimePicker.Location = new Point(121, 174);
            Write_ArriveTimePicker.Name = "Write_ArriveTimePicker";
            Write_ArriveTimePicker.ShowUpDown = true;
            Write_ArriveTimePicker.Size = new Size(177, 27);
            Write_ArriveTimePicker.TabIndex = 13;
            // 
            // Write_LeaveTimePicker
            // 
            Write_LeaveTimePicker.CustomFormat = "HH:mm";
            Write_LeaveTimePicker.Format = DateTimePickerFormat.Custom;
            Write_LeaveTimePicker.Location = new Point(121, 236);
            Write_LeaveTimePicker.Name = "Write_LeaveTimePicker";
            Write_LeaveTimePicker.ShowUpDown = true;
            Write_LeaveTimePicker.Size = new Size(177, 27);
            Write_LeaveTimePicker.TabIndex = 14;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(WritePage);
            tabControl1.Controls.Add(SearchPage);
            tabControl1.Location = new Point(12, 20);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1172, 512);
            tabControl1.TabIndex = 15;
            // 
            // WritePage
            // 
            WritePage.Controls.Add(Write_dataGridView);
            WritePage.Controls.Add(Write_ClearAllbtn);
            WritePage.Controls.Add(Write_LeaveTimePicker);
            WritePage.Controls.Add(Write_DeleteLastbtn);
            WritePage.Controls.Add(Write_Datelbl);
            WritePage.Controls.Add(Write_Savebtn);
            WritePage.Controls.Add(Write_ArriveTimePicker);
            WritePage.Controls.Add(Write_LoadDatabtn);
            WritePage.Controls.Add(Write_Namelbl);
            WritePage.Controls.Add(Write_dateTimePicker);
            WritePage.Controls.Add(Write_Posadalbl);
            WritePage.Controls.Add(Write_Posadatxb);
            WritePage.Controls.Add(Write_Arrivelbl);
            WritePage.Controls.Add(Write_Nametxb);
            WritePage.Controls.Add(Write_Leavelbl);
            WritePage.Location = new Point(4, 29);
            WritePage.Name = "WritePage";
            WritePage.Padding = new Padding(3);
            WritePage.Size = new Size(1164, 479);
            WritePage.TabIndex = 0;
            WritePage.Text = "Write";
            WritePage.UseVisualStyleBackColor = true;
            // 
            // Write_dataGridView
            // 
            Write_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Write_dataGridView.Columns.AddRange(new DataGridViewColumn[] { PIB, Posada, Date, Arrival, Leave });
            Write_dataGridView.Location = new Point(508, 17);
            Write_dataGridView.Name = "Write_dataGridView";
            Write_dataGridView.RowHeadersVisible = false;
            Write_dataGridView.RowHeadersWidth = 51;
            Write_dataGridView.Size = new Size(650, 453);
            Write_dataGridView.TabIndex = 15;
            // 
            // PIB
            // 
            PIB.HeaderText = "PIB";
            PIB.MinimumWidth = 6;
            PIB.Name = "PIB";
            PIB.Width = 125;
            // 
            // Posada
            // 
            Posada.HeaderText = "Posada";
            Posada.MinimumWidth = 6;
            Posada.Name = "Posada";
            Posada.Width = 125;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.MinimumWidth = 6;
            Date.Name = "Date";
            Date.Width = 125;
            // 
            // Arrival
            // 
            Arrival.HeaderText = "Arrival";
            Arrival.MinimumWidth = 6;
            Arrival.Name = "Arrival";
            Arrival.Width = 125;
            // 
            // Leave
            // 
            Leave.HeaderText = "Leave";
            Leave.MinimumWidth = 6;
            Leave.Name = "Leave";
            Leave.Width = 125;
            // 
            // SearchPage
            // 
            SearchPage.Controls.Add(Search_Sortchb);
            SearchPage.Controls.Add(Search_ToTimePicker);
            SearchPage.Controls.Add(Search_FromTimePicker);
            SearchPage.Controls.Add(Search_dataGridView);
            SearchPage.Controls.Add(Search_Exportbtn);
            SearchPage.Controls.Add(Search_Savebtn);
            SearchPage.Controls.Add(Searchbtn);
            SearchPage.Controls.Add(Search_resultlbl);
            SearchPage.Controls.Add(Search_Amountlbl);
            SearchPage.Controls.Add(Search_TodateTimePicker);
            SearchPage.Controls.Add(Search_FromdateTimePicker);
            SearchPage.Controls.Add(Search_byTimechb);
            SearchPage.Controls.Add(Search_byDatechb);
            SearchPage.Location = new Point(4, 29);
            SearchPage.Name = "SearchPage";
            SearchPage.Padding = new Padding(3);
            SearchPage.Size = new Size(1164, 479);
            SearchPage.TabIndex = 1;
            SearchPage.Text = "Search";
            SearchPage.UseVisualStyleBackColor = true;
            // 
            // Search_Sortchb
            // 
            Search_Sortchb.AutoSize = true;
            Search_Sortchb.Location = new Point(19, 19);
            Search_Sortchb.Name = "Search_Sortchb";
            Search_Sortchb.Size = new Size(171, 24);
            Search_Sortchb.TabIndex = 16;
            Search_Sortchb.Text = "All employees sorted";
            Search_Sortchb.UseVisualStyleBackColor = true;
            Search_Sortchb.CheckStateChanged += Search_Sortchb_CheckStateChanged;
            // 
            // Search_ToTimePicker
            // 
            Search_ToTimePicker.CustomFormat = "HH:mm";
            Search_ToTimePicker.Enabled = false;
            Search_ToTimePicker.Format = DateTimePickerFormat.Custom;
            Search_ToTimePicker.Location = new Point(196, 178);
            Search_ToTimePicker.Name = "Search_ToTimePicker";
            Search_ToTimePicker.ShowUpDown = true;
            Search_ToTimePicker.Size = new Size(120, 27);
            Search_ToTimePicker.TabIndex = 15;
            Search_ToTimePicker.Value = new DateTime(2024, 5, 2, 0, 0, 0, 0);
            // 
            // Search_FromTimePicker
            // 
            Search_FromTimePicker.CustomFormat = "HH:mm";
            Search_FromTimePicker.Enabled = false;
            Search_FromTimePicker.Format = DateTimePickerFormat.Custom;
            Search_FromTimePicker.Location = new Point(196, 132);
            Search_FromTimePicker.Name = "Search_FromTimePicker";
            Search_FromTimePicker.ShowUpDown = true;
            Search_FromTimePicker.Size = new Size(120, 27);
            Search_FromTimePicker.TabIndex = 14;
            Search_FromTimePicker.Value = new DateTime(2024, 5, 2, 0, 0, 0, 0);
            // 
            // Search_dataGridView
            // 
            Search_dataGridView.AllowUserToAddRows = false;
            Search_dataGridView.AllowUserToDeleteRows = false;
            Search_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Search_dataGridView.Location = new Point(361, 6);
            Search_dataGridView.Name = "Search_dataGridView";
            Search_dataGridView.ReadOnly = true;
            Search_dataGridView.RowHeadersWidth = 51;
            Search_dataGridView.Size = new Size(797, 467);
            Search_dataGridView.TabIndex = 10;
            // 
            // Search_Exportbtn
            // 
            Search_Exportbtn.Location = new Point(89, 367);
            Search_Exportbtn.Name = "Search_Exportbtn";
            Search_Exportbtn.Size = new Size(240, 29);
            Search_Exportbtn.TabIndex = 9;
            Search_Exportbtn.Text = "Export";
            Search_Exportbtn.UseVisualStyleBackColor = true;
            Search_Exportbtn.Click += Search_Exportbtn_Click;
            // 
            // Search_Savebtn
            // 
            Search_Savebtn.Location = new Point(89, 434);
            Search_Savebtn.Name = "Search_Savebtn";
            Search_Savebtn.Size = new Size(240, 30);
            Search_Savebtn.TabIndex = 8;
            Search_Savebtn.Text = "Clear";
            Search_Savebtn.UseVisualStyleBackColor = true;
            Search_Savebtn.Click += Search_Savebtn_Click;
            // 
            // Searchbtn
            // 
            Searchbtn.Location = new Point(89, 402);
            Searchbtn.Name = "Searchbtn";
            Searchbtn.Size = new Size(240, 26);
            Searchbtn.TabIndex = 7;
            Searchbtn.Text = "Search ";
            Searchbtn.UseVisualStyleBackColor = true;
            Searchbtn.Click += Searchbtn_Click;
            // 
            // Search_resultlbl
            // 
            Search_resultlbl.AutoSize = true;
            Search_resultlbl.Location = new Point(90, 323);
            Search_resultlbl.Name = "Search_resultlbl";
            Search_resultlbl.Size = new Size(15, 20);
            Search_resultlbl.TabIndex = 6;
            Search_resultlbl.Text = "_";
            // 
            // Search_Amountlbl
            // 
            Search_Amountlbl.AutoSize = true;
            Search_Amountlbl.Location = new Point(19, 323);
            Search_Amountlbl.Name = "Search_Amountlbl";
            Search_Amountlbl.Size = new Size(65, 20);
            Search_Amountlbl.TabIndex = 5;
            Search_Amountlbl.Text = "Amount:";
            // 
            // Search_TodateTimePicker
            // 
            Search_TodateTimePicker.Enabled = false;
            Search_TodateTimePicker.Format = DateTimePickerFormat.Short;
            Search_TodateTimePicker.Location = new Point(19, 178);
            Search_TodateTimePicker.Name = "Search_TodateTimePicker";
            Search_TodateTimePicker.Size = new Size(129, 27);
            Search_TodateTimePicker.TabIndex = 4;
            // 
            // Search_FromdateTimePicker
            // 
            Search_FromdateTimePicker.Enabled = false;
            Search_FromdateTimePicker.Format = DateTimePickerFormat.Short;
            Search_FromdateTimePicker.Location = new Point(19, 132);
            Search_FromdateTimePicker.Name = "Search_FromdateTimePicker";
            Search_FromdateTimePicker.Size = new Size(129, 27);
            Search_FromdateTimePicker.TabIndex = 3;
            // 
            // Search_byTimechb
            // 
            Search_byTimechb.AutoSize = true;
            Search_byTimechb.Location = new Point(196, 80);
            Search_byTimechb.Name = "Search_byTimechb";
            Search_byTimechb.Size = new Size(81, 24);
            Search_byTimechb.TabIndex = 1;
            Search_byTimechb.Text = "By time";
            Search_byTimechb.UseVisualStyleBackColor = true;
            Search_byTimechb.CheckedChanged += Search_byTimechb_CheckedChanged;
            // 
            // Search_byDatechb
            // 
            Search_byDatechb.AutoSize = true;
            Search_byDatechb.Location = new Point(20, 80);
            Search_byDatechb.Name = "Search_byDatechb";
            Search_byDatechb.Size = new Size(81, 24);
            Search_byDatechb.TabIndex = 0;
            Search_byDatechb.Text = "By date";
            Search_byDatechb.UseVisualStyleBackColor = true;
            Search_byDatechb.CheckedChanged += Search_byDatechb_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 537);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            WritePage.ResumeLayout(false);
            WritePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Write_dataGridView).EndInit();
            SearchPage.ResumeLayout(false);
            SearchPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Search_dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button Write_LoadDatabtn;
        private Button Write_Savebtn;
        private Button Write_DeleteLastbtn;
        private Button Write_ClearAllbtn;
        private Label Write_Datelbl;
        private Label Write_Namelbl;
        private Label Write_Posadalbl;
        private Label Write_Arrivelbl;
        private Label Write_Leavelbl;
        private TextBox Write_Nametxb;
        private TextBox Write_Posadatxb;
        private DateTimePicker Write_dateTimePicker;
        private DateTimePicker Write_ArriveTimePicker;
        private DateTimePicker Write_LeaveTimePicker;
        private TabControl tabControl1;
        private TabPage WritePage;
        private DataGridView Write_dataGridView;
        private TabPage SearchPage;
        private CheckBox Search_byTimechb;
        private CheckBox Search_byDatechb;
        private Button Search_Exportbtn;
        private Button Search_Savebtn;
        private Button Searchbtn;
        private Label Search_resultlbl;
        private Label Search_Amountlbl;
        private DateTimePicker Search_TodateTimePicker;
        private DateTimePicker Search_FromdateTimePicker;
        private DateTimePicker Search_ToTimePicker;
        private DateTimePicker Search_FromTimePicker;
        private DataGridView Search_dataGridView;
        private CheckBox Search_Sortchb;
        private DataGridViewTextBoxColumn PIB;
        private DataGridViewTextBoxColumn Posada;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Arrival;
        private DataGridViewTextBoxColumn Leave;
    }
}
