
class Program
{


    static void Main()
    {
        int cpuScore = 0;
        int userScore = 0;

        Console.WriteLine($"CPU = {cpuScore} VOUS = {userScore}");


        Console.WriteLine("Choisissez :");
        Console.WriteLine("Pierre (1) Papier (2) Ciseaux (3)\n");

        int input = Convert.ToInt32(Console.ReadLine());

        Random rand = new Random();
        int randomPick = rand.Next(4);

        if (randomPick == input)
        {
            Console.WriteLine("EGALITE !");
            return;
        }

        if (input != 1 && input != 2 && input != 3)
        {
            Console.WriteLine("Entree incorrect");
            return;
        }

        if (randomPick == 1)
        {

            if (input == 2)
            {
                Console.WriteLine("GAGNE !");
                userScore = +1;
                return;
            }
            else
            {
                Console.WriteLine("PERDU !");
                cpuScore = +1;
                return;
            }

        }

        if (randomPick == 2)
        {
            if (input == 3)
            {
                Console.WriteLine("GAGNE !");
                userScore = +1;
                return;
            }
            else
            {
                Console.WriteLine("PERDU !");
                cpuScore = +1;
                return;
            }

        }

        if (randomPick == 3)
        {
            if (input == 1)
            {
                Console.WriteLine("GAGNE !");
                userScore = +1;
                return;
            }
            else
            {
                Console.WriteLine("PERDU !");
                cpuScore = +1;
                return;
            }

        }

    }


}

