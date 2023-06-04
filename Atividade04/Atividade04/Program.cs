using System;

namespace At04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            
            int horaIncial = int.Parse(numbers[0]);
            int horaFinal = int.Parse(numbers[1]);

            int duracao;

            if (horaIncial < horaFinal)
            {
                duracao = horaFinal - horaIncial;
            }
            else
            {
                duracao = 24 -  horaIncial + horaFinal;
            }
            Console.WriteLine($"JOGO DUROU {duracao} HORA(S)");

        }
    }
}