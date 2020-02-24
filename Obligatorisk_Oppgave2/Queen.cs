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

            var diffCol = fromPosition[0] - toPosition[0];
            var diffRow = fromPosition[1] - toPosition[1];
            var placesMoved = new List<string>();


            if (diffCol == 0)
            {
                for (int i = 1; i < Math.Abs(diffRow); i++)
                {
                    if (diffRow < 0)
                    {
                        placesMoved.Add($"{(char)(fromPosition[0])}{(char)(fromPosition[1] + i)}");
                    }
                    else
                    {
                        placesMoved.Add($"{(char)(fromPosition[0])}{(char)(fromPosition[1] - i)}");
                    }
                }
            }
            else if(diffRow == 0)
            {
                for (int i = 1; i < Math.Abs(diffCol); i++)
                {
                    if (diffCol < 0)
                    {
                        placesMoved.Add($"{(char)(fromPosition[0] + i)}{(char)(fromPosition[1])}");
                    }
                    else
                    {
                        placesMoved.Add($"{(char)(fromPosition[0] - i)}{(char)(fromPosition[1])}");
                    }
                }
            }
            else if (diffCol < 0)
            {
                for (int i = 1; i < Math.Abs(diffRow); i++)
                {
                    if (diffRow > 0)
                    {
                        placesMoved.Add($"{(char)(fromPosition[0] + i)}{(char)(fromPosition[1] - i)}");
                    }
                    else
                    {
                        placesMoved.Add($"{(char)(fromPosition[0] + i)}{(char)(fromPosition[1] + i)}");
                    }
                }
            }
            else
            {
                for (int i = 1; i < Math.Abs(diffCol); i++)
                {
                    if (diffCol > 0)
                    {
                        placesMoved.Add($"{(char)(fromPosition[0] - i)}{(char)(fromPosition[1] - i)}");
                    }
                    else
                    {
                        placesMoved.Add($"{(char)(fromPosition[0] - i)}{(char)(fromPosition[1] + i)}");
                    }
                }
            }
            return placesMoved.ToArray();
        }

        public override bool Move(string fromPosition, string toPosition, bool attacking)
        {
            var diffCol = fromPosition[0] - toPosition[0];
            var diffRow = fromPosition[1] - toPosition[1];
         
            return Math.Abs(diffRow) == Math.Abs(diffCol) || (fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1]) ;
        }
    }
}
