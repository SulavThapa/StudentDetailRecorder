using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;

namespace SulavThapa17031233
{
    class Utility
    {
        public static void Export()
        {

        }
        public static void Import()
        {

        }
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
        public static string ReadFromTextFile()
        {
            return null;
        }
        public static DataTable ConvertToDataTable()
        {
            return null;
        }
    }
}
