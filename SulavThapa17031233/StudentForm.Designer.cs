namespace SulavThapa17031233
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.studentProgramme = new System.Windows.Forms.ComboBox();
            this.studentBirthDate = new System.Windows.Forms.DateTimePicker();
            this.studentContactNo = new System.Windows.Forms.TextBox();
            this.studentGender = new System.Windows.Forms.ComboBox();
            this.fName = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.sAddress = new System.Windows.Forms.Label();
            this.sEmail = new System.Windows.Forms.Label();
            this.sProgramme = new System.Windows.Forms.Label();
            this.sDOB = new System.Windows.Forms.Label();
            this.sContact = new System.Windows.Forms.Label();
            this.sGender = new System.Windows.Forms.Label();
            this.studentDataTable = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.studentDataTableLabel = new System.Windows.Forms.Label();
            this.sRegistrationDate = new System.Windows.Forms.Label();
            this.registrationDate = new System.Windows.Forms.DateTimePicker();
            this.studentReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Chartlabel = new System.Windows.Forms.Label();
            this.heading = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.studentWeeklyReport = new System.Windows.Forms.DataGridView();
            this.lblReport = new System.Windows.Forms.Label();
            this.lblsort = new System.Windows.Forms.Label();
            this.sortDataTable = new System.Windows.Forms.ComboBox();
            this.weeklyReportDatePicker = new System.Windows.Forms.DateTimePicker();
            this.lbldatepicker = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentWeeklyReport)).BeginInit();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(117, 84);
            this.firstName.Margin = new System.Windows.Forms.Padding(2);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(76, 20);
            this.firstName.TabIndex = 2;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(354, 84);
            this.lastName.Margin = new System.Windows.Forms.Padding(2);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(76, 20);
            this.lastName.TabIndex = 3;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(117, 135);
            this.address.Margin = new System.Windows.Forms.Padding(2);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(76, 20);
            this.address.TabIndex = 4;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(354, 134);
            this.email.Margin = new System.Windows.Forms.Padding(2);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(76, 20);
            this.email.TabIndex = 5;
            // 
            // studentProgramme
            // 
            this.studentProgramme.FormattingEnabled = true;
            this.studentProgramme.Items.AddRange(new object[] {
            "Computing",
            "Multimedia",
            "Networking"});
            this.studentProgramme.Location = new System.Drawing.Point(117, 188);
            this.studentProgramme.Margin = new System.Windows.Forms.Padding(2);
            this.studentProgramme.Name = "studentProgramme";
            this.studentProgramme.Size = new System.Drawing.Size(92, 21);
            this.studentProgramme.TabIndex = 6;
            this.studentProgramme.Text = "Computing";
            // 
            // studentBirthDate
            // 
            this.studentBirthDate.Location = new System.Drawing.Point(354, 188);
            this.studentBirthDate.Margin = new System.Windows.Forms.Padding(2);
            this.studentBirthDate.Name = "studentBirthDate";
            this.studentBirthDate.Size = new System.Drawing.Size(151, 20);
            this.studentBirthDate.TabIndex = 7;
            // 
            // studentContactNo
            // 
            this.studentContactNo.Location = new System.Drawing.Point(117, 233);
            this.studentContactNo.Margin = new System.Windows.Forms.Padding(2);
            this.studentContactNo.Name = "studentContactNo";
            this.studentContactNo.Size = new System.Drawing.Size(76, 20);
            this.studentContactNo.TabIndex = 8;
            // 
            // studentGender
            // 
            this.studentGender.FormattingEnabled = true;
            this.studentGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.studentGender.Location = new System.Drawing.Point(354, 233);
            this.studentGender.Margin = new System.Windows.Forms.Padding(2);
            this.studentGender.Name = "studentGender";
            this.studentGender.Size = new System.Drawing.Size(92, 21);
            this.studentGender.TabIndex = 9;
            this.studentGender.Text = "Male";
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Location = new System.Drawing.Point(56, 86);
            this.fName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(57, 13);
            this.fName.TabIndex = 10;
            this.fName.Text = "First Name";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(292, 84);
            this.lName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(58, 13);
            this.lName.TabIndex = 11;
            this.lName.Text = "Last Name";
            // 
            // sAddress
            // 
            this.sAddress.AutoSize = true;
            this.sAddress.Location = new System.Drawing.Point(63, 138);
            this.sAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sAddress.Name = "sAddress";
            this.sAddress.Size = new System.Drawing.Size(45, 13);
            this.sAddress.TabIndex = 12;
            this.sAddress.Text = "Address";
            // 
            // sEmail
            // 
            this.sEmail.AutoSize = true;
            this.sEmail.Location = new System.Drawing.Point(310, 138);
            this.sEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sEmail.Name = "sEmail";
            this.sEmail.Size = new System.Drawing.Size(32, 13);
            this.sEmail.TabIndex = 13;
            this.sEmail.Text = "Email";
            // 
            // sProgramme
            // 
            this.sProgramme.AutoSize = true;
            this.sProgramme.Location = new System.Drawing.Point(52, 190);
            this.sProgramme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sProgramme.Name = "sProgramme";
            this.sProgramme.Size = new System.Drawing.Size(60, 13);
            this.sProgramme.TabIndex = 14;
            this.sProgramme.Text = "Programme";
            // 
            // sDOB
            // 
            this.sDOB.AutoSize = true;
            this.sDOB.Location = new System.Drawing.Point(284, 190);
            this.sDOB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sDOB.Name = "sDOB";
            this.sDOB.Size = new System.Drawing.Size(66, 13);
            this.sDOB.TabIndex = 15;
            this.sDOB.Text = "Date of Birth";
            // 
            // sContact
            // 
            this.sContact.AutoSize = true;
            this.sContact.Location = new System.Drawing.Point(51, 237);
            this.sContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sContact.Name = "sContact";
            this.sContact.Size = new System.Drawing.Size(64, 13);
            this.sContact.TabIndex = 16;
            this.sContact.Text = "Contact No.";
            // 
            // sGender
            // 
            this.sGender.AutoSize = true;
            this.sGender.Location = new System.Drawing.Point(308, 237);
            this.sGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sGender.Name = "sGender";
            this.sGender.Size = new System.Drawing.Size(42, 13);
            this.sGender.TabIndex = 17;
            this.sGender.Text = "Gender";
            // 
            // studentDataTable
            // 
            this.studentDataTable.AllowUserToResizeColumns = false;
            this.studentDataTable.AllowUserToResizeRows = false;
            this.studentDataTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.studentDataTable.ColumnHeadersHeight = 29;
            this.studentDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.studentDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.studentDataTable.Location = new System.Drawing.Point(9, 332);
            this.studentDataTable.Margin = new System.Windows.Forms.Padding(2);
            this.studentDataTable.Name = "studentDataTable";
            this.studentDataTable.ReadOnly = true;
            this.studentDataTable.RowHeadersWidth = 51;
            this.studentDataTable.RowTemplate.Height = 24;
            this.studentDataTable.Size = new System.Drawing.Size(692, 310);
            this.studentDataTable.TabIndex = 18;
            this.studentDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDataTable_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 50;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 60;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(285, 276);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(56, 27);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(361, 276);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(56, 27);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(440, 279);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(56, 24);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // studentDataTableLabel
            // 
            this.studentDataTableLabel.AutoSize = true;
            this.studentDataTableLabel.Location = new System.Drawing.Point(14, 316);
            this.studentDataTableLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentDataTableLabel.Name = "studentDataTableLabel";
            this.studentDataTableLabel.Size = new System.Drawing.Size(100, 13);
            this.studentDataTableLabel.TabIndex = 22;
            this.studentDataTableLabel.Text = "Student Data Table";
            // 
            // sRegistrationDate
            // 
            this.sRegistrationDate.AutoSize = true;
            this.sRegistrationDate.Location = new System.Drawing.Point(24, 279);
            this.sRegistrationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sRegistrationDate.Name = "sRegistrationDate";
            this.sRegistrationDate.Size = new System.Drawing.Size(89, 13);
            this.sRegistrationDate.TabIndex = 23;
            this.sRegistrationDate.Text = "Registration Date";
            // 
            // registrationDate
            // 
            this.registrationDate.Location = new System.Drawing.Point(118, 274);
            this.registrationDate.Margin = new System.Windows.Forms.Padding(2);
            this.registrationDate.Name = "registrationDate";
            this.registrationDate.Size = new System.Drawing.Size(151, 20);
            this.registrationDate.TabIndex = 24;
            // 
            // studentReport
            // 
            chartArea1.Name = "ChartArea1";
            this.studentReport.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.studentReport.Legends.Add(legend1);
            this.studentReport.Location = new System.Drawing.Point(542, 17);
            this.studentReport.Margin = new System.Windows.Forms.Padding(2);
            this.studentReport.Name = "studentReport";
            this.studentReport.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.studentReport.Series.Add(series1);
            this.studentReport.Size = new System.Drawing.Size(459, 297);
            this.studentReport.TabIndex = 25;
            this.studentReport.Text = "Student Report";
            // 
            // Chartlabel
            // 
            this.Chartlabel.AutoSize = true;
            this.Chartlabel.Location = new System.Drawing.Point(538, 1);
            this.Chartlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Chartlabel.Name = "Chartlabel";
            this.Chartlabel.Size = new System.Drawing.Size(79, 13);
            this.Chartlabel.TabIndex = 26;
            this.Chartlabel.Text = "Student Report";
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.Location = new System.Drawing.Point(126, 24);
            this.heading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(267, 32);
            this.heading.TabIndex = 27;
            this.heading.Text = "Student Detail Form";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(402, 37);
            this.txtId.Margin = new System.Windows.Forms.Padding(2);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(76, 20);
            this.txtId.TabIndex = 28;
            this.txtId.Visible = false;
            // 
            // studentWeeklyReport
            // 
            this.studentWeeklyReport.AllowUserToResizeColumns = false;
            this.studentWeeklyReport.AllowUserToResizeRows = false;
            this.studentWeeklyReport.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.studentWeeklyReport.ColumnHeadersHeight = 29;
            this.studentWeeklyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.studentWeeklyReport.Location = new System.Drawing.Point(705, 393);
            this.studentWeeklyReport.Margin = new System.Windows.Forms.Padding(2);
            this.studentWeeklyReport.Name = "studentWeeklyReport";
            this.studentWeeklyReport.ReadOnly = true;
            this.studentWeeklyReport.RowHeadersWidth = 51;
            this.studentWeeklyReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.studentWeeklyReport.RowTemplate.Height = 24;
            this.studentWeeklyReport.Size = new System.Drawing.Size(296, 249);
            this.studentWeeklyReport.TabIndex = 29;
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Location = new System.Drawing.Point(703, 378);
            this.lblReport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(118, 13);
            this.lblReport.TabIndex = 30;
            this.lblReport.Text = "Student Weekly Report";
            // 
            // lblsort
            // 
            this.lblsort.AutoSize = true;
            this.lblsort.Location = new System.Drawing.Point(148, 313);
            this.lblsort.Name = "lblsort";
            this.lblsort.Size = new System.Drawing.Size(44, 13);
            this.lblsort.TabIndex = 31;
            this.lblsort.Text = "Sort By:";
            // 
            // sortDataTable
            // 
            this.sortDataTable.DisplayMember = "none";
            this.sortDataTable.FormattingEnabled = true;
            this.sortDataTable.Items.AddRange(new object[] {
            "RegistrationDate (Ascending)",
            "RegistrationDate (Descending)",
            "Name(Ascending)",
            "Name(Descending)"});
            this.sortDataTable.Location = new System.Drawing.Point(198, 309);
            this.sortDataTable.Name = "sortDataTable";
            this.sortDataTable.Size = new System.Drawing.Size(152, 21);
            this.sortDataTable.TabIndex = 32;
            this.sortDataTable.Text = "Choose to sort";
            this.sortDataTable.SelectedIndexChanged += new System.EventHandler(this.sortDataTable_SelectedIndexChanged);
            // 
            // weeklyReportDatePicker
            // 
            this.weeklyReportDatePicker.Location = new System.Drawing.Point(708, 351);
            this.weeklyReportDatePicker.Name = "weeklyReportDatePicker";
            this.weeklyReportDatePicker.Size = new System.Drawing.Size(200, 20);
            this.weeklyReportDatePicker.TabIndex = 33;
            this.weeklyReportDatePicker.ValueChanged += new System.EventHandler(this.weeklyReportDatePicker_ValueChanged);
            // 
            // lbldatepicker
            // 
            this.lbldatepicker.AutoSize = true;
            this.lbldatepicker.Location = new System.Drawing.Point(704, 332);
            this.lbldatepicker.Name = "lbldatepicker";
            this.lbldatepicker.Size = new System.Drawing.Size(89, 13);
            this.lbldatepicker.TabIndex = 34;
            this.lbldatepicker.Text = "Date Time Picker";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 652);
            this.Controls.Add(this.lbldatepicker);
            this.Controls.Add(this.weeklyReportDatePicker);
            this.Controls.Add(this.sortDataTable);
            this.Controls.Add(this.lblsort);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.studentWeeklyReport);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.heading);
            this.Controls.Add(this.Chartlabel);
            this.Controls.Add(this.studentReport);
            this.Controls.Add(this.registrationDate);
            this.Controls.Add(this.sRegistrationDate);
            this.Controls.Add(this.studentDataTableLabel);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.studentDataTable);
            this.Controls.Add(this.sGender);
            this.Controls.Add(this.sContact);
            this.Controls.Add(this.sDOB);
            this.Controls.Add(this.sProgramme);
            this.Controls.Add(this.sEmail);
            this.Controls.Add(this.sAddress);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.studentGender);
            this.Controls.Add(this.studentContactNo);
            this.Controls.Add(this.studentBirthDate);
            this.Controls.Add(this.studentProgramme);
            this.Controls.Add(this.email);
            this.Controls.Add(this.address);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Detail Form";
            ((System.ComponentModel.ISupportInitialize)(this.studentDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentWeeklyReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.ComboBox studentProgramme;
        private System.Windows.Forms.DateTimePicker studentBirthDate;
        private System.Windows.Forms.TextBox studentContactNo;
        private System.Windows.Forms.ComboBox studentGender;
        private System.Windows.Forms.Label fName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label sAddress;
        private System.Windows.Forms.Label sEmail;
        private System.Windows.Forms.Label sProgramme;
        private System.Windows.Forms.Label sDOB;
        private System.Windows.Forms.Label sContact;
        private System.Windows.Forms.Label sGender;
        private System.Windows.Forms.DataGridView studentDataTable;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label studentDataTableLabel;
        private System.Windows.Forms.Label sRegistrationDate;
        private System.Windows.Forms.DateTimePicker registrationDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart studentReport;
        private System.Windows.Forms.Label Chartlabel;
        private System.Windows.Forms.Label heading;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridView studentWeeklyReport;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.Label lblsort;
        private System.Windows.Forms.ComboBox sortDataTable;
        private System.Windows.Forms.DateTimePicker weeklyReportDatePicker;
        private System.Windows.Forms.Label lbldatepicker;
    }
}

