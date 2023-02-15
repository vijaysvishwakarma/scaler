namespace Model {
    public class Cell
    {
        public int Row{get;set;}
        public int Col{get;set;}

        public Player Player{get;set;}

        public CellState CellState{get;set;}
        public Cell(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            this.CellState = CellState.EMPTY;
        }

    }
}