// See https://aka.ms/new-console-template for more information
using MakingClasses;

Console.WriteLine("Hello, World!");
for (int i = 0; i < 1; i++)
{
    Die Die1 = new Die(), Die2 = new Die();
    Die1.RollDie();
    Console.WriteLine(Die1);

    Die1.DrawRoll();
    Console.WriteLine(Die2.Roll);
    Die2.DrawRoll();
    if (Die1 == Die2)
    {
        Console.WriteLine(Die1 + " is the same as " + Die2);
    }
}

//Die1.Roll = 5;