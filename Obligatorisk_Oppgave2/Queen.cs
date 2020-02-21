using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Oppgave2
{
  public  class Queen : Piece
    {
        public Queen(string symbol, bool isWhite) : base(symbol, isWhite)
        {
           
        }

        public override bool Move(string fromPosition, string toPosition, bool attacking)
        {
            var diffCol = fromPosition[0] - toPosition[0];
            var diffRow = fromPosition[1] - toPosition[1];
         
            return Math.Abs(diffRow) == Math.Abs(diffCol) || (fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1]) ;
        }
    }
}
