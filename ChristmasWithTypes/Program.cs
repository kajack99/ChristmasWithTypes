using System;

namespace ChristmasWithTypes
{
    class Program
    {
        private const string V = "no plague";
        private const string W = "snow";
        private const string Y = "and win lottery";

        static void Main(string[] args)
        {
            var xmas = new Christmas();

            var xmasDay = Christmas.Day.Thursday;

            //DONE set Santa's name to Kris Kringle
            xmas.Santa = "Kris Kringle";

            //DONE Insert 3 presents you would like for xmas.  They must be strings
            xmas.Presents =  new string[3]{ V, W, Y }; 

            //DONE Set the TreeHeight to 10
            xmas.TreeHeight = 10;

            Console.WriteLine($"This year christmas falls on {xmasDay} \n");
            Console.WriteLine($"Our tree will be {xmas.TreeHeight} feet high \n");
            Console.WriteLine("Here are the presents we would like:");

            foreach (var present in xmas.Presents)
            {
                Console.WriteLine($"    {present}");
            }

            Console.WriteLine($"\n We like to call Santa, {xmas.Santa}");
        }
    }
}
