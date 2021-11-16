using System;

namespace Hadani_cisel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            while (true)
            {
                Random random = new Random();
                int nahodne_cislo = random.Next(1, 100);
                bool spatny_tip = true;
                double tip;
                Console.Clear();
                Console.WriteLine("Hádání čísla");
                Console.WriteLine("----------------");
                Console.WriteLine("Myslím si číslo od 1 do 100");
                while (spatny_tip)
                {
                    Console.WriteLine("Tipni si číslo");
                    double.TryParse(Console.ReadLine(), out tip);
                    if (tip < nahodne_cislo)
                    {
                        Console.WriteLine("To je málo :( ");
                        Console.WriteLine();
                    }
                    else if (tip > nahodne_cislo)
                    {
                        Console.WriteLine("To je moc :( ");
                        Console.WriteLine();
                    }
                    else
                    {
                       Console.WriteLine("Trefa! :D ");
                        spatny_tip = false;
                        Console.WriteLine();

                    }
       
                }
                Console.ReadLine();

                
               
                
                
            

                


            }
            

           
            
            
        }
    }
}
