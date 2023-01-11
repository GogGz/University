using System;
namespace University
{
	public abstract class Person // yur mard uni anun,azganun, tariq, katarum e gortsogutyun 
	{
		
        string name;
        string surname;
        string age;

        public Person()
        {
        }
        public Person(string name, string surname, string age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;

        }
        public void ShownSurname()
        {
            Console.WriteLine(this.surname);
        }
        public string nameProp
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string surnameProp
        {
            get
            {
                return this.surname;
            }
            set
            {
                this.surname = value;
            }
        }


        public virtual void MainAction(object obj) // sovorel kam dasavandel
        {
            
        }

        public virtual void Exam(object obj) // qnnutyun handznel vercnel
        {

        }
        
	}
}

