using System;

namespace ConsoleApp26
{
    public class Customer
    {
        private string id;
        private string name;
        private string phoneNumber;

        public void PrintDetails()
        {
            Console.WriteLine($"ID: {id}, Name: {name}, Phone: {phoneNumber}");
        }
    }
}
