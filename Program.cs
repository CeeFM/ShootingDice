using ShootingDice;
// create player 1 as a new SmackTalkingPlayer, with name Bob and Taunt KING KONG AIN'T GOT SHIT ON ME
SmackTalkingPlayer player1 = new SmackTalkingPlayer();
player1.Name = "Bob";
player1.Taunt = "KING KONG AIN'T GOT SHIT ON ME";
//Player 2 just a regular ol player named Sue, everythin else standard issue Player stuff
Player player2 = new Player();
player2.Name = "Sue";
//Player 2 and Player 1 play a game of dice
player2.Play(player1);

Console.WriteLine("-------------------");
//New player created, named Wilma
Player player3 = new Player();
player3.Name = "Wilma";
//Wilma plays against Sue in a game of dice
player3.Play(player2);

Console.WriteLine("-------------------");
//create an overpowered player whose dice for some reason go all the up to 20
Player large = new LargeDicePlayer();
large.Name = "Bigun Rollsalot";
//player 1 faces their certain doom as they play against a player with dice that are 3x as valuable as theirs in terms of score
player1.Play(large);

Console.WriteLine("-------------------");
//create list of players
List<Player> players = new List<Player>() {
    player1, player2, player3, large
};

PlayMany(players);

static void PlayMany(List<Player> players)
{
    Console.WriteLine();
    Console.WriteLine("Let's play a bunch of times, shall we?");

    // We "order" the players by a random number
    // This has the effect of shuffling them randomly
    Random randomNumberGenerator = new Random();
    List<Player> shuffledPlayers = players.OrderBy(p => randomNumberGenerator.Next()).ToList();

    // We are going to match players against each other
    // This means we need an even number of players
    int maxIndex = shuffledPlayers.Count;
    if (maxIndex % 2 != 0)
    {
        maxIndex = maxIndex - 1;
    }

    // Loop over the players 2 at a time
    for (int i = 0; i < maxIndex; i += 2)
    {
        Console.WriteLine("-------------------");

        // Make adjacent players play noe another
        Player player1 = shuffledPlayers[i];
        Player player2 = shuffledPlayers[i + 1];
        player1.Play(player2);
    }
}