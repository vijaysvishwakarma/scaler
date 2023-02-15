using Strategy.GameWiningStrategy;
namespace Model
{
    public class Game
    {
        public Board Board { get; set; }
        public List<Player> Players { get; set; }
        public List<Move> Moves { get; set; }
        public GameStatus GameStatus { get; set; }
        public IGameWiningStrategy GameWiningStrategy { get; set; }

        private int nextPlayerIndex;
        public Player Winner { get; set; }

        private Game()
        {

        }

        // TODO: complete the undo
        public void Undo()
        {
            if (this.Moves.Count > 0)
            {
                nextPlayerIndex--;
                nextPlayerIndex %= Players.Count;
                Console.WriteLine("Before undo ->" + this.Moves.Count);
                var lastMove = this.Moves.Last();
                var row = lastMove.Cell.Row;
                var col = lastMove.Cell.Col;
                Board.GameBoard[row][col].CellState = CellState.EMPTY;
                Board.GameBoard[row][col].Player = null;
                this.Moves.Remove(this.Moves.Last());
                Console.WriteLine("After undo ->" + this.Moves.Count);
            }
            else
            {
                Console.WriteLine("Undo can not be done since there is no move present");
            }
        }

        public void DisplayBoard()
        {
            this.Board.Display();
        }

        public void MakeNextMove()
        {
            Player toMovePlayer = Players[nextPlayerIndex];
            Console.WriteLine(toMovePlayer.Name + "'s move");
            Move move = toMovePlayer.DecideMode(this.Board);

            // TODO : validate move
            int row = move.Cell.Row;
            int col = move.Cell.Col;
            if (Board.GameBoard[row][col].CellState == CellState.EMPTY)
            {
                Console.WriteLine("Move happened : row -> " + row + ", col -> " + col);

                Board.GameBoard[row][col].CellState = CellState.FILLED;
                Board.GameBoard[row][col].Player = toMovePlayer;

                Move playerMove = new Move(Board.GameBoard[row][col], toMovePlayer);

                this.Moves.Add(playerMove);

                if (GameWiningStrategy.UpdateBoardAndCheckWinner(Board, toMovePlayer, playerMove))
                {
                    GameStatus = GameStatus.ENDED;
                    Winner = toMovePlayer;
                }
                nextPlayerIndex++;
                nextPlayerIndex %= Players.Count;
            }else{
                Console.WriteLine("Invalid Move happened : row -> " + row + ", col -> " + col);
            }
        }

        public class Builder
        {
            private int dimension;
            private List<Player> players;

            public Builder SetDimension(int dimension)
            {
                this.dimension = dimension;
                return this;
            }

            public Builder SetPlayers(List<Player> players)
            {
                this.players = players;
                return this;
            }

            private bool Valid()
            {
                if (this.dimension < 3)
                {
                    throw new InvalidGameCreationParametersException("Dimension should greater than equal to 3");
                }

                if (this.players.Count != this.dimension - 1)
                {
                    throw new InvalidGameCreationParametersException("Players should be equal to Dimension -1");
                }

                // TODO
                // validate number of players
                // validate maximum number of bots = 1
                // validate at least 2 players and 1 human player
                return true;

            }

            public Game Build()
            {
                try
                {
                    Valid();
                }
                catch (Exception ex)
                {
                    throw new InvalidGameCreationParametersException("Game could not be created");
                }

                Game game = new Game();
                game.GameStatus = GameStatus.IN_PROGRESS;
                game.Players = players;
                game.Moves = new List<Move>();
                game.Board = new Board(dimension);
                game.nextPlayerIndex = 0;
                game.GameWiningStrategy = new EfficientGameWiningStrategy(dimension);
                return game;
            }
        }
    }
}
