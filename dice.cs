using System;
namespace dice_problem {
    public class Dice {
        private int sides;
        private int rolls;


        public Dice(int rolls, int sides) {
            this.sides = sides;
            this.rolls = rolls;
        }
        //does a new roll and returns the number given from the roll
        public int newroll() {
            Random rand = new Random();
            int rolled = rand.Next(sides) + 1;
            return rolled;
        }
        //I really need to clean up the way I went about showing the simulation and total, it is very messy (but it does the job for now)
        public void DoSimulation() {
            int total = 0;
            for (int x = 1; x <= rolls; x++) {
                int rollednumber = newroll();
                Console.WriteLine("Roll {0}: {1}", x, rollednumber);
                total = total + rollednumber;

            }
            Console.WriteLine("Total: {0}", total);
        }
    }
}