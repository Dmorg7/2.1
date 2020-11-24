using System;

namespace _2._1
{
    // author: Benjamin Daniel Morgan
    // date: 11/12/12

    class Program
    {
        static void Main()
        {
            string input;
            int Teams, Players, Size, Remainder;

            Console.Clear();
            Console.WriteLine("How many players are there?");
            input = Console.ReadLine();
            Players = Convert.ToInt32(input);

            Console.WriteLine("How many players are in each team?");
            input = Console.ReadLine();
            Size = Convert.ToInt32(input);

            Teams = Players / Size;
            Remainder = Players % Size;

            Console.WriteLine("There are\t"+ Teams +"\tteams and there are\t"+ Remainder +"\tplayer(s) left over!");
        }
    }
}
