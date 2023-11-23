namespace Sudoku;
public class TablePrinter
{
    int[,] facitArray1 = new int[9, 9] {
    { 5, 8, 1, 6, 7, 2, 4, 3, 9 },
    { 7, 9, 2, 8, 4, 3, 6, 5, 1 },
    { 3, 6, 4, 5, 9, 1, 7, 8, 2 },
    { 4, 3, 8, 9, 5, 7, 2, 1, 6 },
    { 2, 5, 6, 1, 8, 4, 9, 7, 3 },
    { 1, 7, 9, 3, 2, 6, 8, 4, 5 },
    { 8, 4, 5, 2, 1, 9, 3, 6, 7 },
    { 9, 1, 3, 7, 6, 8, 5, 2, 4 },
    { 6, 2, 7, 4, 3, 5, 1, 9, 8 } };
    public int[,] FacitArray
    {
        get { return facitArray1; }
        set { facitArray1 = value; }
    }
    int a;
    PlacementValidator placementValidator = new PlacementValidator();
    TableFunctions tableFunctions = new TableFunctions();
    public void FillArray(int[,] array, int x)
    {
        this.a = x;
        Random rd = new Random();
        if (this.a < 51)
        {
            while (true)
            {
                int i = rd.Next(0, 9);
                int j = rd.Next(0, 9);
                array[i, j] = facitArray1[i, j];
                if (tableFunctions.CountGreaterThan0(array) >= this.a)
                {
                    break;
                }

            }
        }
        else
        {
            throw new IndexOutOfRangeException("x may not be greater than 50");
        }

    }
    public void PrintTable(int[,] array)
    {
        Console.Clear();
        var originalPos = Console.CursorTop;
        int x = 0;
        //int y = 0;
        var currentColor = Console.ForegroundColor;
        System.Console.WriteLine("  A B C   D E F   G H I  ");
        System.Console.WriteLine("-------------------------");
        for (int i = 0; i < array.GetLength(0); i++)
        {
            x++;
            if (i == 3 || i == 6 || i == 9)
            {
                System.Console.WriteLine("-------------------------");
            }
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j == 3 || j == 6 || j == 0)
                {
                    System.Console.Write("| ");
                }
                if (array[i, j] > 0 && tableFunctions.CountGreaterThan0(array) > this.a/* && y < 50*/)
                {
                    Console.Write(array[i, j] + " ");
                    //y++;
                }
                else if (array[i, j] > 0 && tableFunctions.CountGreaterThan0(array) > this.a)
                {
                    //System.Console.WriteLine("HOLA");
                    //Console.SetCursorPosition(i - 6, j - 6);
                    //Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(array[i, j] + " ");
                    //Console.ForegroundColor = currentColor;
                    //Console.SetCursorPosition(24, 12);
                }
                else
                {
                    System.Console.Write("_ ");
                }
                if (j == 8)
                {
                    System.Console.Write("| {0}", x);
                }

            }
            Console.WriteLine();
        }
        System.Console.WriteLine("-------------------------");
    }
}