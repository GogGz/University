using System;
namespace University
{
	public class Student: Person
	{
        int grade; // unen miayn studentnery

        public int MyGrade
        {
            get
            {
                return grade;
            }
            set
            {
                grade = value;
            }
        }



        //Faculty faculty;


        public override void Exam(object obj)
        {
            Console.WriteLine("Take examination");
        }

        public override void MainAction(object obj)
        {
            Console.WriteLine("studying");
        }

    }
}

