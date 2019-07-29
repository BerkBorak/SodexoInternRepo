using NUnit.Framework;
using System;
using BowlingGame;

namespace Tests
{
    public class Tests
    {
        private Game g;
        [SetUp]
        public void Setup()
        {
            g = new Game();
        }
        private void RollMany(int n, int pins)
        {
            for (int i = 0; i < n; i++)
            {
                g.Roll(pins);
            }
        }
        private void RollSpare()
        {
            g.Roll(5);
            g.Roll(5);
        }
        private void RollStrike()
        {
            g.Roll(10);
        }
        [Test]
        public void TestGutterGame()
        { 
            RollMany(20, 0);
            Assert.AreEqual(0, g.Score());
        }
        [Test]
        public void TestAllOnes()
        {
            RollMany(20, 1);
            Assert.AreEqual(20, g.Score());
        }
        [Test]
        public void TestOneSpare()
        {
            RollSpare();
            g.Roll(3);
            RollMany(17, 0);
            Assert.AreEqual(16, g.Score());
        }
        [Test]
        public void TestOneStrike()
        {
            RollStrike();
            g.Roll(3);
            g.Roll(4);
            RollMany(16, 0);
            Assert.AreEqual(24, g.Score());
        }
        [Test]
        public void TestFakeStrike()
        {
            g.Roll(0);
            RollStrike();
            g.Roll(3);
            g.Roll(4);
            RollMany(16, 0);
            Assert.AreEqual(20, g.Score());
        }
        [Test]
        public void TestPerfectGame()
        {
            RollMany(12, 10);
            Assert.AreEqual(300, g.Score());
        }

        /*[TestCase(10, 10, 10, 10, 8, 10, 300)] //perfect game
        [TestCase(0, 10, 3, 4, 16, 0, 20)] // 10 point spare
        [TestCase(10, 3, 4, 0, 15, 0, 24)] // strike
        [TestCase(5, 5, 3, 0, 16, 0, 16)] // spare
        [TestCase(0, 0, 0, 0, 16, 0, 0)] // gutter game
        public void TestEverything(int r1, int r2, int r3, int r4, int leftoverRolls, int leftoverRollValues, int expectedResult)
        {
            g.Roll(r1);
            g.Roll(r2);
            g.Roll(r3);
            g.Roll(r4);
            RollMany(leftoverRolls, leftoverRollValues);
            Assert.AreEqual(expectedResult, g.Score());
        }*/
    }
}