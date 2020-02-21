using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Oppgave2
{
  public  class Queen : Piece
    {
        public Queen( bool isWhite) : base("QUE", isWhite)
        {
           
        }

        public override string[] GetInBetweenPositions(string fromPosition, string toPosition)
        {
            throw new NotImplementedException();
        }

        public override bool Move(string fromPosition, string toPosition, bool attacking)
        {
            var diffCol = fromPosition[0] - toPosition[0];
            var diffRow = fromPosition[1] - toPosition[1];
         
            return Math.Abs(diffRow) == Math.Abs(diffCol) || (fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1]) ;
        }
    }
}
