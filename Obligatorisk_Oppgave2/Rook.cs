using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Oppgave2
{
    public class Rook : Piece
    {
        public Rook(string symbol, bool isWhite) : base(symbol, isWhite)
        {
            //Symbol = "ROO";
        }
        public override bool Move(string fromPosition, string toPosition, bool attacking)
        {
            return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];
        }
    }
}
