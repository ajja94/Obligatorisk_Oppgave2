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
            var pawn = new Pawn( isWhite);
            return pawn.Move(fromPostiton, toPosition, attacking);
        }

        [Test]
        [TestCase("h1", "c1", true, ExpectedResult = true)]
        public bool TestMoveRook(string fromPostiton, string toPosition, bool isWhite)
        {
            var rook = new Rook( isWhite);
            return rook.Move(fromPostiton, toPosition, isWhite);
        }
        [Test]
        // hvis bonne/ brikke i veien
        [TestCase("c1", "e3", true, ExpectedResult = true)]
        public bool TestMoveBishop(string fromPostiton, string toPosition, bool isWhite)
        {
            var bishop = new Bishop( isWhite);
            return bishop.Move(fromPostiton, toPosition, isWhite);
        }
        [Test]
        // hvis hvitbrikke  i veien
        [TestCase("d1", "d4", true, ExpectedResult = true)]
        //hvis ingen eller motstanderbrikke i veien
        [TestCase("d1", "d4", true, ExpectedResult = true)]
        public bool TestMoveQueen(string fromPostiton, string toPosition, bool isWhite)
        {
            var queen = new Queen( isWhite);
            return queen.Move(fromPostiton, toPosition, isWhite);
        }
        [Test]
        // hvis ingen eller svart brikke
        [TestCase("g1", "f3", true, ExpectedResult = true)]
        // hvis hvitbonne iveien
        [TestCase("g1", "e2", true, ExpectedResult = true)]
        [TestCase("b1", "c3", true, ExpectedResult = true)]
        [TestCase("b1", "a3", true, ExpectedResult = true)]
        [TestCase("b1", "b2", true, ExpectedResult = false)]

        public bool TestMoveHorse(string fromPostiton, string toPosition, bool isWhite)
        {
           
            var horse = new Horse( isWhite);
            return horse.Move(fromPostiton, toPosition, isWhite);
            
        }
        [Test]
        // hvis hvitbrikke i veien, da skal ikke kongen kunne flytte 
        [TestCase("e1", "e2", true, ExpectedResult = true)]
        // hvis ingen annen brikke i veien eller motstanderbrikke
        [TestCase("e1", "e2", true, ExpectedResult = true)]
        public bool TestKing(string fromPostiton, string toPosition, bool isWhite)
        {
            var king = new King(isWhite);
            return king.Move(fromPostiton, toPosition, isWhite);
        }

        [Test]
        [TestCase("a1", "a3", true, ExpectedResult = new string[] { "a2" })]
        [TestCase("a7", "a2", true, ExpectedResult = new string[] { "a6", "a5", "a4", "a3" })]
        [TestCase("a1", "h1", true, ExpectedResult = new string[] { "b1", "c1", "d1", "e1", "f1", "g1" })]
        [TestCase("c1", "a1", true, ExpectedResult = new string[] { "b1"})]
        public string[] RookMovedPlaces(string from, string to, bool isWhite)
        {
            var rook = new Rook(isWhite);
            return rook.GetInBetweenPositions(from, to);
        }
        [Test]
        [TestCase("c1","e3", true, ExpectedResult = new string[] { "d2" })]
        [TestCase("c1","g5", true, ExpectedResult = new string[] { "d2", "e3", "f4" })]
        [TestCase("a1","h8", true, ExpectedResult = new string[] { "b2", "c3", "d4", "e5", "f6", "g7" })]
        [TestCase("f1","b5", true, ExpectedResult = new string[] { "e2", "d3", "c4" })]
        public string[] BishopMovedPlaces(string from, string to, bool isWhite)
        {
            var bishop = new Bishop(isWhite);
            return bishop.GetInBetweenPositions(from, to);
        }
        [Test]
        [TestCase("c1", "e3", true, ExpectedResult = new string[] { "d2" })]
        [TestCase("c1", "g5", true, ExpectedResult = new string[] { "d2", "e3", "f4" })]
        [TestCase("a1", "h8", true, ExpectedResult = new string[] { "b2", "c3", "d4", "e5", "f6", "g7" })]
        [TestCase("a1", "a3", true, ExpectedResult = new string[] { "a2" })]
        [TestCase("a7", "a2", true, ExpectedResult = new string[] { "a6", "a5", "a4", "a3" })]
        [TestCase("a1", "h1", true, ExpectedResult = new string[] { "b1", "c1", "d1", "e1", "f1", "g1" })]
        [TestCase("c1", "a1", true, ExpectedResult = new string[] { "b1" })]
        public string[] QueenMovedPlaces(string from, string to, bool isWhite)
        {
            var queen = new Queen(isWhite);
            return queen.GetInBetweenPositions(from, to);
        }
        [Test]
        [TestCase("c2","c4", true, ExpectedResult = new string[] {"c3" })]
        [TestCase("c7","c5", false, ExpectedResult = new string[] {"c6" })]
        [TestCase("c7","c6", false, ExpectedResult = new string[] { })]
        public string[] PawnMovedPlaces(string from, string to, bool isWhite)
        {
            var pawn = new Pawn(isWhite);
            return pawn.GetInBetweenPositions(from, to);
        }



    }
}