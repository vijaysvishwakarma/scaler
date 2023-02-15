using Model;
using System.Collections;
using System.Collections.Generic;

namespace Strategy.GameWiningStrategy
{
    public class EfficientGameWiningStrategy : IGameWiningStrategy
    {
        List<Dictionary<char, int>> rowSymboCount = new List<Dictionary<char, int>>();
        List<Dictionary<char, int>> colSymboCount = new List<Dictionary<char, int>>();

        Dictionary<char, int> topLeftDiagSymbolCount = new Dictionary<char, int>();
        Dictionary<char, int> bottomLeftDiagSymbolCount = new Dictionary<char, int>();
        int dimension;
        public EfficientGameWiningStrategy(int dimension)
        {
            this.dimension = dimension;
            for (int i = 0; i < dimension; i++)
            {
                rowSymboCount.Add(new Dictionary<char, int>());
                colSymboCount.Add(new Dictionary<char, int>());
            }
        }
        public bool isTopLeftDiagonal(int row, int col)
        {
            return row == col;
        }

        public bool isBottomLeftDiagonal(int row, int col)
        {
            return row + col == this.dimension - 1;
        }
        
        public bool UpdateBoardAndCheckWinner(Board board,
         Player lastPlayer,
         Move lastMove)
        {
            char symbol = lastPlayer.Symbol;
            int row = lastMove.Cell.Row;
            int col = lastMove.Cell.Col;

            if (rowSymboCount[row].TryGetValue(symbol, out int value))
            {
                rowSymboCount[row][symbol] = value + 1;
            }else{
                rowSymboCount[row].Add(symbol, value + 1);
            }

            
            if (colSymboCount[col].TryGetValue(symbol, out value))
            {
                colSymboCount[col][symbol] = value + 1;
            }else{
                colSymboCount[col].Add(symbol, value +1);
            }

            if (isTopLeftDiagonal(row, col))
            {
                if (topLeftDiagSymbolCount.TryGetValue(symbol, out value))
                {
                    topLeftDiagSymbolCount[symbol] = value + 1;
                }else{
                    topLeftDiagSymbolCount.Add(symbol, value + 1);
                }
            }

            if (isBottomLeftDiagonal(row, col))
            {
                if (bottomLeftDiagSymbolCount.TryGetValue(symbol, out value))
                {
                    bottomLeftDiagSymbolCount[symbol] = value + 1;
                }else{
                    bottomLeftDiagSymbolCount.Add(symbol, value + 1);
                }
            }
            return CheckWinnerLogic(row, col, symbol);
        }

        private bool CheckWinnerLogic(int row, int col, char symbol)
        {
            if (rowSymboCount[row].TryGetValue(symbol, out int dictValue) && dictValue == dimension)
            {
                return true;
            }

            if (colSymboCount[row].TryGetValue(symbol, out dictValue) && dictValue == dimension)
            {
                return true;
            }

            if (isTopLeftDiagonal(row, col))
            {
                if (topLeftDiagSymbolCount.TryGetValue(symbol, out dictValue) && dictValue == dimension)
                {
                    return true;
                }
            }

            if (isBottomLeftDiagonal(row, col))
            {
                if (bottomLeftDiagSymbolCount.TryGetValue(symbol, out dictValue) && dictValue == dimension)
                {
                    return true;
                }
            }

            return false;
        }
    }
}