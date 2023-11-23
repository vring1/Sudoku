namespace Sudoku;

public class PlacementValidator
{
    //private static PlacementValidator instance = new PlacementValidator();
    public PlacementValidator()
    {

    }

    //public static PlacementValidator GetInstance()
    //{
    //    //if (instance == null)
    //    //{
    //    //    instance = new PlacementValidator();
    //    //}
    //    return instance;
    //}
    private (int x, int y)[] securedPositions = new (int, int)[55];
    private int z = 0;

    public void LockValues(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] > 0)
                {
                    securedPositions[z] = (i, j);
                    System.Console.WriteLine(securedPositions[z]);
                    z++;
                }
            }
        }
    }
    public bool IsNotOverWritingFacitValues(int[,] arr, int q, int w)
    {
        //check på console inputtet, om koordinatet findes i securedPositions, og hvis det gør, return false.
        for (int i = 0; i < securedPositions.Length; i++)
        {
            System.Console.WriteLine(i);
            if (securedPositions[i] == (q, w))
            {
                return false;
            }
        }

        return true;
    }



    public bool ValueIsPlacedCorrectly(int[,] array, int i, int j)
    {
        //første stadie.. løb alle rækker og kolonner igennem.
        int counter = 0;
        for (int x = 1; x < 9; x++)
        {
            if ((i - x) < 0)
            {
                break;
            }
            if (array[i - x, j] == array[i, j])
            {
                counter++;
            }
        }
        for (int x = 1; x < 9; x++)
        {
            if ((i + x) >= 9)
            {
                break;
            }
            if (array[i + x, j] == array[i, j])
            {
                counter++;
            }
        }
        for (int x = 1; x < 9; x++)
        {
            if ((j - x) < 0)
            {
                break;
            }
            if (array[i, j - x] == array[i, j])
            {
                counter++;
            }
        }
        for (int x = 1; x < 9; x++)
        {
            if ((j + x) >= 9)
            {
                break;
            }
            if (array[i, j + x] == array[i, j])
            {
                counter++;
            }
        }

        if (counter > 0)
        {
            return false;
        }

        // andet stadie.. tjek de specifikke blokke.
        counter = 0;
        if (i < 3 && j < 3)
        {
            // we are in the first block
            // check if there exists a value equal to a in here. if not, return true
            if (array[i, j] == array[0, 0] || array[i, j] == array[0, 1] || array[i, j] == array[0, 2] || array[i, j] == array[1, 0] || array[i, j] == array[1, 1] || array[i, j] == array[1, 2] || array[i, j] == array[2, 0] || array[i, j] == array[2, 1] || array[i, j] == array[2, 2])
            {
                counter++;
            }
        }
        if (i < 3 && 2 < j && j < 6)
        {
            //we are in the second block
            if (array[i, j] == array[0, 3] || array[i, j] == array[0, 4] || array[i, j] == array[0, 5] || array[i, j] == array[1, 3] || array[i, j] == array[1, 4] || array[i, j] == array[1, 5] || array[i, j] == array[2, 3] || array[i, j] == array[2, 4] || array[i, j] == array[2, 5])
            {
                counter++;
            }
        }
        if (i < 3 && j > 5)
        {
            //we are in the third block
            if (array[i, j] == array[0, 6] || array[i, j] == array[0, 7] || array[i, j] == array[0, 8] || array[i, j] == array[1, 6] || array[i, j] == array[1, 7] || array[i, j] == array[1, 8] || array[i, j] == array[2, 6] || array[i, j] == array[2, 7] || array[i, j] == array[2, 8])
            {
                counter++;
            }
        }
        if (i > 2 && i < 6 && j < 3)
        {
            // we are in the fourth block
            if (array[i, j] == array[3, 0] || array[i, j] == array[3, 1] || array[i, j] == array[3, 2] || array[i, j] == array[4, 0] || array[i, j] == array[4, 1] || array[i, j] == array[4, 2] || array[i, j] == array[5, 0] || array[i, j] == array[5, 1] || array[i, j] == array[5, 2])
            {
                counter++;
            }
        }
        if (i > 2 && i < 6 && j > 2 && j < 6)
        {
            // we are in the fith block (in the middle)
            if (array[i, j] == array[3, 3] || array[i, j] == array[3, 4] || array[i, j] == array[3, 5] || array[i, j] == array[4, 3] || array[i, j] == array[4, 4] || array[i, j] == array[4, 5] || array[i, j] == array[5, 3] || array[i, j] == array[5, 4] || array[i, j] == array[5, 5])
            {
                counter++;
            }
        }
        if (i > 2 && i < 6 && j > 5)
        {
            // we are in the sixth block
            if (array[i, j] == array[3, 6] || array[i, j] == array[3, 7] || array[i, j] == array[3, 8] || array[i, j] == array[4, 6] || array[i, j] == array[4, 7] || array[i, j] == array[4, 8] || array[i, j] == array[5, 6] || array[i, j] == array[5, 7] || array[i, j] == array[5, 8])
            {
                counter++;
            }
        }
        if (i > 5 && j < 3)
        {
            // we are in the seventh block
            if (array[i, j] == array[6, 0] || array[i, j] == array[6, 1] || array[i, j] == array[6, 2] || array[i, j] == array[7, 0] || array[i, j] == array[7, 1] || array[i, j] == array[7, 2] || array[i, j] == array[8, 0] || array[i, j] == array[8, 1] || array[i, j] == array[8, 2])
            {
                counter++;
            }
        }
        if (i > 5 && j > 2 && j < 6)
        {
            // we are in the eigth block
            if (array[i, j] == array[6, 3] || array[i, j] == array[6, 4] || array[i, j] == array[6, 5] || array[i, j] == array[7, 3] || array[i, j] == array[7, 4] || array[i, j] == array[7, 5] || array[i, j] == array[8, 3] || array[i, j] == array[8, 4] || array[i, j] == array[8, 5])
            {
                counter++;
            }
        }
        if (i > 5 && j > 5)
        {
            // we are in the nineth block
            if (array[i, j] == array[6, 6] || array[i, j] == array[6, 7] || array[i, j] == array[6, 8] || array[i, j] == array[7, 6] || array[i, j] == array[7, 7] || array[i, j] == array[7, 8] || array[i, j] == array[8, 6] || array[i, j] == array[8, 7] || array[i, j] == array[8, 8])
            {
                counter++;
            }
        }

        if (counter > 1)
        {
            return false;
        }
        return true;
    }

    public bool PlacementOfValueIsValid(int[,] array, int a, int i, int j)
    {
        // tjek i arrayet om der i i'te række og j'te søjle er et tal magen til a (giv 'a' fra FillArray() til funktionen)
        if (array[i, j] != 0)
        {
            return false;
        }
        for (int x = 1; x < 9; x++)
        {
            if ((i - x) < 0)
            {
                break;
            }
            if (array[i - x, j] == a)
            {
                return false;
            }
        }

        for (int x = 1; x < 9; x++)
        {
            if ((i + x) >= 9)
            {
                break;
            }
            if (array[i + x, j] == a)
            {
                return false;
            }
        }

        for (int x = 1; x < 9; x++)
        {
            if ((j - x) < 0)
            {
                break;
            }
            if (array[i, j - x] == a)
            {
                return false;
            }
        }
        for (int x = 1; x < 9; x++)
        {
            if ((j + x) >= 9)
            {
                break;
            }
            if (array[i, j + x] == a)
            {
                return false;
            }
        }


        // tjek for a i bestemte intervaller. hvis a er i dette interval, må der ikke sættes et tal magen til
        if (i < 3 && j < 3)
        {
            // we are in the first block
            // check if there exists a value equal to a in here. if not, return true
            if (a == array[0, 0] || a == array[0, 1] || a == array[0, 2] || a == array[1, 0] || a == array[1, 1] || a == array[1, 2] || a == array[2, 0] || a == array[2, 1] || a == array[2, 2])
            {
                return false;
            }
        }
        if (i < 3 && 2 < j && j < 6)
        {
            //we are in the second block
            if (a == array[0, 3] || a == array[0, 4] || a == array[0, 5] || a == array[1, 3] || a == array[1, 4] || a == array[1, 5] || a == array[2, 3] || a == array[2, 4] || a == array[2, 5])
            {
                return false;
            }
        }
        if (i < 3 && j > 5)
        {
            //we are in the third block
            if (a == array[0, 6] || a == array[0, 7] || a == array[0, 8] || a == array[1, 6] || a == array[1, 7] || a == array[1, 8] || a == array[2, 6] || a == array[2, 7] || a == array[2, 8])
            {
                return false;
            }
        }
        if (i > 2 && i < 6 && j < 3)
        {
            // we are in the fourth block
            if (a == array[3, 0] || a == array[3, 1] || a == array[3, 2] || a == array[4, 0] || a == array[4, 1] || a == array[4, 2] || a == array[5, 0] || a == array[5, 1] || a == array[5, 2])
            {
                return false;
            }
        }
        if (i > 2 && i < 6 && j > 2 && j < 6)
        {
            // we are in the fith block (in the middle)
            if (a == array[3, 3] || a == array[3, 4] || a == array[3, 5] || a == array[4, 3] || a == array[4, 4] || a == array[4, 5] || a == array[5, 3] || a == array[5, 4] || a == array[5, 5])
            {
                return false;
            }
        }
        if (i > 2 && i < 6 && j > 5)
        {
            // we are in the sixth block
            if (a == array[3, 6] || a == array[3, 7] || a == array[3, 8] || a == array[4, 6] || a == array[4, 7] || a == array[4, 8] || a == array[5, 6] || a == array[5, 7] || a == array[5, 8])
            {
                return false;
            }
        }
        if (i > 5 && j < 3)
        {
            // we are in the seventh block
            if (a == array[6, 0] || a == array[6, 1] || a == array[6, 2] || a == array[7, 0] || a == array[7, 1] || a == array[7, 2] || a == array[8, 0] || a == array[8, 1] || a == array[8, 2])
            {
                return false;
            }
        }
        if (i > 5 && j > 2 && j < 6)
        {
            // we are in the eigth block
            if (a == array[6, 3] || a == array[6, 4] || a == array[6, 5] || a == array[7, 3] || a == array[7, 4] || a == array[7, 5] || a == array[8, 3] || a == array[8, 4] || a == array[8, 5])
            {
                return false;
            }
        }
        if (i > 5 && j > 5)
        {
            // we are in the nineth block
            if (a == array[6, 6] || a == array[6, 7] || a == array[6, 8] || a == array[7, 6] || a == array[7, 7] || a == array[7, 8] || a == array[8, 6] || a == array[8, 7] || a == array[8, 8])
            {
                return false;
            }
        }


        // tjek desuden om tallet 'a' er dublet i blokken også.
        return true;


    }






}