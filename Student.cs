using System;

namespace StudentLibrary
{
    public class Student
    {
        public string name = "Adarsh";

        private int age = 22;

        protected string course = "MCA";

        internal string college = "GLA University";

        protected internal string department = "Computer Science";

        private protected string rollNo = "MCA101";

        public void ShowData()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Course: " + course);
            Console.WriteLine("College: " + college);
            Console.WriteLine("Department: " + department);
            Console.WriteLine("Roll No: " + rollNo);
        }
    }
}