using System;

namespace Lab1_AccessModifiers
{
    class Student
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

    // Another class in the same assembly
    class TestStudent
    {
        public void Test()
        {
            Student s = new Student();

            // 1. public - Accessible
            Console.WriteLine("Name: " + s.Name);

            

            

            // 4. internal - Accessible
            Console.WriteLine("CGPA: " + s.CGPA);

            // 5. protected internal - Accessible
            Console.WriteLine("College: " + s.College);

            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TestStudent t = new TestStudent();

            t.Test();

            Console.ReadLine();
        }
    }
}