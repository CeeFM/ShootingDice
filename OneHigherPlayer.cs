namespace ShootingDice;
// TODO: Complete this class

// Override the Play method to make a Player who always roles one higher than the other player
public class OneHigherPlayer : Player
{
    public override void Play(Player other)
    {
        // Call roll for "this" object and for the "other" object

        int otherRoll = other.Roll();
        int myRoll = otherRoll + 1;

        Console.WriteLine($"{Name} rolls a {myRoll}");
        Console.WriteLine($"{other.Name} rolls a {otherRoll}");
        if (myRoll > otherRoll && other.GetType().ToString() == "ShootingDice.SoreLoserPlayer")
        {
            try 
            {
                int[] myNumber = [1, 2, 3];
                Console.WriteLine(myNumber[4]);
            }
            catch (Exception)
            {
                Console.WriteLine($"Woah woah woah woah woah what the hell, {other.Name} is supposed to win and {this.Name} is supposed to lose. What the hell!!!");
            }
        }
        else if (myRoll > otherRoll)
        {
            Console.WriteLine($"{Name} Wins!");
        }
        else if (myRoll < otherRoll)
        {
            Console.WriteLine($"{other.Name} Wins!");
        }
        else
        {
            // if the rolls are equal it's a tie
            Console.WriteLine("It's a tie");
        }
    }
}
