using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Phase1Section5._8
{
    public class SubjectTeacher : Teacher
    {
        private SubjectTeacher whichSubject;

        public SubjectTeacher WhichSubject
        {
            get { return whichSubject; }
            set { whichSubject = value; }
        }
    }
}

