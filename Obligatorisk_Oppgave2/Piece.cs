using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Oppgave2
{
   public abstract class Piece
    {
    
         public string Symbol { get; set; }
        public bool IsWhite { get; set; }

        public Piece(string symbol , bool isWhite)
            {
                IsWhite = isWhite;
                Symbol = symbol;
            }

            public abstract bool Move(string fromPosition, string toPosition, bool isWhite);
        
    }
}
