namespace ShootingDice;

public class Player
{
    public string Name { get; set; }
    public int DiceSize { get; set; } = 6;

    public virtual int Roll()
    {
        // Return a random number between 1 and DiceSize
        return new Random().Next(DiceSize) + 1;
    }

    public virtual void Play(Player other)
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

        if (myRoll > otherRoll && other.GetType().ToString() != "ShootingDice.SoreLoserPlayer")
        {
            Console.WriteLine($"{Name} Wins!");
        }
        else if (myRoll < otherRoll)
        {
            Console.WriteLine($"{other.Name} Wins!");
        }
        else if (myRoll == otherRoll)
        {
            // if the rolls are equal it's a tie
            Console.WriteLine("It's a tie");
        }
    }
}