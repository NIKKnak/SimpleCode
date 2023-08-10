

/*
int[] myArray = { 5, 12, 2, 55, 4, 5, 6, 7 };


int[] myArray2 = myArray[0..4];

Console.WriteLine(myArray[^1]);
Console.WriteLine();

for (int i = 0; i < myArray2.Length; i++)
{
    Console.WriteLine(myArray2[i]);
}
*/


int[,] array = new int[5, 8];


Random rnd = new Random();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rnd.Next(1, 100);
    }
    
}









for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine();
}