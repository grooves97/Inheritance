using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLesson
{
    public class Student : Pearson
    {
        //public string FullName { get; set; }
        //public int Age { get; set; }
        //public int Gender { get; set; }
        public double MarkAverage { get; set; }
        public string GroupName { get; set; }
        
        public Student(string fullname,string groupName) : base(fullname)
        {

            GroupName = groupName;
        }
        
        public new void DoStaff(string StaffName)
        {
            //мы явно точно создаем свою реализацию этого метода

        }

        public override string ToString()
        {
            return $"{FullName}, {GroupName}";
        }

    }
}
