using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02.Logic
{
    internal enum eCellValue
    {
        Empty,
        X,
        O
    }
    internal class Board
    {
        private eCellValue[,] m_Cells;
        private int m_Size;

        
        /// Creates a square board with the given size.
        public Board(int i_Size)
        {
            m_Size = i_Size;

            m_Cells = new eCellValue[m_Size, m_Size];

            Clear();


        }

        /// Returns the board size.
        public int Size
        {
            get
            {
                return m_Size;
            }
        }

        
        /// Checks if a specific cell is empty.
        public bool IsCellEmpty(int i_Row, int i_Col)
        {
            return m_Cells[i_Row, i_Col] == eCellValue.Empty;
        }


        /// Places a symbol inside the requested cell.
        public void PlaceSymbol(int i_Row, int i_Col, eCellValue i_Symbol)

        {
            m_Cells[i_Row, i_Col] = i_Symbol;
        }


        /// Returns the symbol stored in a cell.
        public eCellValue GetCell(int i_Row, int i_Col)
        {
            return m_Cells[i_Row, i_Col];
        }


        /// Checks whether the board is completely full.
        public bool IsFull()
        {
            for (int row = 0; row < m_Size; row++)
            {
                for (int col = 0; col < m_Size; col++)
                {
                    if (m_Cells[row, col] == eCellValue.Empty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

     
        /// Checks if the given symbol created a losing sequence.
        public bool HasLosingSequence(char i_Symbol)
        {

        }

       
        /// Clears all cells for a new round.
        public void Clear()
        {
        }
    }
}
