//James Lear
//Mission 2 assignment - Dice Rolling!

using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args) //first method that's run
        {
            //first declare all variables that will be used in this code
            int dice1;
            int dice2;
            int iGuessNum;
            int totalRoll;
            string astriq = "";
            decimal[] percentage = new decimal[11];
            string[] output = new string[11];
            decimal[] aDiceRolls = new decimal[11];

            //set up the randomizer class to generate random numbers later on
            Random roll = new Random();

            //display the intro message
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");
            //recieve the number input from the user for dice rolls
            iGuessNum = int.Parse(Console.ReadLine());
            
            //loop through the number of requested rolls
            for (int i = 0; i < iGuessNum; i++)
            {
                //generate random dice rolls, sum them, and assign them to their respective positions in the array
                dice1 = roll.Next(6) + 1;
                dice2 = roll.Next(6) + 1;
                totalRoll = dice1 + dice2;
                aDiceRolls[(totalRoll -2)]++;
            }

            //loop through the dice roll array to create another array for percentages
            for (int i = 0; i < 11; i++)
            {
                //calculate the percentage for each dice roll
                percentage[i] = (int)Math.Round(((aDiceRolls[i] / iGuessNum) * 100));

                //loop through each percentage point and add a "*" for each percentage
                for (int j = 0; j < percentage[i]; j++)
                {
                    astriq += "*";
                }

                //assign the * to their respective positions
                output[i] = astriq;
                astriq = "";

                //display the formatted results
                Console.WriteLine((i+2) + ": "+output[i]);
            }           
        }
    }
}
