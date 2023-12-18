namespace ShootingDice;
// A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
public class CreativeSmackTalkingPlayer : Player
{
    public override int Roll()
    {
        List<string> taunts = ["you're a loser, a big loser, big big loser", "man i can throw dice with my toes better than you can with your hands", "good lord you're bad at this!", "honestly how are you so bad at a game of a chance", "even if i lose I'm better at you than this!", "you lame you weak you bad you suck", "daaaaaaaaamnnnnnnnnnnnnnn you should practice"];
        int ranNum = new Random().Next(taunts.Count);
        // Return a random number between 1 and DiceSize
        Console.WriteLine($"{this.Name} shouts '{taunts[ranNum]}' as they roll the dice");
        return new Random().Next(DiceSize) + 1;
    }
}