namespace Model
{
    public class Board{
    private List<List<Cell>> _board;
    public int Dimension{get;set;}
    public Board(int dimension)
    {
        this.Dimension =dimension;
       
        _board  = new List<List<Cell>>(dimension);
        for(var i = 0; i< dimension; i++)
        { 
            var cellElements = new List<Cell>();
            for(var j = 0; j < dimension; j++)
            {
                cellElements.Add(new Cell(i, j));    
            }
            this._board.Insert(i, cellElements);
        }

    }    
    public List<List<Cell>> GameBoard
    {
        get{
            return _board;
        }
        set{
           _board = value;     
        }
    }

    public void Display()
    {
        for(int i = 0; i < _board.Count; i++)
        {
            for(int j = 0; j < _board.Count; j++)
            {
                if (_board[i][j].CellState.Equals(CellState.EMPTY))
                {
                    Console.Write("| |");
                }else{
                    Console.Write("| "+ _board[i][j].Player.Symbol +" |");     
                }
            }
            Console.WriteLine();
        }
    }

    }
}