using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.ComponentModel;

namespace SulavThapa17031233
{
    class Utility
    {
        public static void WriteToTextFile(string filepath, string studentData, bool append =true, int count = 1)
        {
            if (!File.Exists(filepath))
            {
                var file = File.Create(filepath);
                file.Close();
            }
            using (StreamWriter writer = new StreamWriter(filepath, append: append))
            {
                if (!append)
                {
                    //to remove the first bracket and the last bracket "[]"
                    studentData = studentData.Trim().Substring(1, studentData.Trim().Length - 1);
                    studentData = studentData.Trim().Substring(0, studentData.Trim().Length - 1);

                }
                if (count != 0)
                {
                    studentData = studentData + ",";
                }
                writer.WriteLine(studentData);
            }

        }
        public static string ReadFromTextFile(string filepath)
        {
            if (File.Exists(filepath))
            {
                string studentData;
                using (StreamReader reader = new StreamReader(filepath))
                {
                    studentData = reader.ReadToEnd();
                }
                if(studentData != "")
                {
                    Console.WriteLine(studentData);
                    studentData = "[" + studentData + "]";
                }
                return studentData;
            }
            return null;
        }
        public static DataTable ConvertToDataTable<T>(IList<T> studentData)
        {
            PropertyDescriptorCollection properties =
              TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            if (studentData != null)
            {
                foreach (T item in studentData)
                {
                    DataRow row = table.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                    table.Rows.Add(row);
                }
            }
            return table;
        }
    }
}
