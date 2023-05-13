namespace Sudoku;


public class SudokuSolver
{
    PlacementValidator placementValidator = new PlacementValidator();
    TablePrinter tablePrinter = new TablePrinter();
    TableFunctions tableFunctions = new TableFunctions();
    private int iForSolve = 0;
    private int jForSolve = 0;
    private int aForSolve = 1;
    private int placementValidityCounter = 0;
    int x = 0;
    public int[,] SudokuSolverTesterArray = new int[9, 9] {
    { 1, 0, 0, 8, 5, 0, 0, 7, 0 },
    { 7, 0, 0, 0, 9, 2, 0, 0, 0 },
    { 5, 0, 0, 0, 0, 0, 1, 0, 0 },
    { 0, 0, 0, 0, 6, 9, 3, 4, 5 },
    { 0, 4, 0, 0, 0, 0, 0, 2, 0 },
    { 0, 0, 6, 0, 3, 0, 0, 0, 0 },
    { 0, 0, 0, 0, 0, 0, 9, 0, 3 },
    { 0, 1, 0, 0, 0, 3, 6, 8, 7 },
    { 0, 0, 3, 9, 0, 0, 2, 5, 0 } };
    private static SudokuSolver instance = null;

    private SudokuSolver()
    {

    }
    public static SudokuSolver GetInstance()
    {
        if (instance == null)
        {
            instance = new SudokuSolver();
        }
        return instance;
    }

    private void SudokuSolverHelper(int[,] arr, int a, int i, int j)
    {
        bool c1 = placementValidator.PlacementOfValueIsValid(arr, a, i, j);
        bool c2 = placementValidator.PlacementOfValueIsValid(arr, a, i, j + 1);
        bool c3 = placementValidator.PlacementOfValueIsValid(arr, a, i, j + 2);
        bool c4 = placementValidator.PlacementOfValueIsValid(arr, a, i + 1, j);
        bool c5 = placementValidator.PlacementOfValueIsValid(arr, a, i + 1, j + 1);
        bool c6 = placementValidator.PlacementOfValueIsValid(arr, a, i + 1, j + 2);
        bool c7 = placementValidator.PlacementOfValueIsValid(arr, a, i + 2, j);
        bool c8 = placementValidator.PlacementOfValueIsValid(arr, a, i + 2, j + 1);
        bool c9 = placementValidator.PlacementOfValueIsValid(arr, a, i + 2, j + 2);
        if (c1) { placementValidityCounter++; }
        if (c2) { placementValidityCounter++; }
        if (c3) { placementValidityCounter++; }
        if (c4) { placementValidityCounter++; }
        if (c5) { placementValidityCounter++; }
        if (c6) { placementValidityCounter++; }
        if (c7) { placementValidityCounter++; }
        if (c8) { placementValidityCounter++; }
        if (c9) { placementValidityCounter++; }

    }
    private void IncrementDecrementEtcForSudokuSolver()
    {
        if (iForSolve == 8 && !(jForSolve == 8))
        {
            iForSolve = 0;
            jForSolve++;
        }
        else if (iForSolve == 8 && jForSolve == 8)
        {
            iForSolve = 0;
            jForSolve = 0;
            if (aForSolve == 9)
            {
                aForSolve = 1;
            }
            else
            {
                aForSolve++;
            }
        }
        else
        {
            iForSolve++;
        }
    }
    public void SudokuSolverTester2(int[,] arr)
    {
        //tablePrinter.FillArray(arr, 50);
        tablePrinter.PrintTable(arr);

        while (tableFunctions.CountGreaterThan0(arr) < arr.Length && x < 500)
        {
            System.Console.WriteLine(x);
            x++;
            while (tableFunctions.CountElemOfSpecificNumber(arr, aForSolve) > 8)
            {
                if (aForSolve == 9)
                {
                    aForSolve = 0;
                }
                else
                {
                    aForSolve++;
                }
                iForSolve = 0;
                jForSolve = 0;
            }
            if (placementValidator.PlacementOfValueIsValid(arr, aForSolve, iForSolve, jForSolve))
            {
                if (iForSolve < 3 && jForSolve < 3)
                {
                    placementValidityCounter = 0;
                    SudokuSolverHelper(arr, aForSolve, 0, 0);
                    if (placementValidityCounter > 1)
                    {
                        IncrementDecrementEtcForSudokuSolver();
                        SudokuSolverTester2(arr);
                    }
                    else
                    {
                        arr[iForSolve, jForSolve] = aForSolve;
                        tablePrinter.PrintTable(arr);
                    }
                }
                else
                {
                    arr[iForSolve, jForSolve] = aForSolve;
                    tablePrinter.PrintTable(arr);
                }
            }
            else
            {
                IncrementDecrementEtcForSudokuSolver();
            }
        }
        int[,] bla = arr;
        if (tableFunctions.SudokuIsSolvedCorrectlyWithoutFacit(arr))
        {
            System.Console.WriteLine("you did it buddy");
        }
        else { SudokuSolverTester2(bla); }
    }





}