using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Oppgave2
{
   public class Bishop : Piece
    {
        public Bishop(string symbol, bool isWhite) : base(symbol, isWhite)
        {
            //Symbol = "BIS";
           
        }
        public override bool Move(string fromPosition, string toPosition, bool attacking)
        {
            var diffCol = fromPosition[0] - toPosition[0];
            var diffRow = fromPosition[1] - toPosition[1];
            return Math.Abs(diffRow) == Math.Abs(diffCol);
        }
    }
}
