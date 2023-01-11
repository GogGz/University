using System;
namespace University
{
	public class Faculty // uni ararkaner ev studentner
	{
		string name;
		Subject[] SubjectsList;

        public Faculty(string name)
		{
			this.name = name;
		}

		public Subject[] SetSubjectsList(Subject subject1, Subject subject2, Subject subject3) // chgitem vonc grem vor uzacs ararkanery dni
		{

			return SubjectsList = new Subject[] { subject1, subject2, subject3 };

		}
        public Subject[] SetSubjectsList(Subject subject1, Subject subject2, Subject subject3, Subject subject4, Subject subject5) // chgitem vonc grem vor uzacs ararkanery dni
        {

            return SubjectsList = new Subject[] { subject1, subject2, subject3 , subject4, subject5 };

        }
    }
}

