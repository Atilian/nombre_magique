

namespace nombre_magique
{
    class program
    {
        

        static void Main(String[] args)
        {
            game(0, 1, 4);
        }


        static void game(int range1, int range2, int nombreVie)
        {
            int magiqueNumber = new Random().Next(range1, range2);

            const string title = "******************\n" +
                                 "* Nombre magique *\n" +
                                 "******************\n";
            
            Console.WriteLine(title);

            while (nombreVie > 0)
            {
                Console.Write("Choose a number beetwen ({0} - {1}) : ", range1, range2);

                int.TryParse(Console.ReadLine(), out var choiceNumber);

                if (magiqueNumber == choiceNumber)   
                {
                    Console.WriteLine("You win the number magique is : {0}", magiqueNumber);
                    return;
                }
                else
                {
                    if (magiqueNumber > choiceNumber)
                    {
                        Console.WriteLine("More\n");
                    }
                    else
                    {
                        Console.WriteLine("Less\n");
                    }
                }

                nombreVie--;
            }

            Console.WriteLine("You loose the number magique is : {0}", magiqueNumber);
        }
    }
}