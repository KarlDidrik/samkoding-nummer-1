namespace samkoding_2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Gi kjæledyret ditt et navn: ");
            string navn = Console.ReadLine();

            Console.WriteLine($"Hvor gammel er {navn}");
            int alder = Convert.ToInt32(Console.ReadLine());
            var vpet = new pikachu(navn, alder);
            Console.WriteLine($"Navn ={vpet.navn} og alder {vpet.alder}");

            while (true)
            {
                Console.WriteLine("Velg en handling");
                Console.WriteLine("1. Gi mat");
                Console.WriteLine("2. Kos med dyret");
                Console.WriteLine("3.  Sjekk toalettbehov");
                Console.WriteLine("4. Sjekk hvordan dyret ditt har det");

                string valg = Console.ReadLine();



            switch (valg)
            {
                case "1":
                    vpet.mat();
                    break;
                case "2":
                    vpet.kos();
                    break;
                case "3":
                    vpet.toalettsjekk();
                    break;
                    case "4":
                        vpet.tilstand();
                        break;
            }
            }
        }
    }
}