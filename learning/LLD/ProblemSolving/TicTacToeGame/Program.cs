// See https://aka.ms/new-console-template for more information
using Controller;
using Model;

Console.WriteLine("Tic Tac Toe Game!");

Console.WriteLine("Please enter the dimension");
var dimension = Convert.ToInt32(Console.ReadLine());

GameController gameController = new GameController();

Console.WriteLine("Will there by any bot in the game? Y/N");
string isBotString = Console.ReadLine();

List<Player> players = new List<Player>();

int toIterate = dimension -1;

if (isBotString.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
{
    toIterate = dimension - 2;
}

for(int i = 0; i < toIterate; i++)
{
    Console.WriteLine("What is the name of the player number : "+i);
    string playerName = Console.ReadLine();

    Console.WriteLine("What is the symbol of the player number : "+ i);
    string playerSymbol = Console.ReadLine();

    players.Add(new Player(playerName, playerSymbol[0], PlayerType.HUMAN));

}

if (isBotString.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
{
    Console.WriteLine("What is the name of the bot");
    var botName = Console.ReadLine();

    Console.WriteLine("What is the character of the bot?");
    var botSymbol = Console.ReadLine();

    players.Add(new Player(botName, botSymbol[0], PlayerType.EASY_BOT));
}

Game game = gameController.CreateGame(dimension, players);

while(gameController.GetGameStatus(game).Equals(GameStatus.IN_PROGRESS))
{
    Console.WriteLine("This is the current board");
    gameController.DisplayBoard(game);

    Console.WriteLine("Does anyone want to undo? Y/N");
    var undoInput = Console.ReadLine();
    if (undoInput.Equals("Y", StringComparison.CurrentCultureIgnoreCase))
    {
        game.Undo();
    }else{
        game.MakeNextMove();
    }
}

Console.WriteLine("Game has ended, result is "+ game.GameStatus.ToString());
if (game.GameStatus.Equals(GameStatus.ENDED))
{
    Console.WriteLine("Winner is " + game.Winner.Name);
}