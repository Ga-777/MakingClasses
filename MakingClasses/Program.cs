// See https://aka.ms/new-console-template for more information
using MakingClasses;

Console.WriteLine("Press Enter to Roll!");
for (int i = 0; i < 900000000; i++)
{
    if (i <= 90)
    {
        Console.ReadLine();
    }
    
    


    
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
        Console.WriteLine("Die1 is the same as Die2.");
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
    
    }
    int sumofSeven = Die1.Roll + Die2.Roll;
    if (sumofSeven == 7)
    {
        Console.WriteLine("Both Dies add up to 7");
    }

    


    
}

//Die1.Roll = 5;