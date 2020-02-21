using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Oppgave2
{
   public class Bishop : Piece
    {
        public Bishop( bool isWhite) : base("BIS", isWhite)
        {
            //Symbol = "BIS";
           
        }

        public override string[] GetInBetweenPositions(string fromPosition, string toPosition)
        {
            throw new NotImplementedException();
        }

        public override bool Move(string fromPosition, string toPosition, bool attacking)
        {
            var diffCol = fromPosition[0] - toPosition[0];
            var diffRow = fromPosition[1] - toPosition[1];
            return Math.Abs(diffRow) == Math.Abs(diffCol);
        }
    }
}
