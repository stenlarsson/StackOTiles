using System;

namespace StackOTiles
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (StackOTilesGame game = new StackOTilesGame())
            {
                game.Run();
            }
        }
    }
}

