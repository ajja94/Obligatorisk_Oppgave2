using Obligatorisk_Oppgave2;
using System;
using System.Collections.Generic;


namespace SimpleChess
{
    public class Board
    {
        readonly Dictionary<string, Piece> _pieces = new Dictionary<string, Piece>();
        public bool WhiteTurn { get; set; } = true;
        // private Piece piece1;

        //bool IsBlack = false;
        //bool IsWhite = false;

        //public void string GetInBetweenPositions()
        //{

        //}
        //public void loopDictionary()
        //{
        //    foreach (var pice in board.Show() )
        //    {
        //        if (HasValue(pice))
        //        {
        //            Console.WriteLine(pice);
        //        }

        //        else Console.WriteLine("Tom");
        //    }
        //    Console.ReadLine();
        //}

        public void Set(string position, Piece piece)
        {

            if (_pieces.ContainsKey(position)) _pieces[position] = piece;
            // else if (_pieces.ContainsKey()) _pieces[position] = piece;
            else _pieces.Add(position, piece);
        }
        private bool CanGoThere(string toPosition, string fromPosition)
        {
            if (!_pieces.ContainsKey(toPosition) || !_pieces.ContainsKey(fromPosition))
            {
                return true;
            }
            return _pieces[fromPosition].IsWhite != _pieces[toPosition].IsWhite || !_pieces[fromPosition].IsWhite != !_pieces[toPosition].IsWhite;
        }
        public void Remove(string position, Piece piece)
        {
            if (_pieces.ContainsKey(position))
            {
                _pieces.Remove(position, out piece);
            }
        }

        public bool Move(string fromPosition, string toPosition)
        {
            // if (!HvitEllerSvart(fromPosition)) return false;
            if (!CanGoThere(toPosition, fromPosition)) return false;
            // if (HasValue(toPosition) || !HasValue(fromPosition)) return false;

            var piece = _pieces[fromPosition];
            var isPossible = piece.Move(fromPosition, toPosition, _pieces.ContainsKey(toPosition));
            if (WhiteTurn != _pieces[fromPosition].IsWhite) isPossible = false;
            if (isPossible)
            {
                var positions = piece.GetInBetweenPositions(fromPosition, toPosition);
                foreach (var pos in positions)
                {
                    if (_pieces.ContainsKey(pos))
                    {
                        isPossible = false;
                        break;
                    }
                }
                if (_pieces.ContainsKey(toPosition) && isPossible)
                {
                    if (_pieces[fromPosition].IsWhite == _pieces[toPosition].IsWhite)
                    {
                        isPossible = false;
                    }
                    else if (_pieces[fromPosition].IsWhite != _pieces[toPosition].IsWhite)
                    {
                        Remove(toPosition, _pieces[toPosition]);
                    }
                }

            }

            if (!isPossible) return false;
            Set(toPosition, piece);
            Remove(fromPosition, piece);
            WhiteTurn = !WhiteTurn;
            //Set(fromPosition,null);

            return true;
        }
        //public bool HvitEllerSvart(string fromPosition)
        //{
        //    int hvitEllerSvart;
        //    for (hvitEllerSvart = 0; hvitEllerSvart >= 0;)
        //    {

        //        if (hvitEllerSvart == 0 || hvitEllerSvart % 2 == 0)
        //        {
        //            if (_pieces[fromPosition].IsWhite)
        //            {
        //                hvitEllerSvart++;
        //                return _pieces[fromPosition].IsWhite == _pieces[fromPosition].IsWhite;

        //            }
        //            else
        //            {

        //                return false;
        //            }
        //        }

        //        else
        //        {
        //            if (!_pieces[fromPosition].IsWhite)
        //            {
        //                hvitEllerSvart++;
        //                return !_pieces[fromPosition].IsWhite == !_pieces[fromPosition].IsWhite;

        //            }
        //            else
        //            {

        //                return false;
        //            }

        //        }
        //    }
        //  
        //        return true;
        // }



        private bool HasValue(string position)
        {
            return _pieces.ContainsKey(position) && _pieces[position] != null;
        }


        //private bool IsOut(string toPosition, string fromPosition)
        //{
        //    if (IsOut)
        //}
        public void Show()
        {
            Console.Clear();
            Console.WriteLine("\n8\n\n\n7\n\n\n6\n\n\n5\n\n\n4\n\n\n3\n\n\n2\n\n\n1");
            for (var row = 8; row >= 1; row--)
                for (var col = 'a'; col <= 'h'; col++)
                {
                    var left = 1 + (col - 'a') * 5;
                    var top = (8 - row) * 3;
                    var isBlack = row % 2 == col % 2;
                    var fillChar = row % 2 == col % 2 ? ' ' : '█';
                    SetColor(isBlack);
                    Write(5, fillChar, left, top);
                    Write(1, fillChar, left, top + 1);

                    var symbol = GetPieceSymbol(col, row);
                    Console.Write(symbol);
                    // Console.BackgroundColor = ConsoleColor.Black;
                    SetColor(isBlack);
                    Write(1, fillChar);
                    Write(5, fillChar, left, top + 2);
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            Console.WriteLine();
            Console.WriteLine("   A    B    C    D    E    F    G    H");
        }

        private static void SetColor(bool isBlack)
        {
            if (!isBlack)
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }

        private string GetPieceSymbol(char col, int row)
        {
            var position = "" + col + row;
            if (!_pieces.ContainsKey(position) || _pieces[position] == null) return "   ";
            var piece = _pieces[position];
            var color = piece.IsWhite ? ConsoleColor.DarkGray : ConsoleColor.Red;
            Console.ForegroundColor = color;
            return _pieces[position].Symbol;
        }

        private static void Write(int count, char c, int? left = null, int? top = null)
        {
            if (left != null) Console.CursorLeft = left.Value;
            if (top != null) Console.CursorTop = top.Value;

            Console.Write("".PadLeft(count, c));
        }
    }
}
