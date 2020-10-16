using System;

namespace CsharpProject
{
    abstract class Apartment
    {
        string FloorNumber;
        string DoorNumber;
        string ResidentName;

        public abstract string Ring();

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
