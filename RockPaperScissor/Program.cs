using System;

namespace RockPaperScissor
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stato = true;
            Console.WriteLine("Benvenuto!");
            while (stato)
            {
                Console.WriteLine("Inserisci la tua opzione tra rock/paper/scissor");
                string scelta = Console.ReadLine();
                Rps.Events(scelta, Rps.RandomScelta());
                stato=Rps.gameStat();
            }
        }
    }
}
