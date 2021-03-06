﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Oppgave2
{
    public class Horse:Piece
    {
        public Horse( bool isWhite) : base("KNI", isWhite)
        {
          //  Symbol = "KNI";
        }

        public override string[] GetInBetweenPositions(string fromPosition, string toPosition)
        {
            return new string[0];
        }

        public override bool Move(string fromPosition, string toPosition, bool attacking)
        {
            var diffCol = fromPosition[0] - toPosition[0];
            var diffRow = fromPosition[1] - toPosition[1];
            return (Math.Abs(diffRow) ==2 && Math.Abs(diffCol)==1) || (Math.Abs(diffRow) == 1 && Math.Abs(diffCol) == 2);

        }
    }
}
