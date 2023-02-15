namespace Model{
    public class Player{
        public PlayerType Type{get;set;}
        public string Name{get;set;}
        public char Symbol{get;set;}

        public Player(string name, char symbol, PlayerType playerType)
        {
            this.Name = name;
            this.Symbol = symbol;
            this.Type = playerType;
        }
        public virtual Move DecideMode(Board board)
        {
            Console.WriteLine("Please tell the row: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please tell the col: ");
           int col = Convert.ToInt32(Console.ReadLine());
            return new Move(new Cell(row, col), this);
        }
    }
}