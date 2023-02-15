using Model;

namespace Strategy.GameWiningStrategy
{
    public interface IGameWiningStrategy
    {
        bool UpdateBoardAndCheckWinner(Board board, Player lastPlayer, Move lastMove);
    }
}