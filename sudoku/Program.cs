using System;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            var sudokuSolver = SudokuSolver.GetInstance();
            var game = Game.GetInstance();
            var sudokuCreater = SudokuCreater.GetInstance();
            game.GameLoop();
            //TablePrinter tablePrinter = new TablePrinter();
            //sudokuCreater.CreateSudokuFacit(tablePrinter.FacitArray);
            //sudokuSolver.SudokuSolverTester2(sudokuSolver.SudokuSolverTesterArray);
            //sudokuCreater.CreateSudokuFacit(game.TheArray);
        }
    }
}