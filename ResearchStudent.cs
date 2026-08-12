using System;
using StudentLibrary;

namespace StudentClient
{
    class ResearchStudent : Student
    {
        public void ShowResearchData()
        {
            Console.WriteLine("Name: " + name);

            // private - NOT accessible
            // Console.WriteLine("Age: " + age);

            // protected - accessible
            Console.WriteLine("Course: " + course);

            // internal - NOT accessible
            // Console.WriteLine("College: " + college);

            // protected internal - accessible
            Console.WriteLine("Department: " + department);

            // private protected - NOT accessible
            // Console.WriteLine("Roll No: " + rollNo);
        }
    }
}
