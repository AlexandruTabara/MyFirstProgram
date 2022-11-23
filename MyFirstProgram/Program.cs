using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int latime;
            int lungime;

            Console.WriteLine("Acest program va calcula aria unei camere:");

            Console.WriteLine("Introduceti latimea");
            latime = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti luingimea");
            lungime = int.Parse(Console.ReadLine());

            int ariaCamerei = latime * lungime;

            Console.WriteLine("Aria camerei este " + ariaCamerei);
        }
    }
}
