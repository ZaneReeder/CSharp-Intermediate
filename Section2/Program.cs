using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2
{
    class Program
    {
        static void UsePoints()
        {
            try
            {
                var point1 = new Point(10, 20);
                point1.Move(new Point(40, 60));
                Console.WriteLine("Point is at {0}, {1}", point1.X, point1.Y);

                point1.Move(100, 200);
                Console.WriteLine("Point is at {0}, {1}", point1.X, point1.Y);

            }
            catch (Exception)
            {
                Console.WriteLine("Unexpected Error Occurred.");
            }
        }

        static void Main(string[] args)
        {
            var customer = new Customer();
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            var order = new Order();
            customer.Orders.Add(order);

            //Object Initializer
            var person1 = new Person
                            {
                                Id = 1,
                                FirstName = "John",
                                LastName = "Reeder",
                                Age = 23
                            };

            //Method Overloading using Parameter Modifier
            var calculator1 = new Calculator();
            Console.WriteLine(calculator1.Add(1, 2));
            Console.WriteLine(calculator1.Add(1, 2, 3, 4));
            Console.WriteLine(calculator1.Add(new int[] { 1, 2, 3, 4, 5 }));

            var customer2 = new Customer(21);
            customer.Orders.Add(new Order());

            Console.WriteLine(customer.Orders.Count);
            customer.Promote();
            Console.WriteLine(customer.Orders.Count);

            //Public vs Private
            //Valid States
            //Properties
            var person2 = new Person(new DateTime(1972, 05, 02));
            //person2.name = "Josh";
            //person2.SetBirthdate(new DateTime(1982, 1, 1));
            //Console.WriteLine();
            //Console.WriteLine(person2.GetBirthdate());
            Console.WriteLine();
            Console.WriteLine(person2.Age);

            //Indexers 
            var cookie = new HttpCookie();
            cookie["name"] = "Zane";
            Console.WriteLine(cookie["name"]);


        }
    }
}
