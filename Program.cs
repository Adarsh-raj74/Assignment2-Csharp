using System;
using StudentLibrary;

namespace StudentClient
{
    class Program
    {
        static void Main(string[] args)
        {
            // ResearchStudent object
            ResearchStudent r = new ResearchStudent();

            r.ShowResearchData();

            Console.WriteLine();

            // Student object
            Student s = new Student();

            // public - accessible
            Console.WriteLine("Name: " + s.name);

            // private - NOT accessible
            // Console.WriteLine("Age: " + s.age);

            // protected - NOT accessible through object
            // Console.WriteLine("Course: " + s.course);

            // internal - NOT accessible from different assembly
            // Console.WriteLine("College: " + s.college);

            // protected internal - NOT accessible through
            // Student object in this different assembly
            // Console.WriteLine("Department: " + s.department);

            // private protected - NOT accessible
            // Console.WriteLine("Roll No: " + s.rollNo);

            Console.ReadLine();
        }
    }
}