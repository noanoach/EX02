using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02.Logic
{
    internal class Board
    {
        private char[,] m_Cells;
        private int m_Size;

        /// <summary>
        /// Creates a square board with the given size.
        /// </summary>
        public Board(int i_Size)
        {
        }

        /// <summary>
        /// Returns the board size.
        /// </summary>
        public int Size
        {
            get
            {
            }
        }

        /// <summary>
        /// Checks if a specific cell is empty.
        /// </summary>
        public bool IsCellEmpty(int i_Row, int i_Col)
        {
        }

        /// <summary>
        /// Places a symbol inside the requested cell.
        /// </summary>
        public void PlaceSymbol(int i_Row, int i_Col, char i_Symbol)
        {
        }

        /// <summary>
        /// Returns the symbol stored in a cell.
        /// </summary>
        public char GetCell(int i_Row, int i_Col)
        {
        }

        /// <summary>
        /// Checks whether the board is completely full.
        /// </summary>
        public bool IsFull()
        {
        }

        /// <summary>
        /// Checks if the given symbol created a losing sequence.
        /// </summary>
        public bool HasLosingSequence(char i_Symbol)
        {
        }

        /// <summary>
        /// Clears all cells for a new round.
        /// </summary>
        public void Clear()
        {
        }
    }
}
