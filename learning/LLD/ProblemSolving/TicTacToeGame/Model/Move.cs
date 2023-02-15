namespace Model
{
    public class Move
    {
        public Cell Cell{get;set;}
        public Player Player{get;set;}
        public Move(Cell cell, Player player)
        {
            this.Cell = cell;
            this.Player = player;
        }
    }
}