using Microsoft.VisualStudio.TestTools.UnitTesting;
using _2uzd_testai;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace _2uzd_testai.Tests
{
    [TestClass()]
    public class _3x3Tests
    {
        [TestMethod()]
        public void KryziukaiWinsTest()
        {
            _3x3 winner = new _3x3();
            bool turn = false;

            Assert.AreEqual("Kryziukai laimejo", winner.checkForWinnerTest("X", "X", "X", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", turn, 0, 3));
        }

        [TestMethod()]
        public void NuliukaiWinsTest()
        {
            _3x3 winner = new _3x3();
            bool turn = true;

            Assert.AreEqual("Nuliukai laimejo", winner.checkForWinnerTest("O", "O", "O", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", turn, 0, 3));

        }

        [TestMethod()]
        public void LygiosiosTest()
        {
            _3x3 winner = new _3x3();
            int turn_count = 9;
            int dydis = 3;

            Assert.AreEqual("Lygiosios", winner.checkForWinnerTest("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", true, turn_count, dydis));

        }

        [TestMethod()]
        public void Test3x3Board()
        {
            _3x3 board = new _3x3();

            int dydis = 3;

            Assert.AreEqual("3x3", board.boardTest(dydis));
        }
        [TestMethod()]
        public void Test4x4Board()
        {
            _3x3 board = new _3x3();

            int dydis = 4;

            Assert.AreEqual("4x4", board.boardTest(dydis));
        }
        [TestMethod()]
        public void Test5x5Board()
        {
            _3x3 board = new _3x3();

            int dydis = 5;

            Assert.AreEqual("5x5", board.boardTest(dydis));
        }
    }
}