using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    public static class studentRecordsInventoryDB
    {
        private const string Path = @"..\..\..\StudentRecords.txt";
        private const string Separator = " ";

        public static List<StudentRcrd> GetStudents()
        {
            // Creating list
            List<StudentRcrd> students = new List<StudentRcrd>

            // Creating obj for the input stream for Textfile
            StreamReader textIn =
                new StreamReader(new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read));

            // read data from file and store it in the list 
            while(textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split(Separator);
                StudentRcrd student = new StudentRcrd();
                student.Name1 = columns[0];
                student.Lastname1 = columns[1];
                student.DateofBirth1 = Convert.ToInt32(columns[2]);
                student.JoinDate1 = Convert.ToInt32(columns[3]);
                student.Nationality1 = columns[4];
                students.Add(student);
            }
            textIn.Close();


            return students;
        }
    }
}
