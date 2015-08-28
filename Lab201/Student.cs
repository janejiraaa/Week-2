using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab201
{
    class Student
    {
        private string name;
        private int year;
        private bool isactive;
        private string studentID;

        public Student() {
            name = "John Doe";
            studentID = "Unknow";
            year = 1995;
            isactive = false;
        }

        public Student(string n, string i) {
            name = n;
            studentID = i;
            year = 1995;
            isactive = true;
        }

        public Student(string n, string i, int y) {
            name = n;
            studentID = i;
            year = y;
            isactive = true;
        }

        public Student(string n, string i, int y, bool IsActive) {
            name = n;
            studentID = i;
            year = y;
            isactive = IsActive;
        }

        public string Name {
            get {
                return name;
            }
            set {
                this.name = value;
            }
        }
        public int YearOfBirth
        {
            get
            {
                return year;
            }
            set
            {
                if (value >= 1950 && value <= 2000)
                {
                    YearOfBirth = value;
                }
                else {
                  Console.WriteLine (studentID + "error try setting invalid year-of-birth value!");
                }
                
            }
        }
        public bool isActive
        {
            get
            {
                return isactive;
            }
            set
            {
                isactive = value;
            }
        }
        public string StudentID
        {
            get
            {
                return studentID;
            }
            set
            {
                studentID = value;
            }
        }
        public int getAge() {
            return DateTime.Now.Year - YearOfBirth;
        }
        public override string ToString() //[Student: s6 (57006), age=20, is active student]
        {
            if (isActive == true) {
                return "[Student: "+Name+" ("+studentID+"), age="+getAge()+", is active student]"; }
            else {
                return "[Student: " + Name + " (" + studentID + "), age=" + getAge() + ", is NOT active student]";
            }
        }
    }
}
 