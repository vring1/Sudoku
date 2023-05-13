
namespace Sudoku;
public class Game
{
    static int[,] array = new int[9, 9];
    public int[,] TheArray
    {
        get { return array; }
        set { array = value; }
    }
    TableFunctions tableFunctions = new TableFunctions();
    ConsoleInputHandler consoleInputHandler = ConsoleInputHandler.GetInstance();
    SudokuCreater sudokuCreater = SudokuCreater.GetInstance();
    TablePrinter tablePrinter = new TablePrinter();
    private static Game instance = null;
    int x = 0;
    //int y = 0;
    private Game()
    {

    }

    public static Game GetInstance()
    {
        if (instance == null)
        {
            instance = new Game();
        }
        return instance;
    }
    public void GameLoop()
    {
        Console.Clear();
        System.Console.WriteLine("Choose a gamemode (press \"1\" for gamemode 1 and \"2\" for gamemode 2): \n");
        System.Console.WriteLine("Gamemode 1: \n You only get to know, if you were right at the end when submitting the Sudoku. \n");
        System.Console.WriteLine("Gamemode 2: \n Every placement is evaluated, and you lose a life (you have 3 lives), when a placement is wrong.\n");
        System.Console.WriteLine("Press 'r' to see rules.\n\n");
        System.Console.WriteLine("Press 'ESC' to exit game.\n\n");
        ChooseGame();
        void ChooseGame()
        {
            var input = Console.ReadKey();
            //string input = Console.ReadLine();
            //if (input == "1")
            if (input.Key == ConsoleKey.D1)
            {
                GameLoop1();
            }
            //else if (input == "2")
            else if (input.Key == ConsoleKey.D2)
            {
                GameLoop2();
            }
            //else if (input == "r" || input == "R")
            else if (input.Key == ConsoleKey.R)
            {
                Console.Clear();
                System.Console.WriteLine("RULE PAGE\n\n");
                System.Console.WriteLine("1. To insert a value, you must write the letter, digit and the number you want to insert, as this: A4 3, if you want to place 3 at place A4. (lowercase letters are also tolerated).\n\n");
                System.Console.WriteLine("2. To erase a number, just type in the location of the number you want to remove, like this: A4. \nThe number will then be erased (again, lowercase letters are tolerated).\n\n");
                System.Console.WriteLine("To go back to the menu, press ESC.\n\n");
                var bla = Console.ReadKey();
                while (bla.Key != ConsoleKey.Escape)
                {
                    bla = Console.ReadKey();
                    continue;
                }
                GameLoop();
            }
            else if (input.Key == ConsoleKey.Escape)
            {
                Console.Clear();
                Environment.Exit(0);
            }
            else
            {
                System.Console.WriteLine(" Press \"1\", \"2\" or \"r/R\"");
                ChooseGame();
            }
        }

    }

    private void GameLoop1()
    {
        bool champ = true;
        if (x == 0)
        {
            sudokuCreater.CreateSudokuFacit(array);
            x++;
        }
        tablePrinter.PrintTable(array);
        if (x > 1)
        {
            System.Console.WriteLine("Now make the changes you want.");
        }
        while ((tableFunctions.CountGreaterThan0(array) < array.Length) || champ)
        {
            consoleInputHandler.InputHandler(array);
            champ = false;
        }
        System.Console.WriteLine("Do you want to submit the Sudoku? (\"y\" for yes, \"n\" for no)");
        var key = Console.ReadKey();
        while (key.Key != ConsoleKey.Y && key.Key != ConsoleKey.N)
        {
            System.Console.WriteLine("I need you to choose whether you want to submit your answer or not, by writing \"y\" for yes and \"n\" for no.");
            key = Console.ReadKey();
        }
        if (key.Key == ConsoleKey.Y)
        {
            tablePrinter.PrintTable(array);
            if (array.Length != tablePrinter.FacitArray.Length)
            {
                System.Console.WriteLine("SOMETHING WENT TERRIBLY WRONG!");
            }

            if (tableFunctions.SudokuIsSolvedCorrectlyWithoutFacit(array))
            {
                System.Console.WriteLine("CONGRATS! YOU HAVE SOLVED THE SUDOKU!");
            }
            else
            {
                System.Console.WriteLine("SORRY! THE SUDOKU WAS NOT SOLVED CORRECTLY!");
            }
        }
        else if (key.Key == ConsoleKey.N)
        {
            x++;
            GameLoop1();
        }
    }
    private void GameLoop2()
    {
        sudokuCreater.CreateSudokuFacit(array);
        tablePrinter.PrintTable(array);
        while ((tableFunctions.CountGreaterThan0(array) < array.Length))
        {
            consoleInputHandler.InputHandler2(array);
            if (consoleInputHandler.Life < 1)
            {
                break;
            }
        }
        tablePrinter.PrintTable(array);
        if (array.Length != tablePrinter.FacitArray.Length)
        {
            System.Console.WriteLine("SOMETHING WENT TERRIBLY WRONG!");
        }

        if (tableFunctions.SudokuIsSolvedCorrectlyWithoutFacit(array))
        {
            System.Console.WriteLine("CONGRATS! YOU HAVE SOLVED THE SUDOKU!");
        }
        else
        {
            System.Console.WriteLine("YOU RAN OUT OF LIVES! BETTER LUCK NEXT TIME!");
        }

    }



}