using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Diagnostics;

namespace Chess
{
    class Play
    {
        /*FEN NOTATION
         * White:   King = K, Queen = Q, Bishop = B, Knight = N, Rook = R, Pawn = P.
         * Blcak:   King = k, Queen = q, Bishop = b, Knight = k, Rook = r, Pawn = p.
         */
        //Constructor no arguments
        public Play()
        {
            setTilesOnBoard();
        }
        public struct Tile
        {
            public string Coordinate;
            public Piece.Pawn p;
            public Piece.Pawn P;
            public Piece.Bishop b;
            public Piece.Bishop B;
            public Piece.Knight n;
            public Piece.Knight N;
            public Piece.Rook r;
            public Piece.Rook R;
            public Piece.King k;
            public Piece.King K;
            public Piece.Queen q;
            public Piece.Queen Q;
            public char pieceName;

        }
        public static Tile[,] Board = new Tile[8, 8];
        private void setTilesOnBoard()
        {
            Tile tile = new Tile();
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Board[x, y] = tile;
                }
            }
            //naming coordinates
            for (int x = 0; x < 8; x++)
            {
                for (char y = 'a'; y <= 'h'; y++)
                {
                    Board[x, y - 97].Coordinate = y + Convert.ToString(x + 1);
                }
            }
        }

        #region FEN 
        public void PiecesOnStartPosition()
        {
            FEN.FENposition("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR");
        }
        #endregion

        public void DisplayBoard()
        {
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("\n");
            for (int x = 0; x < 8; x++)
            {
                Console.Write("\t");
                for (int y = 0; y < 8; y++)
                {
                    Console.Write(Board[x, y].Coordinate + ": " + Board[x, y].pieceName.ToString() + "\t"); ;
                }
                Console.Write("\n");
                Console.Write("\n");
                Console.Write("\n");
                Console.Write("\n");
            }
        }
    }
}
