using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EX02.Logic;

namespace EX02.Players
{
    internal class ComputerPlayer : Player
    {
        private Random m_Random;

        /// <summary>
        /// Creates a computer-controlled player.
        /// </summary>
        public ComputerPlayer(string i_Name, char i_Symbol)
            : base(i_Name, i_Symbol)
        {
            m_Random = new Random();
        }

        /// <summary>
        /// Selects a random valid move.
        /// </summary>
        public Move ChooseMove(Board i_Board)
        {
            int row;
            int col;

            do
            {
                row = m_Random.Next(i_Board.Size);
                col = m_Random.Next(i_Board.Size);
            }
            while (!i_Board.IsCellEmpty(row, col));

            return new Move(row, col);
        }
    }
}
