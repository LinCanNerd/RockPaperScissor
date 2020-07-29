using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissor
{
    public static class Rps
    {
        private static Random rnd = new Random();

        private static int playerScore = 0;

        private static int machineScore = 0;

        private static  string[] scelte = { "rock", "paper", "scissor" };

        public static string RandomScelta()
        {
            return scelte[rnd.Next(0, 3)];
        }

        private static void win() { 
            playerScore++;
            Console.WriteLine("Hai vinto!");
        }

        private static void lose(){
            machineScore++;
            Console.WriteLine("Hai perso!");
        }

        private static void tie(){
            Console.WriteLine("Pareggio!");
        }

        public static void Events(string sceltaP,string sceltaM)
        {
            Console.WriteLine(sceltaM);
            sceltaP=sceltaP.ToLower();
            switch (sceltaP) {
                case "rock":
                    if (sceltaM=="scissor") { win(); }
                    else if (sceltaM=="paper") { lose(); }
                    else { tie(); }
                    break;
                case "scissor":
                    if (sceltaM.Equals("paper")) { win(); }
                    else if (sceltaM.Equals("rock")) { lose(); }
                    else { tie(); }
                    break;
                case "paper":
                    if (sceltaM.Equals("rock")) { win(); }
                    else if (sceltaM.Equals("scissor")) { lose(); }
                    else { tie(); }
                    break;
                default:
                    Console.WriteLine("Inserisci un opzione valida");
                    break;
            }

            Console.WriteLine("Player " + playerScore + ":" + +machineScore+" Machine ");
        }

        public static bool gameStat()
        {
            Console.WriteLine("Vuoi continuare?  si/no");
            string stat = Console.ReadLine();
            stat = stat.ToLower();
            if (stat.Equals("si")) { return true; }
            else if (stat.Equals("no")) { return false; }
            else { gameStat(); }
            return false; 
        }
    }
}
