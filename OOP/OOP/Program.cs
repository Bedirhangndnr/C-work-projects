using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "bedirhan",
                LastName = "Gundoner",
                Address = "avcılar"
            };
            Student student = new Student
            {
                Id = 1,
                FirstName = "bedirhan",
                LastName = "Gundoner",
                Departmant = "Computer Sciences"
            };
            personManager.Add(student);

            Console.ReadLine();
        }
    }


}
