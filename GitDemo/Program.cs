using System;

namespace GitDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Products products = new Products();

            products.Nombre = "Atun en aceite.";
            products.Cantidad = 3;
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
