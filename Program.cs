using System;

int Score1 = 0;
int Score2 = 0;

Main();

void Main()
{
    Console.WriteLine("Rock Paper Scissors Game");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine($"| Player 1: {Score1} | Computer: {Score2} |");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine("What would you like to throw?");
    Console.WriteLine("1) Rock");
    Console.WriteLine("2) Paper");
    Console.WriteLine("3) Scissors");
    Console.WriteLine("4) Exit");
    
    Game();

}

int PlayerChoice()
{
    int Selection = int.Parse(Console.ReadLine());
    return Selection;
}

int ComputerChoice()
{
    int CPUselection = GetRandomNumber();
    return CPUselection;
    
    //Function to get a random number 
    static int GetRandomNumber() 
    {
        Random r = new Random();
        int genRand= r.Next(1,4);
        return genRand;
   }
}

void Game()
{
    int PScore = PlayerChoice();
    int CScore = ComputerChoice();
    
    //ScoreBoard(PScore, CScore);

    while ( Score1 != 3 || PScore != 4)
    {
        if ( PScore > 0 && PScore < 4 )
        {
            ScoreBoard(PScore, CScore);
            PScore = PlayerChoice();
            CScore = ComputerChoice();
        }
        else if ( PScore == 4)
        {
            Console.WriteLine("Exiting...");
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Make a valid selection...");
            PScore = PlayerChoice();
            CScore = ComputerChoice();
            ScoreBoard(PScore, CScore);
        }
    }
}

void ScoreBoard(int Player, int Computer)
{
    if (Player == 1 && Computer == 3 || Player > Computer )
    {
        Score1++;
    }
    else if ( Player == Computer)
    {
        Console.WriteLine("Tie");
    }
    else
    {
        Score2++;
    }
    Console.WriteLine("Rock Paper Scissors Game");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine($"| Player 1: {Score1} | Computer: {Score2} |");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine("What would you like to throw next?");
    Console.WriteLine("1) Rock");
    Console.WriteLine("2) Paper");
    Console.WriteLine("3) Scissors");
    Console.WriteLine("4) exit");
}

