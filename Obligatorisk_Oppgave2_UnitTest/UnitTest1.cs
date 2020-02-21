using NUnit.Framework;
using System;
using Obligatorisk_Oppgave2;

namespace Obligatorisk_Oppgave2_UnitTest
{
   
    public class Tests
    {
        [Test]
        // fromPosition, toPosition, IsWhite, attacking
        [TestCase("a2", "a3", true, false, ExpectedResult = true)]
        [TestCase("b7", "b5", false, false, ExpectedResult = true)]
        [TestCase("a2", "a4", true, false, ExpectedResult = true)]
        [TestCase("b5", "a4", false, true, ExpectedResult = true)]
        [TestCase("a4", "b5", true, true, ExpectedResult = true)]
        
        public bool TestMovePawn( string fromPostiton, string toPosition, bool isWhite, bool attacking)
        {
            var pawn = new Pawn("Pwn", isWhite);
            return pawn.Move(fromPostiton, toPosition, attacking);
        }

        [Test]
        [TestCase("h1", "c1", true, ExpectedResult = false)]
        public bool TestMoveRook(string fromPostiton, string toPosition, bool isWhite)
        {
            var rook = new Rook("Roo", isWhite);
            return rook.Move(fromPostiton, toPosition, isWhite);
        }
        [Test]
        // hvis bonne/ brikke i veien
        [TestCase("c1", "e3", true, ExpectedResult = false)]
        public bool TestMoveBishop(string fromPostiton, string toPosition, bool isWhite)
        {
            var bishop = new Bishop("Bis", isWhite);
            return bishop.Move(fromPostiton, toPosition, isWhite);
        }
        [Test]
        // hvis hvitbrikke  i veien
        [TestCase("d1", "d4", true, ExpectedResult = false)]
        //hvis ingen eller motstanderbrikke i veien
        [TestCase("d1", "d4", true, ExpectedResult = true)]
        public bool TestMoveQueen(string fromPostiton, string toPosition, bool isWhite)
        {
            var queen = new Queen("Que", isWhite);
            return queen.Move(fromPostiton, toPosition, isWhite);
        }
        [Test]
        // hvis ingen eller svart brikke
        [TestCase("g1", "f3", true, ExpectedResult = true)]
        // hvis hvitbonne iveien
        [TestCase("g1", "e2", true, ExpectedResult = false)]

        public bool TestMoveHorse(string fromPostiton, string toPosition, bool isWhite)
        {
           
            var horse = new Horse("kni", isWhite);
            return horse.Move(fromPostiton, toPosition, isWhite);
            
        }
        [Test]
        // hvis hvitbrikke i veien, da skal ikke kongen kunne flytte 
        [TestCase("e1", "e2", true, ExpectedResult = false)]
        // hvis ingen annen brikke i veien eller motstanderbrikke
        [TestCase("e1", "e2", true, ExpectedResult = true)]
        public bool TestKing(string fromPostiton, string toPosition, bool isWhite)
        {
            var king = new King("Kng", isWhite);
            return king.Move(fromPostiton, toPosition, isWhite);
        }
    }
}