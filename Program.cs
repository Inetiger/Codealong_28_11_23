using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Codealong_28_11_23
{
    internal class Program
    {
        static Random random = new Random();
        public static List<Hest> Stall = new List<Hest>()
        {
            new Hest(random.Next(20,35), "1"),
            new Hest(random.Next(20,35), "2"),
            new Hest(random.Next(20,35), "3"),
        };
        static void Main()
        {
            switch (Ask("1. Vil du mate hesten\n2. Vil du stelle hesten\n3. vil melde hest til løp"))
            {
                case "1":
                    Console.WriteLine("Da var Hesten mett");
                    break;
                case "2":
                    Console.WriteLine("Da var hesten stellt");
                    break;
                case "3":
                    MeldeHestTilLøp(Ask("Hvilken hest vil du ta?"));
                    break;
                default:
                    Environment.Exit(1);
                    break;
            }

            if (Ask("Vil du starte løp? y/n") == "y") StartLøp();
            else Main();
        }

        private static void MeldeHestTilLøp(string WhichHorse)
        {
            // Stall[WhichHorse - 1];
        }

        public static List<int> rounds;
        private static void StartLøp()
        {
            foreach (var Hest in Stall)
            {
                bool if3000 = true;
                int km = 0;
                int runder = 0;
                while (if3000)
                {
                    km += Hest.Speed();
                    runder++;
                    if (km == 3000) if3000 = false;
                }
                rounds.Add(runder);
            }

            foreach (var runde in rounds)
            {
                Console.WriteLine(runde);
            }
        }

        public static string Ask(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }
    }
}

/*
 To the stables!
   
    Du skal lage en stall, den skal ha noen hester. Hestene kan løpe i forskjellige hastigheter, feks 20km/h, 30km/h og 35km/h. 
    Du skal kunne mate hesten, stelle med hesten og hesten skal kunne meldes på hesteløp. 
    Under et hesteløp kan man ha en løkke (for enkelhetsskyld kan hver runde i løkken tilsvare 1 time) som går frem til en av hestene har vunnet. 
    En hest skal løpe 3 runder rundt travbanen ( en runde rundt travbanen er ikke det samme som en runde i løkken 🙂 ). En runde er 1000km. 
    Om man angir totalt antall km en hest må løpe for å vinne til 3000km, så kan man printe ut hvilken hest som leder for hver runde.
 */