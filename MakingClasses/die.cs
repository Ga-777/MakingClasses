using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingClasses
{
    public class Die
    {
        private int _sides;
        private int _roll;
        private Random _generator;

        public Die()
        { 
            _generator = new Random();
            _sides = 6;
            _roll = _generator.Next(1, _sides + 1);
        
        
        
        }
        //public Die (int sides)
        //{
        //    _generator = new Random(sides);
        //    _sides = sides;
        //    _roll = _generator.Next(1, sides+1);
        //}
        //accesor props
        public int Roll 
        { 
            get { return _roll; } 
            //set { _roll = value; }
        }

        public override string ToString()
        {
            return _roll.ToString();
        }

        public void RollDie()
        {
            _roll = _generator.Next(1 , _sides + 1);
        }
        public void DrawRoll()
        {
            if (Roll == 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("-----");
                Console.WriteLine("|   |");
                Console.WriteLine("| 0 |");
                Console.WriteLine("|   |");
                Console.WriteLine("-----");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if(Roll == 2)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("-----");
                Console.WriteLine("|0  |");
                Console.WriteLine("|   |");
                Console.WriteLine("|  0|");
                Console.WriteLine("-----");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (Roll == 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("-----");
                Console.WriteLine("|0  |");
                Console.WriteLine("| 0 |");
                Console.WriteLine("|  0|");
                Console.WriteLine("-----");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (Roll == 4)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("-----");
                Console.WriteLine("|0 0|");
                Console.WriteLine("|   |");
                Console.WriteLine("|0 0|");
                Console.WriteLine("-----");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (Roll == 5)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("-----");
                Console.WriteLine("|0 0|");
                Console.WriteLine("| 0 |");
                Console.WriteLine("|0 0|");
                Console.WriteLine("-----");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (Roll == 6)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("-----");
                Console.WriteLine("|0 0|");
                Console.WriteLine("|0 0|");
                Console.WriteLine("|0 0|");
                Console.WriteLine("-----");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

    }
}
