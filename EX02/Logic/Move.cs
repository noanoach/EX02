using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02.Logic
{
    internal class Move
    {
        private int m_Row;
        private int m_Col;
        private eMoveResult m_Result;

        /// <summary>
        /// Creates a move with row and column values.
        /// </summary>
        public Move(int i_Row, int i_Col)
        {
            m_Row = i_Row;
            m_Col = i_Col;

            m_Result = eMoveResult.Success;
        }

        /// <summary>
        /// Creates a special move result.
        /// </summary>
        public Move(eMoveResult i_Result)
        {
            m_Result = i_Result;
        }

        /// <summary>
        /// Returns the selected row.
        /// </summary>
        public int Row
        {
            get
            {
                return m_Row;
            }
        }

        /// <summary>
        /// Returns the selected column.
        /// </summary>
        public int Col
        {
            get
            {
                return m_Col;
            }
        }

        /// <summary>
        /// Returns the move result.
        /// </summary>
        public eMoveResult Result
        {
            get
            {
                return m_Result;
            }
        }
    }
}
