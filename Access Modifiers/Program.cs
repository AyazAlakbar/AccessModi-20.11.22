using System;

namespace Access_Modifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello World!");

            Person person = new Person();
            Console.WriteLine("enter the name");
            person.Name = Console.ReadLine();
            Console.WriteLine(person.Name);



        }
    }
}
