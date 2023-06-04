using System;
using System.Globalization;

namespace At5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int codigo = int.Parse(valores[0]);
            int quantidadeDoItem = int.Parse(valores[1]);

            double total = 0.0;
            if ( codigo == 1)
            {
                total = quantidadeDoItem * 4.0;
            }
            else if ( codigo == 2)
            {
                total = quantidadeDoItem * 4.5;
            }
            else if ( codigo == 3)
            {
                total = quantidadeDoItem * 5.0;
            }
            else if ( codigo == 4)
            {
                total = quantidadeDoItem * 2.0;
            }
            else
            {
                total = quantidadeDoItem * 1.5;
            }

            Console.WriteLine($"Total: R${total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}