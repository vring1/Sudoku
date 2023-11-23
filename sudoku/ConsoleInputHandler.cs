namespace Sudoku;

public class ConsoleInputHandler
{
    private static ConsoleInputHandler instance = new ConsoleInputHandler();
    TablePrinter tablePrinter = new TablePrinter();
    PlacementValidator placementValidator = new PlacementValidator();
    private int life = 3;
    public int Life
    {
        get { return life; }
    }
    private ConsoleInputHandler()
    {

    }
    public static ConsoleInputHandler GetInstance()
    {
        //if (instance == null)
        //{
        //    instance = new ConsoleInputHandler();
        //}
        return instance;
    }
    public void InputHandler(int[,] array)
    {
        //var esc = Console.ReadKey();
        //if (esc.Key == ConsoleKey.Escape)
        //{
        //    Console.Clear();
        //    System.Console.WriteLine("Press enter to continue the game or press ESC to go to menu.");
        //    var key = Console.ReadKey();
        //
        //}
        string input = Console.ReadLine();
        if (input.Length == 4 && input.Substring(2, 1) == " ")
        {
            string x = input.Substring(0, 1);
            x = x.ToUpper();
            string y = input.Substring(1, 1);
            string value = input.Substring(3, 1);
            if ((y == "1" || y == "2" || y == "3" || y == "4" || y == "5" || y == "6" || y == "7" || y == "8" || y == "9") &&
            (value == "1" || value == "2" || value == "3" || value == "4" || value == "5" || value == "6" || value == "7" || value == "8" || value == "9"))
            {
                int yint = Int16.Parse(y);
                int valueint = Int16.Parse(value);
                switch (x)
                {
                    case "A":
                        if (placementValidator.IsNotOverWritingFacitValues(array, yint - 1, 0))
                        {
                            array[yint - 1, 0] = valueint;
                            tablePrinter.PrintTable(array);
                        }
                        break;
                    case "B":
                        if (placementValidator.IsNotOverWritingFacitValues(array, yint - 1, 1))
                        {
                            array[yint - 1, 1] = valueint;
                            tablePrinter.PrintTable(array);
                        }
                        break;
                    case "C":
                        if (placementValidator.IsNotOverWritingFacitValues(array, yint - 1, 2))
                        {
                            array[yint - 1, 2] = valueint;
                            tablePrinter.PrintTable(array);
                        }
                        break;
                    case "D":
                        if (placementValidator.IsNotOverWritingFacitValues(array, yint - 1, 3))
                        {
                            array[yint - 1, 3] = valueint;
                            tablePrinter.PrintTable(array);
                        }
                        break;
                    case "E":
                        if (placementValidator.IsNotOverWritingFacitValues(array, yint - 1, 4))
                        {
                            array[yint - 1, 4] = valueint;
                            tablePrinter.PrintTable(array);
                        }
                        break;
                    case "F":
                        if (placementValidator.IsNotOverWritingFacitValues(array, yint - 1, 5))
                        {
                            array[yint - 1, 5] = valueint;
                            tablePrinter.PrintTable(array);
                        }
                        break;
                    case "G":
                        if (placementValidator.IsNotOverWritingFacitValues(array, yint - 1, 6))
                        {
                            array[yint - 1, 6] = valueint;
                            tablePrinter.PrintTable(array);
                        }
                        break;
                    case "H":
                        if (placementValidator.IsNotOverWritingFacitValues(array, yint - 1, 7))
                        {
                            array[yint - 1, 7] = valueint;
                            tablePrinter.PrintTable(array);
                        }
                        break;
                    case "I":
                        if (placementValidator.IsNotOverWritingFacitValues(array, yint - 1, 8))
                        {
                            array[yint - 1, 8] = valueint;
                            tablePrinter.PrintTable(array);
                        }
                        break;
                    default:
                        System.Console.WriteLine("Wrong input, try again. (You need coordinates and a number between 1-9, like: A4 5)");
                        break;
                }
            }
            else
            {
                System.Console.WriteLine("Wrong input, try again. (You need coordinates and a number between 1-9, like: A4 5)");
            }
        }
        else if (input.Length == 2)
        {
            string x = input.Substring(0, 1);
            x = x.ToUpper();
            string y = input.Substring(1, 1);
            int yint = Int16.Parse(y);
            switch (x)
            {
                case "A":
                    array[yint - 1, 0] = 0;
                    tablePrinter.PrintTable(array);
                    break;
                case "B":
                    array[yint - 1, 1] = 0;
                    tablePrinter.PrintTable(array);
                    break;
                case "C":
                    array[yint - 1, 2] = 0;
                    tablePrinter.PrintTable(array);
                    break;
                case "D":
                    array[yint - 1, 3] = 0;
                    tablePrinter.PrintTable(array);
                    break;
                case "E":
                    array[yint - 1, 4] = 0;
                    tablePrinter.PrintTable(array);
                    break;
                case "F":
                    array[yint - 1, 5] = 0;
                    tablePrinter.PrintTable(array);
                    break;
                case "G":
                    array[yint - 1, 6] = 0;
                    tablePrinter.PrintTable(array);
                    break;
                case "H":
                    array[yint - 1, 7] = 0;
                    tablePrinter.PrintTable(array);
                    break;
                case "I":
                    array[yint - 1, 8] = 0;
                    tablePrinter.PrintTable(array);
                    break;
                default:
                    System.Console.WriteLine("Wrong input, try again. (You need coordinates and a number between 1-9, like: A4 5)");
                    break;
            }
        }
        else
        {
            System.Console.WriteLine("Wrong input, try again. (You need coordinates and a number between 1-9, like: A4 5)");
        }

    }

