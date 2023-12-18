namespace ShootingDice;
// TODO: Complete this class

// A Player who shouts a taunt every time they roll dice
public class SmackTalkingPlayer : Player
{
    public string Taunt { get; set; }

    public override int Roll()
    {
        // Return a random number between 1 and DiceSize
        Console.WriteLine($"{this.Name} shouts '{this.Taunt}' as they roll the dice");
        return new Random().Next(DiceSize) + 1;
    }
}