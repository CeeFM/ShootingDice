using System.Linq.Expressions;

namespace ShootingDice;
// TODO: Complete this class

// A Player that throws an exception when they lose to the other player
// Where might you catch this exception????
public class SoreLoserPlayer : Player
{
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