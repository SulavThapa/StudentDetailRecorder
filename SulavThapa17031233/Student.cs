using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SulavThapa17031233
{
    public class Student
    {
        public int indexNoStudent { get; set; }
        public string Name { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string studentProgramme { get; set; }
        public DateTime studentBirthDate { get; set; }
        public string studentContactNo { get; set; }
        public string studentGender { get; set; }
        public DateTime registrationDate { get; set; }

        public void Add(Student info)
        {

        }
        public Student Edit(int id)
        {
            Student obj = new Student();
            return obj;
        }
        public void Edit(Student info)
        {

        }
        public void Delete(int id)
        {

        }
        public Student Detail(int id)
        {
            Student obj = new Student();
            return obj;
        }
 /*       public List<Student> List()
        {

        }*/
    }
}
