using System;

namespace ASC1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salut!");

            string response;

            do
            {
                Console.WriteLine("Introduceti numarul de pantof: ");

                int numarPantof;
                try {
                    numarPantof = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Aveti {numarPantof} numarul la pantof");
                } catch (Exception e) {
                    Console.WriteLine("Va rugam sa folositi doar numere intregi!");
                    return;
                }

                if(numarPantof > 44)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bigfoot", Console.ForegroundColor);
                }
                else if(numarPantof > 30)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Normal", Console.ForegroundColor);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ant", Console.ForegroundColor);
                }

                Console.WriteLine("Alte numere?");
                response = Console.ReadLine();


            }while(response != "nu");

            //int.TryParse(line, out numarPantof);

        }
    }
}
