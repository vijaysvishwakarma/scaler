using Model;
namespace Strategy.BotPlayingStrategy
{
    public class RandomBotPlayingStrategy : IBotPlayingStrategy
    {
     public Move DecideMove(Player player, Board board)
     {
        for(int i = 0; i < board.GameBoard.Count; i++)
        {
            for(int j = 0; j < board.GameBoard.Count; j++)
            {
               if (board.GameBoard[i][j].CellState.Equals(CellState.EMPTY))
               {
                return new Move(new Cell(i, j), player);
               }     
            }
        }
        return null;
     }   
    }
}