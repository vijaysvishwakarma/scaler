using Model;

namespace Strategy.BotPlayingStrategy
{
    public interface IBotPlayingStrategy
    {
        Move DecideMove(Player player, Board board);
    }
}