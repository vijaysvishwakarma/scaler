using Model;
using Strategy.BotPlayingStrategy;
namespace Factory
{
    public class BotPlayingStrategyFactory
    {
        public static IBotPlayingStrategy GetPlayingStrategyForDifficultyLevel(BotDifficultyLevel botDifficultyLevel)
        {
            return new RandomBotPlayingStrategy();
            /*
            switch(strategy){
                case : EASY
                    return EasyBotPlayingStrategy();
            }
            */
        }
    }
}