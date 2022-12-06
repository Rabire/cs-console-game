

static int Game()
{
    Console.WriteLine("\nPierre (1) Papier (2) ou Ciseaux (3) ?");


    Action input;

    switch (Convert.ToInt32(Console.ReadLine()))
    {
        case 1: input = Action.Pierre; break;
        case 2: input = Action.Papier; break;
        case 3: input = Action.Ciseaux; break;
        default: return 400;
    }

    Random random = new Random();
    Action randomPick = (Action)random.Next(3);

    // if (input != 1 && input != 2 && input != 3)
    // {
    //     return 2;
    // }

    if (randomPick == Action.Pierre)
    {

        if (input == Action.Papier)
        {
            return 1;

        }
        else if (input == Action.Pierre)
        {
            return 0;
        }
        else if (input == Action.Ciseaux)
        {
            return -1;

        }

    }

    if (randomPick == Action.Papier)
    {
        if (input == Action.Ciseaux)
        {
            return 1;
        }
        else if (input == Action.Papier)
        {
            return 0;
        }
        else if (input == Action.Pierre)
        {
            return -1;
        }

    }

    if (randomPick == Action.Ciseaux)
    {
        if (input == Action.Pierre)
        {
            return 1;
        }
        else if (input == Action.Ciseaux)
        {
            return 0;
        }
        else if (input == Action.Papier)
        {
            return -1;
        }
    }

    return 0; // default output

}


int cpuScore = 0;
int playerScore = 0;

while (true)
{

    Console.WriteLine($"CPU = {cpuScore} VOUS = {playerScore}");

    int result = Game();

    if (result == -1)
    {
        Console.WriteLine("PERDU !");
        cpuScore += 1;
    }
    else if (result == 1)
    {
        Console.WriteLine("GAGNE !");
        playerScore += 1;

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

enum Action
{
    Pierre = 1,
    Papier = 2,
    Ciseaux = 3,
}