using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EX02.Logic;
using EX02.Players;

namespace EX02.UI
{
    internal class ConsoleUI
    {
        /// <summary>
        /// Prints the welcome message.
        /// </summary>
        public void PrintWelcome()
        {
        }

        /// <summary>
        /// Reads and validates board size input.
        /// </summary>
        public int ReadBoardSize()
        {
        }

        /// <summary>
        /// Asks whether the game is against another player or computer.
        /// </summary>
        public bool ReadIsAgainstComputer()
        {
        }

        /// <summary>
        /// Reads a move from the current player.
        /// </summary>
        public Move ReadMove(Player i_Player)
        {
        }

        /// <summary>
        /// Prints the current board state.
        /// </summary>
        public void PrintBoard(Board i_Board)
        {
        }

        /// <summary>
        /// Prints invalid input message.
        /// </summary>
        public void PrintInvalidInputMessage()
        {
        }

        /// <summary>
        /// Prints message when selected cell is occupied.
        /// </summary>
        public void PrintCellTakenMessage()
        {
        }

        /// <summary>
        /// Prints the winner of the round.
        /// </summary>
        public void PrintWinner(Player i_Winner)
        {
        }

        /// <summary>
        /// Prints tie message.
        /// </summary>
        public void PrintTie()
        {
        }

        /// <summary>
        /// Prints the current scores.
        /// </summary>
        public void PrintScore(Player i_Player1, Player i_Player2)
        {
        }

        /// <summary>
        /// Asks if players want another round.
        /// </summary>
        public bool AskPlayAgain()
        {
        }
    }
}