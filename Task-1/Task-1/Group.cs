using System;
using System.Collections.Generic;
using System.Text;

namespace Task_1
{
    internal class Group:Student
    {

        private static string fullname;
        private static string groupno;
        private static int avgpoint;
        public int No;
        public Student[] students;
        public int Limit;


        public Group(int no, Student Students, int limit) : base(fullname, groupno, avgpoint)
        {

            No = no;
            Fullname = Students.Fullname;
            Limit = limit;


        }

        public void Info()
        {
            Console.WriteLine($"no: {No}, Student: {Fullname}, Limit: {Limit}");
        }



        public Student[] AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;

            return students;

        }
    }


}

