using System;

namespace Lab1_AccessModifiers
{
    class Student1
    {
        public string Name = "Adarsh";
        private int Age = 22;
        protected string Department = "MCA";
        internal double CGPA = 68.3;
        protected internal string College = "GLA University";
        private protected string Address = "Mathura";

        public void Display()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Department: " + Department);
            Console.WriteLine("CGPA: " + CGPA);
            Console.WriteLine("College: " + College);
            Console.WriteLine("Address: " + Address);
        }
    }

    class Program2
    {
        static void Main2(string[] args)
        {
            Student1 s = new Student1();

            s.Display();

            Console.ReadLine();
        }
    }
}
