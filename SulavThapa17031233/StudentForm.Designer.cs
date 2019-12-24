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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.studentDataTableLabel = new System.Windows.Forms.Label();
            this.sRegistrationDate = new System.Windows.Forms.Label();
            this.registrationDate = new System.Windows.Forms.DateTimePicker();
            this.studentReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Chartlabel = new System.Windows.Forms.Label();
            this.heading = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentReport)).BeginInit();
            this.SuspendLayout();
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(156, 103);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(100, 22);
            this.firstName.TabIndex = 2;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(472, 103);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(100, 22);
            this.lastName.TabIndex = 3;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(156, 166);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(100, 22);
            this.address.TabIndex = 4;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(472, 165);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(100, 22);
            this.email.TabIndex = 5;
            // 
            // studentProgramme
            // 
            this.studentProgramme.FormattingEnabled = true;
            this.studentProgramme.Items.AddRange(new object[] {
            "Computing",
            "Multimedia",
            "Networking"});
            this.studentProgramme.Location = new System.Drawing.Point(156, 231);
            this.studentProgramme.Name = "studentProgramme";
            this.studentProgramme.Size = new System.Drawing.Size(121, 24);
            this.studentProgramme.TabIndex = 6;
            this.studentProgramme.Text = "Computing";
            // 
            // studentBirthDate
            // 
            this.studentBirthDate.Location = new System.Drawing.Point(472, 231);
            this.studentBirthDate.Name = "studentBirthDate";
            this.studentBirthDate.Size = new System.Drawing.Size(200, 22);
            this.studentBirthDate.TabIndex = 7;
            // 
            // studentContactNo
            // 
            this.studentContactNo.Location = new System.Drawing.Point(156, 287);
            this.studentContactNo.Name = "studentContactNo";
            this.studentContactNo.Size = new System.Drawing.Size(100, 22);
            this.studentContactNo.TabIndex = 8;
            // 
            // studentGender
            // 
            this.studentGender.FormattingEnabled = true;
            this.studentGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.studentGender.Location = new System.Drawing.Point(472, 287);
            this.studentGender.Name = "studentGender";
            this.studentGender.Size = new System.Drawing.Size(121, 24);
            this.studentGender.TabIndex = 9;
            this.studentGender.Text = "Male";
            // 
            // fName
            // 
            this.fName.AutoSize = true;
            this.fName.Location = new System.Drawing.Point(74, 106);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(76, 17);
            this.fName.TabIndex = 10;
            this.fName.Text = "First Name";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(390, 103);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(76, 17);
            this.lName.TabIndex = 11;
            this.lName.Text = "Last Name";
            // 
            // sAddress
            // 
            this.sAddress.AutoSize = true;
            this.sAddress.Location = new System.Drawing.Point(84, 170);
            this.sAddress.Name = "sAddress";
            this.sAddress.Size = new System.Drawing.Size(60, 17);
            this.sAddress.TabIndex = 12;
            this.sAddress.Text = "Address";
            // 
            // sEmail
            // 
            this.sEmail.AutoSize = true;
            this.sEmail.Location = new System.Drawing.Point(413, 170);
            this.sEmail.Name = "sEmail";
            this.sEmail.Size = new System.Drawing.Size(42, 17);
            this.sEmail.TabIndex = 13;
            this.sEmail.Text = "Email";
            // 
            // sProgramme
            // 
            this.sProgramme.AutoSize = true;
            this.sProgramme.Location = new System.Drawing.Point(69, 234);
            this.sProgramme.Name = "sProgramme";
            this.sProgramme.Size = new System.Drawing.Size(81, 17);
            this.sProgramme.TabIndex = 14;
            this.sProgramme.Text = "Programme";
            // 
            // sDOB
            // 
            this.sDOB.AutoSize = true;
            this.sDOB.Location = new System.Drawing.Point(379, 234);
            this.sDOB.Name = "sDOB";
            this.sDOB.Size = new System.Drawing.Size(87, 17);
            this.sDOB.TabIndex = 15;
            this.sDOB.Text = "Date of Birth";
            // 
            // sContact
            // 
            this.sContact.AutoSize = true;
            this.sContact.Location = new System.Drawing.Point(68, 292);
            this.sContact.Name = "sContact";
            this.sContact.Size = new System.Drawing.Size(82, 17);
            this.sContact.TabIndex = 16;
            this.sContact.Text = "Contact No.";
            // 
            // sGender
            // 
            this.sGender.AutoSize = true;
            this.sGender.Location = new System.Drawing.Point(410, 292);
            this.sGender.Name = "sGender";
            this.sGender.Size = new System.Drawing.Size(56, 17);
            this.sGender.TabIndex = 17;
            this.sGender.Text = "Gender";
            // 
            // studentDataTable
            // 
            this.studentDataTable.AllowUserToResizeColumns = false;
            this.studentDataTable.AllowUserToResizeRows = false;
            this.studentDataTable.ColumnHeadersHeight = 29;
            this.studentDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.studentDataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.studentDataTable.Location = new System.Drawing.Point(12, 409);
            this.studentDataTable.Name = "studentDataTable";
            this.studentDataTable.ReadOnly = true;
            this.studentDataTable.RowHeadersWidth = 51;
            this.studentDataTable.RowTemplate.Height = 24;
            this.studentDataTable.Size = new System.Drawing.Size(1322, 382);
            this.studentDataTable.TabIndex = 18;
            this.studentDataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studentDataTable_CellContentClick);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(404, 340);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 19;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(497, 340);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(597, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // studentDataTableLabel
            // 
            this.studentDataTableLabel.AutoSize = true;
            this.studentDataTableLabel.Location = new System.Drawing.Point(19, 389);
            this.studentDataTableLabel.Name = "studentDataTableLabel";
            this.studentDataTableLabel.Size = new System.Drawing.Size(131, 17);
            this.studentDataTableLabel.TabIndex = 22;
            this.studentDataTableLabel.Text = "Student Data Table";
            // 
            // sRegistrationDate
            // 
            this.sRegistrationDate.AutoSize = true;
            this.sRegistrationDate.Location = new System.Drawing.Point(32, 343);
            this.sRegistrationDate.Name = "sRegistrationDate";
            this.sRegistrationDate.Size = new System.Drawing.Size(118, 17);
            this.sRegistrationDate.TabIndex = 23;
            this.sRegistrationDate.Text = "Registration Date";
            // 
            // registrationDate
            // 
            this.registrationDate.Location = new System.Drawing.Point(157, 337);
            this.registrationDate.Name = "registrationDate";
            this.registrationDate.Size = new System.Drawing.Size(200, 22);
            this.registrationDate.TabIndex = 24;
            // 
            // studentReport
            // 
            chartArea4.Name = "ChartArea1";
            this.studentReport.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.studentReport.Legends.Add(legend4);
            this.studentReport.Location = new System.Drawing.Point(722, 29);
            this.studentReport.Name = "studentReport";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.studentReport.Series.Add(series4);
            this.studentReport.Size = new System.Drawing.Size(612, 365);
            this.studentReport.TabIndex = 25;
            this.studentReport.Text = "Student Report";
            // 
            // Chartlabel
            // 
            this.Chartlabel.AutoSize = true;
            this.Chartlabel.Location = new System.Drawing.Point(699, 9);
            this.Chartlabel.Name = "Chartlabel";
            this.Chartlabel.Size = new System.Drawing.Size(104, 17);
            this.Chartlabel.TabIndex = 26;
            this.Chartlabel.Text = "Student Report";
            // 
            // heading
            // 
            this.heading.AutoSize = true;
            this.heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heading.Location = new System.Drawing.Point(168, 29);
            this.heading.Name = "heading";
            this.heading.Size = new System.Drawing.Size(325, 39);
            this.heading.TabIndex = 27;
            this.heading.Text = "Student Detail Form";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "";
            this.Edit.Width = 50;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "";
            this.Delete.Width = 60;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 803);
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
            this.MaximizeBox = false;
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Detail Form";
            ((System.ComponentModel.ISupportInitialize)(this.studentDataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentReport)).EndInit();
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
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}

