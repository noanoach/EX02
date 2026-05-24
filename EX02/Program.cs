using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EX02.Logic;

namespace EX02
{
    internal class Program
    {
        /// <summary>
        /// Entry point of the application.
        /// Starts the game manager.
        /// </summary>
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();

            gameManager.Run();
        }
    }
}
