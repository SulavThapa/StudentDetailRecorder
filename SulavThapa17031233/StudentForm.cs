using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void Clear()
        {
            //clearing all the text view
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
        private void BindChart(List<Student> lists)
        {

        }
    }
}
