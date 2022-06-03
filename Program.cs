using System;


int score1 = 0;
int score2 = 0;


Main();

void Main()
{
    Console.WriteLine("Rock Paper Scissors Game");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine($"| Player 1: {score1} | Computer: {score2} |");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine("What would you like to throw?");
    Console.WriteLine("1) Rock");
    Console.WriteLine("2) Paper");
    Console.WriteLine("3) Scissors");
    Console.WriteLine("Press 'enter' to exit");

    PlayerChoice();
    ComputerChoice();
}

void PlayerChoice()
{
    int Selection = int.Parse(Console.ReadLine());
    Console.WriteLine($"You Chose {Selection}");
}

void ComputerChoice()
{
    int CPUselection = GetRandomNumber();
    Console.WriteLine($"Computer chose {CPUselection}");
    
    //Function to get a random number 
    static int GetRandomNumber() 
    {
        Random r = new Random();
        int genRand= r.Next(1,4);
        return genRand;
   }
}

