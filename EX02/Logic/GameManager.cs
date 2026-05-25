using EX02.Players;
using EX02.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EX02.Logic
{
    internal class GameManager
    {
        private Board m_Board;
        private Player m_Player1;
        private Player m_Player2;
        private Player m_CurrentPlayer;
        private ConsoleUI m_UI;


        /// <summary>
        /// Runs the entire game flow.
        /// </summary>
        public void Run()
        {

            bool playAgain = true;

            InitializeGame();

            while (playAgain)
            {
                PlayRound();

                m_UI.PrintScore(m_Player1, m_Player2);

                playAgain = m_UI.AskPlayAgain();

                if (playAgain)
                {
                    StartNewRound();
                }
            }
        }

        /// <summary>
        /// Initializes players and board settings.
        /// </summary>
        private void InitializeGame()
        {
            int boardSize;
            bool isAgainstComputer;

            m_UI = new ConsoleUI();

            m_UI.PrintWelcome();

            boardSize = m_UI.ReadBoardSize();

            isAgainstComputer = m_UI.ReadIsAgainstComputer();

            m_Player1 = new Player("Player 1", eCellValue.X);

            if (isAgainstComputer)
            {
                m_Player2 = new ComputerPlayer("Player 2", eCellValue.O);
            }
            else
            {
                m_Player2 = new Player("Player 2", eCellValue.O);
            }

            m_Board = new Board(boardSize);

            m_CurrentPlayer = m_Player1;
        }

        /// <summary>
        /// Runs one round of the game.
        /// </summary>
        private void PlayRound()
        {
            bool roundOver = false;
            bool validMove;
            Move move;

            while (!roundOver)
            {
                m_UI.PrintBoard(m_Board);

                validMove = false;

                while (!validMove)
                {
                    if (m_CurrentPlayer is ComputerPlayer)
                    {
                        Console.WriteLine("Computer is thinking...");
                        Thread.Sleep(1000);

                        move = ((ComputerPlayer)m_CurrentPlayer).ChooseMove(m_Board);
                    }
                    else
                    {
                        move = m_UI.ReadMove(m_CurrentPlayer);
                    }

                    validMove = PlayTurn(move);

                    if (!validMove)
                    {
                        m_UI.PrintCellOutOfRangeMessage();
                    }
                }

                roundOver = IsRoundOver();

                if (!roundOver)
                {
                    SwitchTurn();
                }
            }

            m_UI.PrintBoard(m_Board);

            HandleRoundEnd();
        }

        /// <summary>
        /// Handles a single player turn.
        /// </summary>
        private bool PlayTurn(Move i_Move)
        {
            return m_Board.PlaceSymbol(i_Move.Row, i_Move.Col, m_CurrentPlayer.Symbol);
        }

        /// <summary>
        /// Switches the turn to the other player.
        /// </summary>
        private void SwitchTurn()
        {
            if (m_CurrentPlayer == m_Player1)
            {
                m_CurrentPlayer = m_Player2;
            }
            else
            {
                m_CurrentPlayer = m_Player1;
            }
        }

        /// <summary>
        /// Checks if the current round ended.
        /// </summary>
        private bool IsRoundOver()
        {
            return m_Board.HasLosingSequence(m_CurrentPlayer.Symbol) || m_Board.IsFull();
        }

        /// <summary>
        /// Updates scores and handles end of round.
        /// </summary>
        private void HandleRoundEnd()
        {
            if (m_Board.HasLosingSequence(m_CurrentPlayer.Symbol))
            {
                if (m_CurrentPlayer == m_Player1)
                {
                    m_Player2.AddPoint();
                    m_UI.PrintWinner(m_Player2);
                }
                else
                {
                    m_Player1.AddPoint();
                    m_UI.PrintWinner(m_Player1);
                }
            }
            else
            {
                m_UI.PrintTie();
            }
        }

        /// <summary>
        /// Starts a new round with a cleared board.
        /// </summary>
        private void StartNewRound()
        {
            m_Board.Clear();
            m_CurrentPlayer = m_Player1;
        }
    }
}