    public void InputHandler2(int[,] array)
    {
        string input = Console.ReadLine();
        if (input.Length == 4 && input.Substring(2, 1) == " ")
        {
            string x = input.Substring(0, 1);
            x = x.ToUpper();
            string y = input.Substring(1, 1);
            string value = input.Substring(3, 1);
            if ((y == "1" || y == "2" || y == "3" || y == "4" || y == "5" || y == "6" || y == "7" || y == "8" || y == "9") &&
            (value == "1" || value == "2" || value == "3" || value == "4" || value == "5" || value == "6" || value == "7" || value == "8" || value == "9"))
            {
                int yint = Int16.Parse(y);
                int valueint = Int16.Parse(value);
                switch (x)
                {
                    case "A":
                        if (placementValidator.PlacementOfValueIsValid(array, valueint, yint - 1, 0))
                        {
                            array[yint - 1, 0] = valueint;
                            tablePrinter.PrintTable(array);
                            break;
                        }
                        life--;
                        if (life == 1)
                        {
                            System.Console.WriteLine("Placement was wrong. You now have {0} life left.", life);
                            break;
                        }
                        System.Console.WriteLine("Placement was wrong. You now have {0} lives left.", life);
                        break;
                    case "B":
                        if (placementValidator.PlacementOfValueIsValid(array, valueint, yint - 1, 1))
                        {
                            array[yint - 1, 1] = valueint;
                            tablePrinter.PrintTable(array);
                            break;
                        }
                        life--;
                        if (life == 1)
                        {
                            System.Console.WriteLine("Placement was wrong. You now have {0} life left.", life);
                            break;
                        }
                        System.Console.WriteLine("Placement was wrong. You now have {0} lives left.", life);
                        break;
                    case "C":
                        if (placementValidator.PlacementOfValueIsValid(array, valueint, yint - 1, 2))
                        {
                            array[yint - 1, 2] = valueint;
                            tablePrinter.PrintTable(array);
                            break;
                        }
                        life--;
                        if (life == 1)
                        {
                            System.Console.WriteLine("Placement was wrong. You now have {0} life left.", life);
                            break;
                        }
                        System.Console.WriteLine("Placement was wrong. You now have {0} lives left.", life);
                        break;
                    case "D":
                        if (placementValidator.PlacementOfValueIsValid(array, valueint, yint - 1, 3))
                        {
                            array[yint - 1, 3] = valueint;
                            tablePrinter.PrintTable(array);
                            break;
                        }
                        life--;
                        if (life == 1)
                        {
                            System.Console.WriteLine("Placement was wrong. You now have {0} life left.", life);
                            break;
                        }
                        System.Console.WriteLine("Placement was wrong. You now have {0} lives left.", life);
                        break;
                    case "E":
                        if (placementValidator.PlacementOfValueIsValid(array, valueint, yint - 1, 4))
                        {
                            array[yint - 1, 4] = valueint;
                            tablePrinter.PrintTable(array);
                            break;
                        }
                        life--;
                        if (life == 1)
                        {
                            System.Console.WriteLine("Placement was wrong. You now have {0} life left.", life);
                            break;
                        }
                        System.Console.WriteLine("Placement was wrong. You now have {0} lives left.", life);
                        break;
                    case "F":
                        if (placementValidator.PlacementOfValueIsValid(array, valueint, yint - 1, 5))
                        {
                            array[yint - 1, 5] = valueint;
                            tablePrinter.PrintTable(array);
                            break;
                        }
                        life--;
                        if (life == 1)
                        {
                            System.Console.WriteLine("Placement was wrong. You now have {0} life left.", life);
                            break;
                        }
                        System.Console.WriteLine("Placement was wrong. You now have {0} lives left.", life);
                        break;
                    case "G":
                        if (placementValidator.PlacementOfValueIsValid(array, valueint, yint - 1, 6))
                        {
                            array[yint - 1, 6] = valueint;
                            tablePrinter.PrintTable(array);
                            break;
                        }
                        life--;
                        if (life == 1)
                        {
                            System.Console.WriteLine("Placement was wrong. You now have {0} life left.", life);
                            break;
                        }
                        System.Console.WriteLine("Placement was wrong. You now have {0} lives left.", life);
                        break;
                    case "H":
                        if (placementValidator.PlacementOfValueIsValid(array, valueint, yint - 1, 7))
                        {
                            array[yint - 1, 7] = valueint;
                            tablePrinter.PrintTable(array);
                            break;
                        }
                        life--;
                        if (life == 1)
                        {
                            System.Console.WriteLine("Placement was wrong. You now have {0} life left.", life);
                            break;
                        }
                        System.Console.WriteLine("Placement was wrong. You now have {0} lives left.", life);
                        break;
                    case "I":
                        if (placementValidator.PlacementOfValueIsValid(array, valueint, yint - 1, 8))
                        {
                            array[yint - 1, 8] = valueint;
                            tablePrinter.PrintTable(array);
                            break;
                        }
                        life--;
                        if (life == 1)
                        {
                            System.Console.WriteLine("Placement was wrong. You now have {0} life left.", life);
                            break;
                        }
                        System.Console.WriteLine("Placement was wrong. You now have {0} lives left.", life);
                        break;
                    default:
                        System.Console.WriteLine("Wrong input, try again. (You need coordinates and a number between 1-9, like: A4 5)");
                        break;
                }
            }
            else
            {
                System.Console.WriteLine("Wrong input, try again. (You need coordinates and a number between 1-9, like: A4 5)");
            }
        }
        else if (input.Length == 2)
        {
            string x = input.Substring(0, 1);
            x = x.ToUpper();
            string y = input.Substring(1, 1);
            int yint = Int16.Parse(y);
            switch (x)
            {
                case "A":
                    array[yint - 1, 0] = 0;
                    tablePrinter.PrintTable(array);
                    break;
                case "B":
                    array[yint - 1, 1] = 0;
                    tablePrinter.PrintTable(array);
                    break;
                case "C":
                    array[yint - 1, 2] = 0;
                    tablePrinter.PrintTable(array);
                    break;
                case "D":
                    array[yint - 1, 3] = 0;
                    tablePrinter.PrintTable(array);
                    break;
                case "E":
                    array[yint - 1, 4] = 0;
                    tablePrinter.PrintTable(array);
                    break;
                case "F":
                    array[yint - 1, 5] = 0;
                    tablePrinter.PrintTable(array);
                    break;
                case "G":
                    array[yint - 1, 6] = 0;
                    tablePrinter.PrintTable(array);
                    break;
                case "H":
                    array[yint - 1, 7] = 0;
                    tablePrinter.PrintTable(array);
                    break;
                case "I":
                    array[yint - 1, 8] = 0;
                    tablePrinter.PrintTable(array);
                    break;
                default:
                    System.Console.WriteLine("Wrong input, try again. (You need coordinates and a number between 1-9, like: A4 5)");
                    break;
            }
        }
        else
        {
            System.Console.WriteLine("Wrong input, try again. (You need coordinates and a number between 1-9, like: A4 5)");
        }



    }
}
