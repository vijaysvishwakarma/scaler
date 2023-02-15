using Model;


namespace Controller
{
    public class GameController
    {
        public void Undo(Game game)
        {
            game.Undo();
        }

        public Game CreateGame(int dimension, List<Player> players)
        {
            try{
                return new Game.Builder()
                        .SetDimension(dimension)
                        .SetPlayers(players)
                        .Build();

            } catch(Exception ex)
            {
                Console.WriteLine("Caught an exception", ex.StackTrace);
                
            }
            return null;
        }

        public GameStatus GetGameStatus(Game game)
        {
            return game.GameStatus;
        }

        public void ExecuteNextMove(Game game)
        {
            game.MakeNextMove();
        }

        public Player GetWinner(Game game)
        {
            return game.Winner;
        }

        public void DisplayBoard(Game game)
        {
            game.DisplayBoard();
        }
    }
}