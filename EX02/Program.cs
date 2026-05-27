using EX02.Logic;

namespace EX02
{
    internal class Program
    {
        /// Entry point of the application , Starts the game manager.
        static void Main(string[] args)
        {
            GameManager gameManager = new GameManager();

            gameManager.Run();
        }
    }
}
