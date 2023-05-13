namespace Sudoku;

public class TableFunctions
{
    PlacementValidator placementValidator = new PlacementValidator();

    public TableFunctions()
    {

    }
    public int CountGreaterThan0(int[,] arr)
    {
        int counter = 0;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] > 0)
                {
                    counter++;
                }
            }
        }
        return counter;
    }

    public int CountElemOfSpecificNumber(int[,] arr, int num)
    {
        int counter = 0;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] == num)
                {
                    counter++;
                }
            }
        }
        return counter;
    }

    public bool SudokuIsSolvedCorrectlyWithoutFacit(int[,] array)
    {
        if (CountGreaterThan0(array) != 81)
        {
            return false;
        }
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (!(placementValidator.ValueIsPlacedCorrectly(array, i, j)))
                {
                    return false;
                }
            }
        }
        return true;
    }

}