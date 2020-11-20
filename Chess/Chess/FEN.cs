using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    class FEN
    {
        protected internal static void FENposition(string fenPosition)
        {
            char[] charArray = fenPosition.ToCharArray();
            //removing the 7 slashes that are supposed to tell when you finished an axis
            string str = new string(charArray);
            for (int i = 0; i < 7; i++)
            {
                int ind = str.IndexOf('/');
                str = str.Remove(ind, 1);
            }
            char[] charArr = str.ToCharArray();
            System.Diagnostics.Debug.WriteLine(str);//just to make sure i'm not a clown :)
            int index = 0;
            int counter = 0;
            for (int x = 0; x < 8; x++)
            {
                for (int y = 0; y < 8; y++)
                {
                    if (index < Play.Board.Length)
                    {
                        index += charSwitch(charArr[counter], x, y);
                        y += charSwitch(charArr[counter], x, y);
                        counter++;
                        //no savememory used: 
                        /*i chose no save memory because no conclusive time saving evidence and less vars = less memory used
                         * 341,245,241,195,185,202,231
                         */
                        /*
                         * savememory:
                         * 277,231,276,(800),237,210,188,204
                         */
                    }
                }
            }
            //Play.Board[x, y].p.coordinate = Play.Board[x, y].Coordinate; -general idea-

        }
        private static int charSwitch(char a, int x, int y)
        {
            int r = 0;
            switch (a)
            {
                case 'r':
                    Play.Board[x, y].r.coordinate = Play.Board[x, y].Coordinate;
                    Play.Board[x, y].r.name = a;
                    Play.Board[x, y].pieceName = a;
                    break;
                case 'n':
                    Play.Board[x, y].n.coordinate = Play.Board[x, y].Coordinate;
                    Play.Board[x, y].n.name = a;
                    Play.Board[x, y].pieceName = a;
                    break;
                case 'b':
                    Play.Board[x, y].b.coordinate = Play.Board[x, y].Coordinate;
                    Play.Board[x, y].b.name = a;
                    Play.Board[x, y].pieceName = a;
                    break;
                case 'q':
                    Play.Board[x, y].q.coordinate = Play.Board[x, y].Coordinate;
                    Play.Board[x, y].q.name = a;
                    Play.Board[x, y].pieceName = a;
                    break;
                case 'k':
                    Play.Board[x, y].k.coordinate = Play.Board[x, y].Coordinate;
                    Play.Board[x, y].k.name = a;
                    Play.Board[x, y].pieceName = a;
                    break;
                case 'p':
                    Play.Board[x, y].p.coordinate = Play.Board[x, y].Coordinate;
                    Play.Board[x, y].p.name = a;
                    Play.Board[x, y].pieceName = a;
                    break;
                case 'P':
                    Play.Board[x, y].P.coordinate = Play.Board[x, y].Coordinate;
                    Play.Board[x, y].P.name = a;
                    Play.Board[x, y].pieceName = a;
                    break;
                case 'R':
                    Play.Board[x, y].R.coordinate = Play.Board[x, y].Coordinate;
                    Play.Board[x, y].R.name = a;
                    Play.Board[x, y].pieceName = a;
                    break;
                case 'N':
                    Play.Board[x, y].N.coordinate = Play.Board[x, y].Coordinate;
                    Play.Board[x, y].N.name = a;
                    Play.Board[x, y].pieceName = a;
                    break;
                case 'B':
                    Play.Board[x, y].B.coordinate = Play.Board[x, y].Coordinate;
                    Play.Board[x, y].B.name = a;
                    Play.Board[x, y].pieceName = a;
                    break;
                case 'Q':
                    Play.Board[x, y].Q.coordinate = Play.Board[x, y].Coordinate;
                    Play.Board[x, y].Q.name = a;
                    Play.Board[x, y].pieceName = a;
                    break;
                case 'K':
                    Play.Board[x, y].K.coordinate = Play.Board[x, y].Coordinate;
                    Play.Board[x, y].K.name = a;
                    Play.Board[x, y].pieceName = a;
                    break;
                case '1':
                    r = 0;
                    break;
                case '2':
                    r = 1;
                    break;
                case '3':
                    r = 2;
                    break;
                case '4':
                    r = 3;
                    break;
                case '5':
                    r = 4;
                    break;
                case '6':
                    r = 5;
                    break;
                case '7':
                    r = 6;
                    break;
                case '8':
                    r = 7;
                    break;
                default:
                    Console.WriteLine("char not found!");
                    break;
            }
            return r;
        }
    }
}
