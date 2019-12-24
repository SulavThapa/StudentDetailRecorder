using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SulavThapa17031233
{
    public class Student
    {
        private string _filePath = "studentData.json";
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
            Random random = new Random();
            info.indexNoStudent = random.Next(1000, 9999);
            string data = JsonConvert.SerializeObject(info, Formatting.None);
            Utility.WriteToTextFile(_filePath, data);
        }
        public Student Edit(int id)
        {
            Student obj = new Student();
            return obj;
        }
        public void Edit(Student info)
        {
            //Invoking the list method of the student and performing the remove || add || writing to the text file action
            List<Student> list = List();
            Student student = list.Where(x => x.indexNoStudent == info.indexNoStudent).FirstOrDefault();
            list.Remove(student);
            list.Add(info);
            string studentData = JsonConvert.SerializeObject(list, Formatting.None);
            Utility.WriteToTextFile(_filePath, studentData, false);
        }

        public List<Student> List()
        {
            string path = Utility.ReadFromTextFile(_filePath);
            if (path != null)
            {
                List<Student> lst = JsonConvert.DeserializeObject<List<Student>>(path);
                return lst;
            }
            return null;
        }

        public void Delete(int id)
        {
            //Invoking the list of student to delete it from its index number
            List<Student> list = List();
            Student student = list.Where(x => x.indexNoStudent == id).FirstOrDefault();
            list.Remove(student);
            int count = list.Count;
            string studentData = JsonConvert.SerializeObject(list, Formatting.None);
            Utility.WriteToTextFile(_filePath, studentData, false ,count);
        }
        public Student Detail(int id)
        {
            Student obj = new Student();
            return obj;
        }
    }
}
