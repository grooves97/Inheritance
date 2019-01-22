using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLesson
{
    public class Mentor : Pearson
    {
        //public string FullName { get; set; }
        //public int Age { get; set; }  Убираем это по скольку у нас есть уже готовые унаследованные поля с класса Персон
        //public int Gender { get; set; }
        public string[] SubjectsName { get; set; }

        public Mentor(string fullname) : base(fullname)
        {

        }

        public override void DoStaff(string StaffName)
        {

        }

        public override void SayAllInfo()
        {

        }
    }
}
