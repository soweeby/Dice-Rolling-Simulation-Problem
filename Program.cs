using System;
using System.Linq;

namespace dice_problem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please input dice configuration string");
            //reads user input for the dice notation (adn, "a" being # of sides of dice, "n" being the # of sides on the dice)
            string die = Console.ReadLine();
            //splits up the dice notation into readable parts (EX: 3d12 reads as rolling a 12 sided dice 3 times)
            string[] components = die.Split("d");
            //checks first part of dice notation for any letters
            bool part1wrong = components[0].Any(x => char.IsLetter(x));
            //checks second part of dice notation for any letters
            bool part2wrong = components[1].Any(x => char.IsLetter(x));
            
            //if either part of the parsed dice notation contains any letters, then it is invalid and the user is prompted to try again
            if (part1wrong == true || part2wrong == true) {
                Console.WriteLine("Bad String, try again");
            }
            else {
            //initializes a new dice object according to the # of rolls to be done and # of sides it has
            Dice die_components = new Dice(Convert.ToInt32(components[0]), Convert.ToInt32(components[1]));
            //shows the results of each roll and the total number of all the roll values combined
            die_components.DoSimulation();
            
            }
            
            
            
        }
    }
}
