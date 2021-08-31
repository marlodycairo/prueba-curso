using System;
using System.Collections.Generic;

namespace GitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Products products = new Products();

            List<Products> lstProducts = new List<Products>();

            lstProducts.Add(new Products() { Nombre = "Atun en aceite.", Cantidad = 3 });
            lstProducts.Add(new Products() { Nombre = "Cazuela de mariscos.", Cantidad = 2 });
            lstProducts.Add(new Products() { Nombre = "Salmón.", Cantidad = 2 });


            Console.WriteLine(products);
        }
    }

    public class Person
    {
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string Ciudad { get; set; }
        public string Email { get; set; }
    }
}
