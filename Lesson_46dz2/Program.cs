using System;





    


int[] myArray = new int[6] { 1, 2, 3, 4, 5, 6 };

static int IndexOff(int[] array, int value)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i] == value)
        {
            return i;
        }

    }

    return -1;

}

Console.WriteLine(IndexOff(myArray, 8));


