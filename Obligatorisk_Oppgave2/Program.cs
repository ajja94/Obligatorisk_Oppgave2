using SimpleChess;
using System;
using System.Text;

namespace Obligatorisk_Oppgave2
{
  public  class Program
    {

        //HEI ANJA 
        //static void enable()
        //{
        //    Console.OutputEncoding = System.Text.Encoding.UTF8;
        //    Console.Write("\xfeff"); // bom = byte order mark
        //}
        static void Main(string[] args)
        {
          //  String unicodeString = "Sailboats: ⛵~\u26f5" +
          //"\n" +  // or \r
          //"\x043a\x043e\x0448\x043a\x0430 \x65e5\x672c\x56fd\U00002728⏰\u25a3\u06de\u02a5\u0414\u0416\u0489\u8966";

          //  Console.WriteLine(unicodeString);


            //--------------------------------------------//
            Console.OutputEncoding = Encoding.UTF8;

            var board = new Board();

            var bishop = new Bishop("Bis",false);
            var rook = new Rook("Roo", false);
            var queen = new Queen("Que",false);
            var horse = new Horse("Kni",false);
            var king = new King("Kng",false);
            var pawn = new Pawn("Paw",false);
         //-----------------------------------------------------------------
            var bishopW = new Bishop("Bis",true);
            var rookW = new Rook("Roo", true);
            var queenW = new Queen("Que",true);
            var horseW = new Horse("Kni", true);
            var kingW = new King("Kng",true);
            var pawnW = new Pawn("Paw",true);
          //  ---------------------Setter brikker på brettet----------------\\

            board.Set("c8", bishop);
            board.Set("f8", bishop);
            board.Set("h8", rook);
            board.Set("a8", rook);
            board.Set("d8", queen);
            board.Set("b8", horse);
            board.Set("g8", horse);
            board.Set("e8", king);
           // -----------------------------------------//
            board.Set("c1", bishopW);
            board.Set("f1", bishopW);
            board.Set("h1", rookW);
            board.Set("a1", rookW);
            board.Set("d1", queenW);
            board.Set("b1", horseW);
            board.Set("g1", horseW);
            board.Set("e1", kingW);
            //-------------------------------------//
            board.Set("a2", pawnW);
            board.Set("b2", pawnW);
            board.Set("c2", pawnW);
            board.Set("d2", pawnW);
            board.Set("e2", pawnW);
            board.Set("f2", pawnW);
            board.Set("g2", pawnW);
            board.Set("h2", pawnW);
            //---------------------------------//
            board.Set("a7", pawn);
            board.Set("b7", pawn);
            board.Set("c7", pawn);
            board.Set("d7", pawn);
            board.Set("e7", pawn);
            board.Set("f7", pawn);
            board.Set("g7", pawn);
            board.Set("h7", pawn);


            //   Console.ResetColor();
            while (true)
            {
                board.Show();
                Console.WriteLine("Blankt svar avslutter programmet. Ruter skrives som en bokstav og et tall, for eksempel \"e4\".");
                Console.WriteLine("Hvit begynner");
                var positionFrom = Ask("Hvilken rute vil du flytte fra?");
                var positionTo = Ask("Hvilken rute vil du flytte til?");
                board.Move(positionFrom, positionTo);
            }
        }

        private static string Ask(string question)
        {
            
            Console.Write(question);
            Console.Write(" ");
            var answer = Console.ReadLine();
            if (string.IsNullOrEmpty(answer)) Environment.Exit(0);
            return answer;
        }
       
    }
}
