using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student
            //{
            //    FullName = "Василий Петров",
            //    Age = 19,
            //    Gender = 1,
            //    MarkAverage = 4.6,
            //    GroupName = "EE-123"
            //};

            Pearson pearson = new Student("Вася Петров", "ЫФЫ 123");
            //object mentor = new Mentor("Василий Петрович");
            Pearson mentor = new Mentor("Василий Петрович");

            (pearson as Student).MarkAverage = 4.6;

            Console.WriteLine(pearson);
            

            Pearson[] people = new Pearson[]
            {
                pearson,mentor
            };


            foreach (var man in people)
            {
                if (man is Student)
                {
                    Console.WriteLine((man as Student).MarkAverage);
                    man.Dostaff("какое-то дело студента");
                }

                else if (man is Mentor)
                {
                    Console.WriteLine((man as Mentor).SubjectsName);
                    man.Dostaff("какое-то дело препода");

                }
            }

            Console.ReadLine();
        }
    }
}
