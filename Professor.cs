using System;
namespace University
{
    public class Professor : Person
    {
        string ProfLevel; // unen miays professornery
        public Subject subj { get; set; }
        public string V1 { get; }
        public string V2 { get; }
        public int V3 { get; }

        public void ShowSubject(Person obj)
        {
            Console.WriteLine(obj.ShownSurname + " teaches " + this.subj );
        }


        public void SetProfLevel(int a)
        {
            if (a == 0)
            {
                ProfLevel = "Entry";
                Console.WriteLine("ProfLevel is entry");
            }

            else if (a == 1)
            {
                ProfLevel = "Docent";
                Console.WriteLine("ProfLevel is Docent");
            }
            else
            {
                ProfLevel = "Highest";
                Console.WriteLine("Highest Proflevel");
            }
        }

        public Professor() 
		{
		}

        public Professor(string v1, string v2, int v3)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
        }

        public override void Exam(object obj)
        {
            Console.WriteLine("Hold examination");
        }

        public override void MainAction(object obj)
        {
            Console.WriteLine("Teaching");
        }
    }
}