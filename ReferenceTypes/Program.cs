using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Uğurcan";
            person2 = person1;
            person1.FirstName = "Uğur";
            Console.WriteLine(person2.FirstName);

           



            Customer customer = new Customer();
            customer.FirstName = "Salih";
            Console.WriteLine(customer.FirstName);
            customer.CreditCartNumber = "1234567";
            
            
            Employee employee = new Employee();
            employee.FirstName = "Ali";
            Person person3 = customer;
            person3.FirstName = "Mehmet";


            Console.WriteLine(((Customer)person3).CreditCartNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);
            personManager.Add(customer);



        }
    }

    class Person
    {
        public int Id { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
    }

    class Customer:Person
    {
    
        public string CreditCartNumber { get; set; }
    
    }

    class Employee:Person
    {
       
        public int EmployeeNumber { get; set; }
    
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }

}
