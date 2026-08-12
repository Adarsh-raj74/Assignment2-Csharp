using System;
using StudentLibrary;

namespace StudentClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();

            // Accessible: public
            Console.WriteLine("Name: " + s.name);

            // Inaccessible: private
            // Console.WriteLine("Age: " + s.age);

            // Inaccessible: protected
            // Console.WriteLine("Course: " + s.course);

            // Inaccessible: internal
            // Console.WriteLine("College: " + s.college);

            Console.ReadLine();
        }
    }
}