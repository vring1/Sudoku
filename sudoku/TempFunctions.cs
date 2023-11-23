//namespace Sudoku;
//
//public class TempFunctions
//{
//    Table table = new Table();
//    SudokuSolver sudokuSolver = new SudokuSolver();
//    PlacementValidator placementValidator = PlacementValidator.GetInstance();
//
//    public TempFunctions()
//    {
//
//    }
//
//    public void SudokuTemp()
//    {
//        int i = 0;
//        int j = 0;
//        int a = 1;
//        while (table.CountGreaterThan0(table.TheArray) < table.TheArray.Length)
//        {
//            while (i < 9 && j < 9)
//            {
//                if (i == 8 && !(j == 8))
//                {
//                    i = 0;
//                    j++;
//                }
//                else if (i == 8 && j == 8)
//                {
//                    i = 0;
//                    j = 0;
//                    if (a == 9)
//                    {
//                        a = 0;
//                    }
//                    else
//                    {
//                        a++;
//                    }
//                }
//                else
//                {
//                    i++;
//                }
//            }
//        }
//    }
//    public void SudokuSolverTester()
//    {
//        table.PrintTable();
//        //PrintTable();
//        int x = 0;
//        while (table.CountGreaterThan0(table.TheArray) < table.TheArray.Length && x < 1000)
//        {
//            x++;
//            //System.Console.WriteLine("i: " + sudokuSolver.IForSolve + " j: " + sudokuSolver.JForSolve);
//            while (table.CountElemOfSpecificNumber(table.TheArray, sudokuSolver.AForSolve) > 8)
//            {
//                if (sudokuSolver.AForSolve == 9)
//                {
//                    sudokuSolver.AForSolve = 0;
//                }
//                else
//                {
//                    sudokuSolver.AForSolve++;
//                }
//                sudokuSolver.IForSolve = 0;
//                sudokuSolver.JForSolve = 0;
//            }
//            if (placementValidator.PlacementOfValueIsValid(sudokuSolver.AForSolve, sudokuSolver.IForSolve, sudokuSolver.JForSolve))
//            {
//                if (sudokuSolver.IForSolve < 3 && sudokuSolver.JForSolve < 3)
//                {
//                    sudokuSolver.PlacementValidityCounter = 0;
//                    sudokuSolver.SudokuSolverHelper(sudokuSolver.AForSolve, 0, 0);
//                    if (sudokuSolver.PlacementValidityCounter > 1)
//                    {
//                        sudokuSolver.IncrementDecrementEtcForSudokuSolver();
//                        SudokuSolverTester();
//                    }
//                    else
//                    {
//                        table.TheArray[sudokuSolver.IForSolve, sudokuSolver.JForSolve] = sudokuSolver.AForSolve;
//                    }
//                }
//                else if (sudokuSolver.IForSolve < 3 && sudokuSolver.JForSolve > 2 && sudokuSolver.JForSolve < 6)
//                {
//                    sudokuSolver.PlacementValidityCounter = 0;
//                    sudokuSolver.SudokuSolverHelper(sudokuSolver.AForSolve, 0, 3);
//                    if (sudokuSolver.PlacementValidityCounter > 1)
//                    {
//                        sudokuSolver.IncrementDecrementEtcForSudokuSolver();
//                        SudokuSolverTester();
//                    }
//                    else
//                    {
//                        table.TheArray[sudokuSolver.IForSolve, sudokuSolver.JForSolve] = sudokuSolver.AForSolve;
//                    }
//                }
//                else if (sudokuSolver.IForSolve < 3 && sudokuSolver.JForSolve > 5)
//                {
//                    sudokuSolver.PlacementValidityCounter = 0;
//                    sudokuSolver.SudokuSolverHelper(sudokuSolver.AForSolve, 0, 6);
//                    if (sudokuSolver.PlacementValidityCounter > 1)
//                    {
//                        sudokuSolver.IncrementDecrementEtcForSudokuSolver();
//                        SudokuSolverTester();
//                    }
//                    else
//                    {
//                        table.TheArray[sudokuSolver.IForSolve, sudokuSolver.JForSolve] = sudokuSolver.AForSolve;
//                    }
//                }
//                else if (sudokuSolver.IForSolve > 2 && sudokuSolver.IForSolve < 6 && sudokuSolver.JForSolve < 3)
//                {
//                    sudokuSolver.PlacementValidityCounter = 0;
//                    sudokuSolver.SudokuSolverHelper(sudokuSolver.AForSolve, 3, 0);
//                    if (sudokuSolver.PlacementValidityCounter > 1)
//                    {
//                        sudokuSolver.IncrementDecrementEtcForSudokuSolver();
//                        SudokuSolverTester();
//                    }
//                    else
//                    {
//                        table.TheArray[sudokuSolver.IForSolve, sudokuSolver.JForSolve] = sudokuSolver.AForSolve;
//                    }
//                }
//                else if (sudokuSolver.IForSolve > 2 && sudokuSolver.IForSolve < 6 && sudokuSolver.JForSolve > 3 && sudokuSolver.JForSolve < 6)
//                {
//                    sudokuSolver.PlacementValidityCounter = 0;
//                    sudokuSolver.SudokuSolverHelper(sudokuSolver.AForSolve, 3, 3);
//                    if (sudokuSolver.PlacementValidityCounter > 1)
//                    {
//                        sudokuSolver.IncrementDecrementEtcForSudokuSolver();
//                        SudokuSolverTester();
//                    }
//                    else
//                    {
//                        table.TheArray[sudokuSolver.IForSolve, sudokuSolver.JForSolve] = sudokuSolver.AForSolve;
//                    }
//                }
//                else if (sudokuSolver.IForSolve > 2 && sudokuSolver.IForSolve < 6 && sudokuSolver.JForSolve > 5)
//                {
//                    sudokuSolver.PlacementValidityCounter = 0;
//                    sudokuSolver.SudokuSolverHelper(sudokuSolver.AForSolve, 3, 6);
//                    if (sudokuSolver.PlacementValidityCounter > 1)
//                    {
//                        sudokuSolver.IncrementDecrementEtcForSudokuSolver();
//                        SudokuSolverTester();
//                    }
//                    else
//                    {
//                        table.TheArray[sudokuSolver.IForSolve, sudokuSolver.JForSolve] = sudokuSolver.AForSolve;
//                    }
//                }
//                else if (sudokuSolver.IForSolve > 5 && sudokuSolver.JForSolve < 3)
//                {
//                    sudokuSolver.PlacementValidityCounter = 0;
//                    sudokuSolver.SudokuSolverHelper(sudokuSolver.AForSolve, 6, 0);
//                    if (sudokuSolver.PlacementValidityCounter > 1)
//                    {
//                        sudokuSolver.IncrementDecrementEtcForSudokuSolver();
//                        SudokuSolverTester();
//                    }
//                    else
//                    {
//                        table.TheArray[sudokuSolver.IForSolve, sudokuSolver.JForSolve] = sudokuSolver.AForSolve;
//                    }
//                }
//                else if (sudokuSolver.IForSolve > 5 && sudokuSolver.JForSolve > 2 && sudokuSolver.JForSolve < 6)
//                {
//                    sudokuSolver.PlacementValidityCounter = 0;
//                    sudokuSolver.SudokuSolverHelper(sudokuSolver.AForSolve, 6, 3);
//                    if (sudokuSolver.PlacementValidityCounter > 1)
//                    {
//                        sudokuSolver.IncrementDecrementEtcForSudokuSolver();
//                        SudokuSolverTester();
//                    }
//                    else
//                    {
//                        table.TheArray[sudokuSolver.IForSolve, sudokuSolver.JForSolve] = sudokuSolver.AForSolve;
//                    }
//                }
//                else if (sudokuSolver.IForSolve > 5 && sudokuSolver.JForSolve > 5)
//                {
//                    sudokuSolver.PlacementValidityCounter = 0;
//                    sudokuSolver.SudokuSolverHelper(sudokuSolver.AForSolve, 6, 6);
//                    if (sudokuSolver.PlacementValidityCounter > 1)
//                    {
//                        sudokuSolver.IncrementDecrementEtcForSudokuSolver();
//                        SudokuSolverTester();
//                    }
//                    else
//                    {
//                        table.TheArray[sudokuSolver.IForSolve, sudokuSolver.JForSolve] = sudokuSolver.AForSolve;
//                    }
//                }
//            }
//            else
//            {
//                sudokuSolver.IncrementDecrementEtcForSudokuSolver();
//            }
//        }
//    }
//private bool SudokuIsSolvedCorrectly()
//{
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            if (array[i, j] != facitArray1[i, j])
//            {
//                return false;
//            }
//        }
//    }
//    return true;
//}
//
//    private void CaseOf81(int a)
//{
//       int x = 0;
//if (a == 1 || a == 2)
//{
//    while (z < 1)
//    {
//        while (CountElemOfSpecificNumber(array, a) < 9)
//        {
//            Random rd = new Random();
//            int i = rd.Next(0, 3);
//            int m = rd.Next(0, 3);
//            int ii = rd.Next(0, 3);
//            int j = rd.Next(3, 6);
//            int h = rd.Next(3, 6);
//            int jj = rd.Next(3, 6);
//            int k = rd.Next(6, 9);
//            int l = rd.Next(6, 9);
//            int kk = rd.Next(6, 9);
//            if (placementValidator.PlacementOfValueIsValid(a, i, m))
//            {
//                array[i, m] = a;
//            }
//            if (placementValidator.PlacementOfValueIsValid(a, m, j))
//            {
//                array[m, j] = a;
//            }
//            if (placementValidator.PlacementOfValueIsValid(a, ii, k))
//            {
//                array[ii, k] = a;
//            }
//            if (placementValidator.PlacementOfValueIsValid(a, j, h))
//            {
//                array[j, h] = a;
//            }
//            if (placementValidator.PlacementOfValueIsValid(a, h, i))
//            {
//                array[h, i] = a;
//            }
//            if (placementValidator.PlacementOfValueIsValid(a, jj, k))
//            {
//                array[jj, k] = a;
//            }
//            if (placementValidator.PlacementOfValueIsValid(a, k, l))
//            {
//                array[k, l] = a;
//            }
//            if (placementValidator.PlacementOfValueIsValid(a, l, i))
//            {
//                array[l, i] = a;
//            }
//            if (placementValidator.PlacementOfValueIsValid(a, kk, j))
//            {
//                array[kk, j] = a;
//            }
//
//
//        }
//        z++;
//        a++;
//    }
//
//}

//int i = 0;
//int j = 0;
//while (x < 8)
//{
//    while (i < 9)
//    {
//        if (placementValidator.PlacementOfValueIsValid(a, i, j))
//        {
//            array[i, j] = a;
//            x++;
//        }
//        i++;
//    }
//    i = 0;
//    j++;
//}
//if (a < 2)
//{
//    CaseOf81(a + 1);
//}
//
//}
//
//}