using Mission2;
internal class Program
{
    private static void Main(string[] args)
    {
        //welcome message
        System.Console.WriteLine("Welcome to the dice throwing simulator!");

        //ask the user to enter how many times they want to roll dice
        System.Console.WriteLine("How many dice rolls would you like to simulate? ");

        //attempts to convert input to integer, saves it to numberOfRolls variable
        if (int.TryParse(System.Console.ReadLine(), out int numberOfRolls))
        {
            //create an instance of the RollDice class
            RollDice rollDice = new RollDice();

            //calls the method and passes the rolls inputed by the user, returns an array of results
            int[] results = rollDice.SimulateDiceRolls(numberOfRolls);

            //print title, description of contenet, and total rolls
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {numberOfRolls}.\n");

            //iterate through through possible dice roll outcomes
            for (int i = 2; i <= 12; i++)
            {
                //calculate the percentage that the number is rolled
                int percentage = results[i] * 100 / numberOfRolls;

                //string of asteriks for the percentage calculated
                string asterisks = new string('*', percentage);
                //prints the asteriks out
                Console.WriteLine($"{i}: {asterisks}");
            }
            //goodbye message
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
        else
        {
            //if it's not an integer it asks again for a valid input
            Console.WriteLine("Invalid input. Please enter a valid number of rolls.");
        }

    }
}