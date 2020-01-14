using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SulavThapa17031233
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            BindGrid();

            btnUpdate.Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                //making the refrence object of the student made in the student class
                Student obj = new Student();
                //Adding the data from the textbox to the object
                string firstname = firstName.Text;
                string lastname = lastName.Text;
                obj.Name = firstname + " " + lastname;
                obj.address = address.Text;
                obj.email = email.Text;
                obj.studentProgramme = studentProgramme.Text;
                obj.studentBirthDate = studentBirthDate.Value;
                obj.studentContactNo = studentContactNo.Text;
                obj.studentGender = studentGender.SelectedItem.ToString();
                obj.registrationDate = registrationDate.Value;
                obj.Add(obj);
                BindGrid();
                Clear();
            }
        }

        private bool Validation()
        {
            if(firstName.Text == "" && lastName.Text == "" && address.Text == "" && email.Text == "" && studentContactNo.Text == "" ){
                MessageBox.Show("Input all the datas");
            }
            return false;

        }

        private void Clear()
        {
            //clearing all the text view
            txtId.Text = "";
            firstName.Text = "";
            lastName.Text = "";
            address.Text = "";
            email.Text = "";
            studentProgramme.SelectedItem = null;
            studentBirthDate.Value = DateTime.Today;
            studentContactNo.Text = "";
            studentGender.SelectedItem = null;
            registrationDate.Value = DateTime.Today;
        }
        private void BindGrid()
        {
            //Binding the data to the datatable
            Student obj = new Student();
            List<Student> studentList = obj.List();
            DataTable datatable = Utility.ConvertToDataTable(studentList);
            studentDataTable.DataSource = datatable;
            BindChart(studentList);
        }
        private void studentDataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //making the student object
            Student obj = new Student();
            if (e.ColumnIndex == 0)
            {
                string values = studentDataTable[2, e.RowIndex].Value.ToString();
                int num = 0;
                if (String.IsNullOrEmpty(values))
                {
                    MessageBox.Show("Invalid Data");
                }
                else
                {
                    num = int.Parse(values);
                    Student student = obj.List().Where(x => x.indexNoStudent == num).FirstOrDefault();
                    txtId.Text = student.indexNoStudent.ToString();
                    firstName.Text = student.Name.Split(' ')[0];
                    lastName.Text = student.Name.Split(' ')[1];
                    address.Text = student.address.ToString();
                    email.Text = student.email;
                    studentProgramme.SelectedItem = student.studentProgramme;
                    studentContactNo.Text = student.studentContactNo;
                    studentGender.SelectedItem = student.studentGender;
                    btnSubmit.Visible = false;
                    btnUpdate.Visible = true;
                }
            }
            else if (e.ColumnIndex == 1)
            {
                string values = studentDataTable[2, e.RowIndex].Value.ToString();
                if (String.IsNullOrEmpty(values))
                {
                    MessageBox.Show("Cant Delete An Empty Row!");
                }
                else
                {
                    string message = "Do you want to Delete this Data?";
                    string title = "Confirmation";
                    MessageBoxButtons button = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show(message, title, button);
                    if (result == DialogResult.OK)
                    {
                        //get the value of the clicked rows id column
                        string value = studentDataTable[2, e.RowIndex].Value.ToString();
                        obj.Delete(int.Parse(value));
                        BindGrid();
                        MessageBox.Show("Record Successfully Deleted");
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                //making the refrence object of the student made in the student class
                Student obj = new Student();
                //Adding the data from the textbox to the object
                obj.indexNoStudent = int.Parse(txtId.Text);
                string firstname = firstName.Text;
                string lastname = lastName.Text;
                obj.Name = firstname + " " + lastname;
                obj.address = address.Text;
                obj.email = email.Text;
                obj.studentProgramme = studentProgramme.Text;
                obj.studentBirthDate = studentBirthDate.Value;
                obj.studentContactNo = studentContactNo.Text;
                obj.studentGender = studentGender.SelectedItem.ToString();
                obj.registrationDate = registrationDate.Value;
                obj.Edit(obj);
                BindGrid();
                Clear();
                btnUpdate.Visible = false;
                btnSubmit.Visible = true;
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void sortDataTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student student = new Student();
            List<Student> studentList = student.List();
            if (sortDataTable.SelectedItem.ToString().Equals("Name(Ascending)"))
            {
                List<Student> list = student.sortByFirstNameAsc(studentList);
                DataTable dt = Utility.ConvertToDataTable(list);
                studentDataTable.DataSource = dt;
            }
            else if (sortDataTable.SelectedItem.ToString().Equals("Name(Descending)"))
            {
                List<Student> list = student.sortByFirstNameDesc(studentList);
                DataTable dt = Utility.ConvertToDataTable(list);
                studentDataTable.DataSource = dt;
            }
            else if (sortDataTable.SelectedItem.ToString().Equals("RegistrationDate (Ascending)"))
            {
                List<Student> list = student.sortByRegistrationDateAsc(studentList);
                DataTable dt = Utility.ConvertToDataTable(list);
                studentDataTable.DataSource = dt;
            }
            else if (sortDataTable.SelectedItem.ToString().Equals("RegistrationDate (Descending)"))
            {
                List<Student> list = student.sortByRegistrationDateDesc(studentList);
                DataTable dt = Utility.ConvertToDataTable(list);
                studentDataTable.DataSource = dt;
            }
        }
        private void BindChart(List<Student> lst)
        {
            //Displaying the chart according to the Programme of the student
            if (lst != null)
            {
                var result = lst
                    .GroupBy(l => l.studentProgramme)
                    .Select(cl => new
                    {
                        studentProgramme = cl.First().studentProgramme,
                        Count = cl.Count().ToString()
                    }).ToList();
                DataTable dt = Utility.ConvertToDataTable(result);
                studentReport.DataSource = dt;
                studentReport.Name = "Student Programme";
                studentReport.Series["Series1"].XValueMember = "studentProgramme";
                studentReport.Series["Series1"].YValueMembers = "Count";
                studentReport.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
                studentReport.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
                this.studentReport.Titles.Remove(this.studentReport.Titles.FirstOrDefault());
                this.studentReport.Titles.Add("Student Programme Report");
                studentReport.Series["Series1"].IsValueShownAsLabel = true;
            }
        }
        private void weeklyReportDatePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = weeklyReportDatePicker.Value;
            var cultureCulture = System.Threading.Thread.CurrentThread.CurrentCulture;
            var difference = selectedDate.DayOfWeek - cultureCulture.DateTimeFormat.FirstDayOfWeek;
            if (difference < 0)
                difference += 7;
            var first_day_week = selectedDate.AddDays(-difference).Date;
            var last_day_week = selectedDate.AddDays(7);
            studentWeeklyReport.Rows.Clear();
            Student obj = new Student();
            List<Student> listStudents = obj.List();
            var convertStudents = listStudents.Where(s => s.registrationDate >= first_day_week && s.registrationDate < last_day_week);


            int computing = 0;
            int networking = 0;
            int multimedia = 0;

            foreach (Student stu in convertStudents)
            {
                if (stu.studentProgramme == "Computing")
                {
                    computing += 1;
                }
                else if (stu.studentProgramme == "Multimedia")
                {
                    multimedia += 1;
                }
                else if (stu.studentProgramme == "Networking")
                {
                    networking += 1;
                }
            }


            studentWeeklyReport.Rows.Add(new Object[] { "Computing", computing });
            studentWeeklyReport.Rows.Add(new Object[] { "Multimedia", multimedia });
            studentWeeklyReport.Rows.Add(new Object[] { "Networking", networking });

            if (computing == 0 && networking == 0 && multimedia == 0)
            {
                //Nothing to plot here
            }
        }
    }
}

