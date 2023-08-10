
Console.WriteLine("enter length array");
int lengthArray = Convert.ToInt32(Console.ReadLine());

int[] myArray = new int[lengthArray];
char spase = ' ';



for (int i = 0;i  < myArray.Length;i++)
{
    Console.WriteLine("enter element array: ");
    int result = Convert.ToInt32(Console.ReadLine());
    myArray[i] = result;
}

for (int i = 0; i < myArray.Length;i++)
{
    Console.Write($"{myArray[i]} {spase}");
}

void summElementArray(int[] array)
{
    int sumArray = 0;

    for (int i = 0;i < array.Length ; i++)
    {
        sumArray += array[i];
    }
    Console.WriteLine();
    Console.WriteLine(sumArray);
}


summElementArray(myArray);