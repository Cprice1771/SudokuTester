using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SudokuAI;

namespace SudokuUnitTest {
    [TestClass]
    public class Tests {

        [TestMethod]
        public void Easy() {
            Board board = new Board(new List<List<int>>());
            board.Parse(Directory.GetCurrentDirectory() + "\\Input\\Easy\\Puzzle185Easy.sd");
            Solver solver = new Solver();
            board = solver.Solve(board);
            Assert.IsTrue(board.Solved, "Failed to solve Easy 185");

            board = new Board(new List<List<int>>());
            board.Parse(Directory.GetCurrentDirectory() + "\\Input\\Easy\\Puzzle186Easy.sd");
            solver = new Solver();
            board = solver.Solve(board);
            Assert.IsTrue(board.Solved, "Failed to solve Easy 186");

            board = new Board(new List<List<int>>());
            board.Parse(Directory.GetCurrentDirectory() + "\\Input\\Easy\\Puzzle187Easy.sd");
            solver = new Solver();
            board = solver.Solve(board);
            Assert.IsTrue(board.Solved, "Failed to solve Easy 187");

            board = new Board(new List<List<int>>());
            board.Parse(Directory.GetCurrentDirectory() + "\\Input\\Easy\\Puzzle188Easy.sd");
            solver = new Solver();
            board = solver.Solve(board);
            Assert.IsTrue(board.Solved, "Failed to solve Easy 188");

            board = new Board(new List<List<int>>());
            board.Parse(Directory.GetCurrentDirectory() + "\\Input\\Easy\\Puzzle189Easy.sd");
            solver = new Solver();
            board = solver.Solve(board);
            Assert.IsTrue(board.Solved, "Failed to solve Easy 189");

            board = new Board(new List<List<int>>());
            board.Parse(Directory.GetCurrentDirectory() + "\\Input\\Easy\\Puzzle190Easy.sd");
            solver = new Solver();
            board = solver.Solve(board);
            Assert.IsTrue(board.Solved, "Failed to solve Easy 190");
        }

        [TestMethod]
        public void Medium() {

            Board board = new Board(new List<List<int>>());
            board.Parse(Directory.GetCurrentDirectory() + "\\Input\\Medium\\Puzzle185Medium.sd");
            Solver solver = new Solver();
            board = solver.Solve(board);
            Assert.IsTrue(board.Solved, "Failed to solve Medium 185");

            board = new Board(new List<List<int>>());
            board.Parse(Directory.GetCurrentDirectory() + "\\Input\\Medium\\Puzzle186Medium.sd");
            solver = new Solver();
            board = solver.Solve(board);
            Assert.IsTrue(board.Solved, "Failed to solve Medium 186");

            board = new Board(new List<List<int>>());
            board.Parse(Directory.GetCurrentDirectory() + "\\Input\\Medium\\Puzzle187Medium.sd");
            solver = new Solver();
            board = solver.Solve(board);
            Assert.IsTrue(board.Solved, "Failed to solve Medium 187");

            board = new Board(new List<List<int>>());
            board.Parse(Directory.GetCurrentDirectory() + "\\Input\\Medium\\Puzzle188Medium.sd");
            solver = new Solver();
            board = solver.Solve(board);
            Assert.IsTrue(board.Solved, "Failed to solve Medium 188");

            board = new Board(new List<List<int>>());
            board.Parse(Directory.GetCurrentDirectory() + "\\Input\\Medium\\Puzzle189Medium.sd");
            solver = new Solver();
            board = solver.Solve(board);
            Assert.IsTrue(board.Solved, "Failed to solve Medium 189");

            board = new Board(new List<List<int>>());
            board.Parse(Directory.GetCurrentDirectory() + "\\Input\\Medium\\Puzzle190Medium.sd");
            solver = new Solver();
            board = solver.Solve(board);
            Assert.IsTrue(board.Solved, "Failed to solve Medium 190");
        }


        [TestMethod]
        public void Hard() {

            Board board = new Board(new List<List<int>>());
            board.Parse(Directory.GetCurrentDirectory() + "\\Input\\Hard\\HardProblem187.sd");
            Solver solver = new Solver();
            board = solver.Solve(board);
            Assert.IsTrue(board.Solved, "Failed to solve Hard 187");

            board = new Board(new List<List<int>>());
            board.Parse(Directory.GetCurrentDirectory() + "\\Input\\Hard\\HardProblem188.sd");
            solver = new Solver();
            board = solver.Solve(board);
            Assert.IsTrue(board.Solved, "Failed to solve Hard 188");

            board = new Board(new List<List<int>>());
            board.Parse(Directory.GetCurrentDirectory() + "\\Input\\Hard\\HardProblem189.sd");
            solver = new Solver();
            board = solver.Solve(board);
            Assert.IsTrue(board.Solved, "Failed to solve Hard 189");

            board = new Board(new List<List<int>>());
            board.Parse(Directory.GetCurrentDirectory() + "\\Input\\Hard\\HardProblem190.sd");
            solver = new Solver();
            board = solver.Solve(board);
            Assert.IsTrue(board.Solved, "Failed to solve Hard 190");

            board = new Board(new List<List<int>>());
            board.Parse(Directory.GetCurrentDirectory() + "\\Input\\Hard\\HardProblem191.sd");
            solver = new Solver();
            board = solver.Solve(board);
            Assert.IsTrue(board.Solved, "Failed to solve Hard 191");

            board = new Board(new List<List<int>>());
            board.Parse(Directory.GetCurrentDirectory() + "\\Input\\Hard\\HardProblem192.sd");
            solver = new Solver();
            board = solver.Solve(board);
            Assert.IsTrue(board.Solved, "Failed to solve Hard 192");
        }
    }
}
