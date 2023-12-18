namespace ShootingDice;
// TODO: Complete this class

// A Player who always rolls in the upper half of their possible role and
//  who throws an exception when they lose to the other player
public class SoreLoserUpperHalfPlayer : Player
{
        public override int Roll()
       { 
        // Return a random number between 1 and DiceSize
        int ranNumHigh = new Random().Next(3,6) + 1;
        return ranNumHigh;
        }

        public override void Play(Player other)
    {
        // Call roll for "this" object and for the "other" object
    
        int myRoll = Roll();
        int otherRoll = 0;
        
        if (other.GetType().ToString() == "ShootingDice.OneHigherPlayer")
        {
           otherRoll = myRoll + 1;
        }
        else
        {
           otherRoll = other.Roll();
        }


        Console.WriteLine($"{Name} rolls a {myRoll}");
        Console.WriteLine($"{other.Name} rolls a {otherRoll}");

        if (myRoll < otherRoll)
        {
            try 
            {
                int[] myNumber = [1, 2, 3];
                Console.WriteLine(myNumber[4]);
            }
            catch (Exception)
            {
                Console.WriteLine($"Woah woah woah woah woah what the hell, {this.Name} is supposed to win and {other.Name} is supposed to lose. What the hell!!!");
            }
        }
        else if (myRoll > otherRoll && other.GetType().ToString() == "ShootingDice.SoreLoserPlayer")
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
        else if (myRoll > otherRoll && other.GetType().ToString() == "ShootingDice.SoreLoserUpperHalfPlayer")
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
        else
        {
            // if the rolls are equal it's a tie
            Console.WriteLine("It's a tie");
        }
    }        
}