using System;

namespace AccessModifierLab
{
    public class Student3
    {
        public string name = "Adarsh";
        private int age = 22;
        protected string course = "MCA";
        internal string college = "GLA University";
        protected internal string city = "Mathura";

        public void ShowStudent()
        {
            Console.WriteLine("Student Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Course: " + course);
            Console.WriteLine("College: " + college);
            Console.WriteLine("City: " + city);
        }
    }
}