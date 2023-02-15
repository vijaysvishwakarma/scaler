using Strategy.BotPlayingStrategy;
using Factory;
namespace Model
{
    public class Bot : Player
    {
        public BotDifficultyLevel botDifficultyLevel { get; set; }
        private IBotPlayingStrategy botPlayingStrategy;

        public Bot(char symbol, string name, BotDifficultyLevel botDifficultyLevel) : base(name, symbol, PlayerType.EASY_BOT)
        {
            this.botDifficultyLevel = botDifficultyLevel;
            this.botPlayingStrategy = BotPlayingStrategyFactory.GetPlayingStrategyForDifficultyLevel(BotDifficultyLevel.EASY);
        }

        public BotDifficultyLevel BotDifficultyLevel
        {
            get { return botDifficultyLevel; }
            set { botDifficultyLevel = value; }
        }
        public IBotPlayingStrategy BotPlayingStrategy
        {
            get
            {
                return botPlayingStrategy;
            }
            set
            {
                botPlayingStrategy = value;
            }
        }

        public Move DecideMove(Board board)
        {
            return botPlayingStrategy.DecideMove(this, board);
        }
    }

}