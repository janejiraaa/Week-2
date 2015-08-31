using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab202
{
    class Course
    {
        private string name;
        private string courseID;
        private string lecturer;
        private int maxStudents;
        private int numStudents;

        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }
        public string CourseID {
            get {
                return courseID;
            }
            set {
                if (value.Length == 6)
                {
                    int count = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        if (char.IsDigit(value[i]))
                        {
                            count++;
                        }
                    }
                    if (count == 6)
                    {
                        courseID = value;
                    }
                    else {
                        Console.WriteLine("{0}: error try setting invalid CourseID!",courseID);
                    }
                }
                else {
                    Console.WriteLine("{0}: error try setting invalid CourseID!", courseID);
                }
            }
        }
        public string Lecturer {
            get {
                return lecturer;
            }
            set {
                lecturer = value;
            }
        }
        public int MaxStudents {
            get {
                return maxStudents;
            }
            set {
                if (value <= 80 && value >= 0 && value >= numStudents)
                {
                    maxStudents = value;
                }
                else {
                    Console.WriteLine("{0}: error try setting invalid Max No. Students!", courseID);
                }
            }
        }
        public int NumStudents {
            get {
                return numStudents;
            }
            set {
                if (value <= maxStudents && value >= 0)
                {
                    numStudents = value;
                }
                else {
                    Console.WriteLine("{0}: error try setting invalid No. Students!", courseID);
                }
            }
        }

        public Course() {
            name = "Jane";
            courseID = "123456";
            lecturer = "staff";
            maxStudents = 30;
            numStudents = 0;
        }
        public Course(string name , string courseID) {
            this.name = name;
            this.courseID = courseID;
            lecturer = "staff";
            maxStudents = 30;
            numStudents = 0;
        }
        public Course(string name, string courseID, string lecturer)
        {
            this.name = name;
            this.courseID = courseID;
            this.lecturer = lecturer;
            maxStudents = 30;
            numStudents = 0;
        }
        public Course(string name, string courseID, string lecturer, int maxStudents)
        {
            this.name = name;
            this.courseID = courseID;
            this.lecturer = lecturer;
            this.maxStudents = maxStudents;
            numStudents = 0;
        }

        public override string ToString()
        {
            return "[Course: "+Name+" ("+CourseID+"), Lecturer="+Lecturer+", has "+NumStudents+" students, max="+MaxStudents+"]";//[Course: Object-Oriented Programming (261200), Lecturer=staff, has 0 students, max=30]
        }
    }
}
