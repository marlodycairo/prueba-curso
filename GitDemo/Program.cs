using System;
using System.Collections.Generic;

namespace GitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Products products = new Products();

            products.Nombre = "Atun en aceite.";
            products.Cantidad = 3;

            Person person = new Person() { Nombre = "coco", Edad = "22", Ciudad = "Envigado", Email = "coco@gmail.com" };

            var newperson = person.CrearPersona(person);

            Console.WriteLine(newperson);
        }
    }

    public class Person
    {
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string Ciudad { get; set; }
        public string Email { get; set; }

        public Person CrearPersona(Person person)
        {
            Person person1 = new Person()
            {
                Nombre = person.Nombre,
                Edad = person.Edad,
                Ciudad = person.Ciudad,
                Email = person.Email
            };
            return person1;
        }
    }

    
}
