using System;
using System.Collections.Generic;
using System.Text;

namespace Obligatorisk_Oppgave2
{
    public class Pawn : Piece
    {
        public Pawn( bool isWhite) : base("PWN", isWhite)
        {
           
        }

        public override string[] GetInBetweenPositions(string fromPosition, string toPosition)
        {
            throw new NotImplementedException();
        }

        //--------------------
        //| from 0 |         |
        //| from 1 |   to 1  |
        //|        |         |
        //--------------------
        //| from 1 |   to 1  |
        //|  to  0 |         |
        //|        |         |
        //--------------------       
        //          a2[1] -         d2[1] = 1 - 4 = -3 
        //fromPosition[1] - toPosition[1]
        public override bool Move(string fromPosition, string toPosition, bool attacking)
        {
            var diffCol = fromPosition[0] - toPosition[0];
            var diffRow = fromPosition[1] - toPosition[1];
            if(IsWhite) {
                if ((diffRow == -2) && fromPosition.Contains("2"))
                {
                    return fromPosition[0] == toPosition[0];
                }
                else if(diffRow == -1 || diffCol == -1)
                {
                   // trenger en quick fix
                    if (attacking) { 
                        return Math.Abs(diffRow) == Math.Abs(diffCol);
                    }
                    else if (toPosition != ""){
                      return fromPosition[0] == toPosition[0];
                    }
                }
            }
         //----------------------------------------------------------------------------------------------------------------------------------------------------------------//
            else { 
            if ((diffRow == +2) && fromPosition.Contains("7"))
            {
                // denne bestemmer  at bonnen kan gå skrått ||  Denne bestemmer at bonnen kan gå fremover (opp eller ned på brettet utifra farge) 
                return  fromPosition[0] == toPosition[0];
            }
                else if(diffRow == +1 || diffCol == +1)
                {
                     // denne bestemmer  at bonnen kan gå skrått ||  Denne bestemmer at bonnen kan gå fremover (opp eller ned på brettet utifra farge)
                    //return Math.Abs(diffRow) == Math.Abs(diffCol) || fromPosition[0] == toPosition[0];
                    if (attacking)
                    {
                        return Math.Abs(diffRow) == Math.Abs(diffCol);
                    }
                    else if (!IsWhite)
                    {
                        return fromPosition[0] == toPosition[0];
                    }
                   
                }
            }
            return false;
        }
    }
}
