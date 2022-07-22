using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Customer customer1 = new Customer() {Id=1,FirstName="Uğurcan",LastName="KURT",City="Bartın" };

            Customer customer2 = new Customer (2,"Kurt","UĞURCAN","Kocaeli");

            Console.WriteLine(customer2.FirstName);
            


        }
        
    }

   



    class Customer
    {

        public Customer()
        {
                
        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;

        }
        
        public int Id { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string City { get; set; }
    } 


}

