using EX02.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX02.Players
{
    internal class Player
    {
        private string m_Name;
        private eCellValue m_Symbol;
        private int m_Score;

        /// <summary>
        /// Creates a new player.
        /// </summary>
        public Player(string i_Name, eCellValue i_Symbol)
        {
            m_Name = i_Name;
            m_Symbol = i_Symbol;
            m_Score = 0;
        }

        /// <summary>
        /// Returns the player's name.
        /// </summary>
        public string Name
        {
            get
            {
                return m_Name;
            }
        }

        /// <summary>
        /// Returns the player's symbol.
        /// </summary>
        public eCellValue Symbol
        {
            get
            {
                return m_Symbol;
            }
        }

        /// <summary>
        /// Returns the player's score.
        /// </summary>
        public int Score
        {
            get
            {
                return m_Score;
            }
        }

        /// <summary>
        /// Adds one point to the player's score.
        /// </summary>
        public void AddPoint()
        {
            m_Score++;
        }
    }
}
