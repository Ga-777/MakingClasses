// See https://aka.ms/new-console-template for more information
using MakingClasses;

Console.WriteLine("Press Enter to Roll!");
for (int i = 0; i < 900000000; i++)
{
    if (i <= 90)
    {
        i = 0;
    }
    Console.ReadLine();
    Console.Clear();
    


    Die Die1 = new Die(), Die2 = new Die();
    Die1.RollDie();
    Die2.RollDie();

    Console.WriteLine(Die1);
    Die1.ColoredDie();
    Die1.DrawRoll();



    Console.WriteLine(Die2.Roll);
    Die2.ColoredDie();
    Die2.DrawRoll();
    if (Die1.Roll == Die2.Roll)
    {
        Console.WriteLine();
        Console.WriteLine("Doubles!");
        Console.WriteLine();
    }
    if (Die1.Roll > Die2.Roll)
    {
        Console.WriteLine();
        Console.WriteLine("Die1 is more then Die2.");
        Console.WriteLine();
    }
    if (Die1.Roll < Die2.Roll)
    {
        Console.WriteLine();
        Console.WriteLine("Die2 is more then Die1.");
        Console.WriteLine();
    }
    else if (Die1.Roll == 1 && Die2.Roll == 1)
    { 
      Console.WriteLine();
      Console.WriteLine("SNAKE EYES!");
      Console.WriteLine();
    }
    int sumofSeven = Die1.Roll + Die2.Roll,evenSum;

    if (sumofSeven == 7)
    {
        Console.WriteLine("Both Dies add up to 7");
    }
    evenSum = Die1.Roll + Die2.Roll;
    if (evenSum == 2)
    {
        Console.WriteLine();
        Console.WriteLine("The your 2 rolls adds up to a even number: " + evenSum);
        Console.WriteLine();
    }
    else if (evenSum == 4)
    {
        Console.WriteLine();
        Console.WriteLine("The your 2 rolls adds up to a even number: " + evenSum);
        Console.WriteLine();
    }
    else if (evenSum == 6)
    {
        Console.WriteLine();
        Console.WriteLine("The your 2 rolls adds up to a even number: " + evenSum);
        Console.WriteLine();
    }
    else if (evenSum == 8)
    {
        Console.WriteLine();
        Console.WriteLine("The your 2 rolls adds up to a even number: " + evenSum);
        Console.WriteLine();
    }
    else if (evenSum == 10)
    {
        Console.WriteLine();
        Console.WriteLine("The your 2 rolls adds up to a even number: " + evenSum);
        Console.WriteLine();
    }
    else if (evenSum == 12)
    {
        Console.WriteLine();
        Console.WriteLine("The your 2 rolls adds up to a even number: " + evenSum);
        Console.WriteLine();
    }
    double Die3, Die4, totalSum;
    Die3 = Die1.Roll;
    Die4 = Die2.Roll;
    totalSum = Die3 + Die4;
    //Console.WriteLine(totalSum / 2);
    


    
}

//Die1.Roll = 5;