using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$
{
    public class StudentRcrd
    {
        public StudentRcrd() { }

        public StudentRcrd(string name1, string lastName1, int dateOfBirth1, int joinDate1, string nationality1)
        {
            Name1 = name1;
            Lastname1 = lastName1;
            DateofBirth1 = dateOfBirth1;
            JoinDate1 = joinDate1;
            Nationality1 = nationality1;

        }

        public string Name1 { get; set; }
        public string Lastname1 { get; set; }
        public int DateofBirth1 { get; set; }
        public int JoinDate1 { get; set; }
        public string Nationality1 { get; set; }

        // public string GetDisplayText () => $"{Name1}    {Lastname1}    ({DateofBirth1}:c) {JoinDate1} {Nationality1}";
        public string GetDisplayText () => $"{Name1}    {Lastname1}    {DateofBirth1}     {JoinDate1}    {Nationality1}";
    }
}
