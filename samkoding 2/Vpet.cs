using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace samkoding_2
{
    

    internal class pikachu
    {
        public string navn;
        public int alder;
        public int sultenhet;
        public int lykkelighet;
        public int toalettbehov;

        public pikachu(string navn, int alder, int sultenhet = 50, int lykkelighet = 50, int toalettbehov = 50)
        {
            this.navn = navn;
            this.alder = alder;
            this.sultenhet = sultenhet;
            this.lykkelighet = lykkelighet;
            this.toalettbehov = toalettbehov;
        }
        
        public void mat()
        {
            sultenhet += 10;
            lykkelighet += 5;
            toalettbehov -= 5;
            Console.WriteLine($"{navn} har fått mat!");
        }
        public void kos()
        {
            lykkelighet += 10;
            sultenhet -= 5;
            Console.WriteLine($"{navn} har fått kos!");
        }

        public void toalettsjekk()
        {
            if (toalettbehov < 60)
            {
                Console.WriteLine($"{navn} må på do snart!");
            }
            else
            {
                Console.WriteLine($"{navn} må ikke på do ennå!");
            }
        }
        public void tilstand()
        {
            Console.WriteLine($"Sultenhet er {sultenhet} Lykkelighet er {lykkelighet} Toalettbehov er {toalettbehov}");
        }


    }
    
   
}
