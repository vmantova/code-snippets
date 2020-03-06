using System;
using System.Text;
using static System.Console;

namespace fiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product
            {
                Id = 1,
                Name = "Chairxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx",
                Value = 1900,
                DateAdded = $"{DateTime.Now:dd/MM/yyyy HH:mm:ss}"
            };

            WriteLine("Properties of the object");
            WriteLine($"{ClassStringFormatter.Format(product)}");
        }
    }
}
