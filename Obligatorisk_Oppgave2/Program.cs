﻿using SimpleChess;
using System;
using System.Text;

namespace Obligatorisk_Oppgave2
{
  public  class Program
    {
        //static void Enable()

        //HEI ANJA 
        //static void enable()
        //{
        //    Console.OutputEncoding = System.Text.Encoding.UTF8;
        //    Console.Write("\xfeff"); // bom = byte order mark
        //}
        static void Main(string[] args)
        {
          //  Enable();
          //  String unicodeString = "Sailboats: ⛵~\u26f5"+
          //"\n" +  // or \r
          //"\x043a\x043e\x0448\x043a\x0430 \x65e5\x672c\x56fd\U00002728⏰\u25a3\u06de\u02a5\u0414\u0416\u0489\u8966";

          //  Console.WriteLine(unicodeString);
          //  Console.ReadLine();


            //--------------------------------------------//
            Console.OutputEncoding = Encoding.UTF8;

            var board = new Board();

            var bishop = new Bishop(false);
            var rook = new Rook( false);
            var queen = new Queen(false);
            var horse = new Horse(false);
            var king = new King(false);
            var pawn = new Pawn(false);
         //-----------------------------------------------------------------
            var bishopW = new Bishop(true);
            var rookW = new Rook(true);
            var queenW = new Queen(true);
            var horseW = new Horse( true);
            var kingW = new King(true);
            var pawnW = new Pawn(true);
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

           // var IsWhiteTurn = true;
            //   Console.ResetColor();
            while (true)
            {
                board.Show();
                Console.WriteLine("Blankt svar avslutter programmet. Ruter skrives som en bokstav og et tall, for eksempel \"e4\".");
                if (!board.WhiteTurn == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                //Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{(board.WhiteTurn ? "Hvit" : "Rød")} sin tur");
                Console.ForegroundColor = ConsoleColor.White;
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
