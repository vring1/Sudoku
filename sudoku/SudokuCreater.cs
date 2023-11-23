namespace Sudoku;

public class SudokuCreater
{

    TableFunctions tableFunctions = new TableFunctions();
    PlacementValidator placementValidator = new PlacementValidator();
    TablePrinter tablePrinter = new TablePrinter();
    SudokuSolver sudokuSolver = SudokuSolver.GetInstance();
    private static SudokuCreater instance = null;

    private SudokuCreater()
    {

    }
    public static SudokuCreater GetInstance()
    {
        if (instance == null)
        {
            instance = new SudokuCreater();
        }
        return instance;
    }

    /// <summary>
    /// Creates a sudoku facit.
    /// </summary>
    /// <param name="arr"></param>
    public void CreateSudokuFacit(int[,] arr)
    {
        //step 1, fill array
        tablePrinter.FillArray(arr, 50);
        Random rd = new Random();
        //Step 2. Shuffle the the digits and replace in all other cells
        for (int b = 0; b < 10; b++)
        {
            int m = rd.Next(1, 10);
            int n = rd.Next(1, 10);
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] == m)
                    {
                        arr[i, j] = n;
                    }
                    else if (arr[i, j] == n)
                    {
                        arr[i, j] = m;
                    }
                }
            }
        }
        //Step 3. Randomly rearrange columns 1,2 and 3 within themselves
        int[] temp0 = new int[9];
        int[] temp1 = new int[9];
        int[] temp2 = new int[9];

        for (int i = 0; i < 9; i++)
        {
            temp0[i] = arr[i, 0];
        }
        for (int i = 0; i < 9; i++)
        {
            temp1[i] = arr[i, 1];
        }
        for (int i = 0; i < 9; i++)
        {
            temp2[i] = arr[i, 2];
        }
        int x = rd.Next(0, 3);
        for (int i = 0; i < 9; i++)
        {
            arr[i, x] = temp0[i];
        }
        int y = rd.Next(0, 3);
        while (y == x)
        {
            y = rd.Next(0, 3);
        }
        for (int i = 0; i < 9; i++)
        {
            arr[i, y] = temp1[i];
        }
        int z = rd.Next(0, 3);
        while (z == y || z == x)
        {
            z = rd.Next(0, 3);
        }
        for (int i = 0; i < 9; i++)
        {
            arr[i, z] = temp2[i];
        }

        //Step 4. Randomly rearrange columns 4,5 and 6 within themselves
        int[] temp3 = new int[9];
        int[] temp4 = new int[9];
        int[] temp5 = new int[9];
        for (int i = 0; i < 9; i++)
        {
            temp3[i] = arr[i, 3];
        }
        for (int i = 0; i < 9; i++)
        {
            temp4[i] = arr[i, 4];
        }
        for (int i = 0; i < 9; i++)
        {
            temp5[i] = arr[i, 5];
        }
        x = rd.Next(3, 6);
        for (int i = 0; i < 9; i++)
        {
            arr[i, x] = temp3[i];
        }
        y = rd.Next(3, 6);
        while (y == x)
        {
            y = rd.Next(3, 6);
        }
        for (int i = 0; i < 9; i++)
        {
            arr[i, y] = temp4[i];
        }
        z = rd.Next(3, 6);
        while (z == y || z == x)
        {
            z = rd.Next(3, 6);
        }
        for (int i = 0; i < 9; i++)
        {
            arr[i, z] = temp5[i];
        }



        //Step 5. Randomly rearrange columns 7,8 and 9 within themselves
        int[] temp6 = new int[9];
        int[] temp7 = new int[9];
        int[] temp8 = new int[9];
        for (int i = 0; i < 9; i++)
        {
            temp6[i] = arr[i, 6];
        }
        for (int i = 0; i < 9; i++)
        {
            temp7[i] = arr[i, 7];
        }
        for (int i = 0; i < 9; i++)
        {
            temp8[i] = arr[i, 8];
        }
        x = rd.Next(6, 9);
        for (int i = 0; i < 9; i++)
        {
            arr[i, x] = temp6[i];
        }
        y = rd.Next(6, 9);
        while (y == x)
        {
            y = rd.Next(6, 9);
        }
        for (int i = 0; i < 9; i++)
        {
            arr[i, y] = temp7[i];
        }
        z = rd.Next(6, 9);
        while (z == y || z == x)
        {
            z = rd.Next(6, 9);
        }
        for (int i = 0; i < 9; i++)
        {
            arr[i, z] = temp8[i];
        }



        //Step 6. Randomly rearrange rows 1,2 and 3 within themselves
        for (int i = 0; i < 9; i++)
        {
            temp0[i] = arr[0, i];
        }
        for (int i = 0; i < 9; i++)
        {
            temp1[i] = arr[1, i];
        }
        for (int i = 0; i < 9; i++)
        {
            temp2[i] = arr[2, i];
        }
        x = rd.Next(0, 3);
        for (int i = 0; i < 9; i++)
        {
            arr[x, i] = temp0[i];
        }
        y = rd.Next(0, 3);
        while (y == x)
        {
            y = rd.Next(0, 3);
        }
        for (int i = 0; i < 9; i++)
        {
            arr[y, i] = temp1[i];
        }
        z = rd.Next(0, 3);
        while (z == y || z == x)
        {
            z = rd.Next(0, 3);
        }
        for (int i = 0; i < 9; i++)
        {
            arr[z, i] = temp2[i];
        }

        //Step 7. Randomly rearrange rows 4,5 and 6 within themselves
        for (int i = 0; i < 9; i++)
        {
            temp0[i] = arr[3, i];
        }
        for (int i = 0; i < 9; i++)
        {
            temp1[i] = arr[4, i];
        }
        for (int i = 0; i < 9; i++)
        {
            temp2[i] = arr[5, i];
        }
        x = rd.Next(3, 6);
        for (int i = 0; i < 9; i++)
        {
            arr[x, i] = temp0[i];
        }
        y = rd.Next(3, 6);
        while (y == x)
        {
            y = rd.Next(3, 6);
        }
        for (int i = 0; i < 9; i++)
        {
            arr[y, i] = temp1[i];
        }
        z = rd.Next(3, 6);
        while (z == y || z == x)
        {
            z = rd.Next(3, 6);
        }
        for (int i = 0; i < 9; i++)
        {
            arr[z, i] = temp2[i];
        }

        //Step 8. Randomly rearrange rows 7,8 and 9 within themselves
        for (int i = 0; i < 9; i++)
        {
            temp0[i] = arr[6, i];
        }
        for (int i = 0; i < 9; i++)
        {
            temp1[i] = arr[7, i];
        }
        for (int i = 0; i < 9; i++)
        {
            temp2[i] = arr[8, i];
        }
        x = rd.Next(6, 9);
        for (int i = 0; i < 9; i++)
        {
            arr[x, i] = temp0[i];
        }
        y = rd.Next(6, 9);
        while (y == x)
        {
            y = rd.Next(6, 9);
        }
        for (int i = 0; i < 9; i++)
        {
            arr[y, i] = temp1[i];
        }
        z = rd.Next(6, 9);
        while (z == y || z == x)
        {
            z = rd.Next(6, 9);
        }
        for (int i = 0; i < 9; i++)
        {
            arr[z, i] = temp2[i];
        }

        //placementValidator.LockValues(arr);
        //Step 9. Randomly rearrange in 3 column groups of size 9x3 (IKKE NØDVENDIGT)

        //Step 10. Randomly rearrange in 3 row groups of size 3x9 (IKKE NØDVENDIGT)


    }

}