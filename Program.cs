static int Game()
{
    Console.WriteLine("\n\nChoisissez :");
    Console.WriteLine("Pierre (1) Papier (2) Ciseaux (3)\n");

    int input = Convert.ToInt32(Console.ReadLine());

    Random rand = new Random();
    int randomPick = rand.Next(4);

    if (input != 1 && input != 2 && input != 3)
    {
        return 2;
    }

    if (randomPick == 1)
    {

        if (input == 2)
        {
            return 1;

        }
        else if (input == 1)
        {
            return 0;
        }
        else if (input == 3)
        {
            return -1;

        }

    }

    if (randomPick == 2)
    {
        if (input == 3)
        {
            return 1;
        }
        else if (input == 2)
        {
            return 0;
        }
        else if (input == 1)
        {
            return -1;
        }

    }

    if (randomPick == 3)
    {
        if (input == 1)
        {
            return 1;
        }
        else if (input == 3)
        {
            return 0;
        }
        else if (input == 2)
        {
            return -1;
        }
    }

    return 0; // default output

}


int cpuScore = 0;
int userScore = 0;

while (true)
{

    Console.WriteLine($"CPU = {cpuScore} VOUS = {userScore}");

    int result = Game();

    if (result == -1)
    {
        Console.WriteLine("PERDU !");
        cpuScore += 1;
    }
    else if (result == 1)
    {
        Console.WriteLine("GAGNE !");
        userScore += 1;

    }
    else if (result == 0)
    {
        Console.WriteLine("EGALITE !");

    }
    else
    {
        Console.WriteLine("erreur");

    }

}