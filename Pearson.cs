using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLesson
{
    public abstract class Pearson
    {

        private string _adress;

        public string FullName { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }

        public Pearson(string fullname)
        {
            FullName = fullname;
        }

        public virtual void DoStaff(string StaffName)
        {
            Console.WriteLine($"{FullName} делает {StaffName}");
        }

        public abstract void SayAllInfo();


    }
}
