using System;

namespace AccessModifierLab
{
    public class GraduateStudent : Student3
    {
        public void ShowData()
        {
            Console.WriteLine("Through Inheritance:");

            // Accessible
            Console.WriteLine("Public name: " + name);

            // Not accessible - private member
            // Console.WriteLine("Private age: " + age);

            // Accessible - protected member
            Console.WriteLine("Protected course: " + course);

            // Accessible - internal member (same assembly)
            Console.WriteLine("Internal college: " + college);

            // Accessible - protected internal
            Console.WriteLine("Protected Internal city: " + city);


            Console.WriteLine("\nThrough Student Object:");

            Student3 s = new Student3();

            // Accessible
            Console.WriteLine("Public name: " + s.name);

            // Not accessible - private
            // Console.WriteLine("Private age: " + s.age);

            // Not accessible through Student object
            // Console.WriteLine("Protected course: " + s.course);

            // Accessible - same assembly
            Console.WriteLine("Internal college: " + s.college);

            // Accessible in same assembly because protected internal
            Console.WriteLine("Protected Internal city: " + s.city);
        }
    }
}