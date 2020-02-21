using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Oppgave2
{
   public class King : Piece
    {
        public King(string symbol, bool isWhite) : base(symbol, isWhite)
        {
            //Symbol = "KIN";
        }

        public override bool Move(string fromPosition, string toPosition, bool isWhite)
        {
            var diffCol = fromPosition[0] - toPosition[0];
            var diffRow = fromPosition[1] - toPosition[1];

            if (Math.Abs(diffRow) == 1 || Math.Abs(diffCol) == 1)
            {
                return Math.Abs(diffRow) == Math.Abs(diffCol) || (fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1]);
            }
            return false;
           
            //return Math.Abs(diffRow) == Math.Abs(1) || (fromPosition[0] == +1 || fromPosition[1] == +1);
        }
    }
}
