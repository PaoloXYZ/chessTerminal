using System;

namespace Chess
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tThe names of the pieces are from the FEN notation");
            Play Game = new Play();
            Game.PiecesOnStartPosition();
            Game.DisplayBoard();
            
        }
    }
}
