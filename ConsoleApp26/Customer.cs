using System;

namespace ConsoleApp26
{
    public class Customer
    {
        private string id;
        private string name;
        private string phoneNumber;

        public Customer(string id, string name, string phoneNumber)
        {
            this.id = id;
            this.name = name;
            this.phoneNumber = phoneNumber;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"ID: {id}, Name: {name}, Phone: {phoneNumber}");
        }
    }
}
