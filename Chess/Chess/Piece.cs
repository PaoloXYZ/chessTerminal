using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Chess
{ 
    class Piece
    {
        public Piece() { }
        public struct Pawn
        {
            //public Pawn() { }
            public char name;
            public string coordinate;
            public bool canEat;
            public string[,] canMoveTo;
        }
        public struct Rook
        {
            public char name;
            public string coordinate;
            public bool canEat;
            public string[,] canMoveTo;
        }
        public struct Knight
        {
            public char name;
            public string coordinate;
            public bool canEat;
            public string[,] canMoveTo;
        }
        public struct Bishop
        {
            public char name;
            public string coordinate;
            public bool canEat;
            public string[,] canMoveTo;
        }
        public struct Queen
        {
            public char name;
            public string coordinate;
            public bool canEat;
            public string[,] canMoveTo;
        }
        public struct King
        {
            public char name;
            public string coordinate;
            public bool canEat;
            public string[,] canMoveTo;
        }
    }
}
