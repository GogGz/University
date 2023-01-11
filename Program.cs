namespace University;
class Program
{
    static void Main(string[] args)
    {
        Faculty MathFac = new Faculty("MathFac");

        MathFac.SetSubjectsList(Subject.Math, Subject.Languages, Subject.Geography);

        AddFaculty("LangFac");

        Professor Dallakyan = new Professor("Anna", "Dallakyan", 46);
        Dallakyan.subj = Subject.History;
        Dallakyan.ShownSurname();
            
       

    }

    public static Faculty AddFaculty( string name)
    {
        
        Faculty obj1 = new Faculty(name);
        return obj1;
            
     }



}

