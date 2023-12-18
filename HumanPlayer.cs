namespace ShootingDice;

// TODO: Complete this class

// A player the prompts the user to enter a number for a roll
public class HumanPlayer : Player
{
        public override int Roll()
    {
        // Return a random number between 1 and DiceSize
        Console.WriteLine($"Enter a number for {this.Name}'s big roll");
        string userInput = Console.ReadLine();

        return Convert.ToInt32(userInput);
    }
}