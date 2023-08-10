




int[,,] myArray = new int[4, 3, 5];

Random rand = new Random();

for (int i = 0; i < myArray.GetLength(0); i++)
{
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        for (int k = 0; k < myArray.GetLength(2); k++)
        {
            myArray[i, j, k] = rand.Next(100);
        }
    }
}


for (int i = 0; i < myArray.GetLength(0); i++)
{
    Console.WriteLine($" страница №{i+1}");
    for (int j = 0; j < myArray.GetLength(1); j++)
    {
        for (int k = 0; k < myArray.GetLength(2); k++)
        {
            Console.Write(myArray[i,j,k] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}