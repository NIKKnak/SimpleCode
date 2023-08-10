




Console.Write("введите количество элементов массива:\t");

int elementsCount = Convert.ToInt32(Console.ReadLine());

int[] array = new int[elementsCount]; // заполнение длины массива данными введенные пользователем 

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"\nвведите элемент в массив с индексом {i} ");
    array[i] = Convert.ToInt32(Console.ReadLine()); // вводим данные в массив

    if (array[i] % 2 == 0)
    {
        count += array[i];
    }


}




Console.WriteLine("вывод массива: ");

for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i]);
}

Console.WriteLine($"сумма = {count} ");


int[] result = array.OrderBy(i => i).ToArray();
Console.WriteLine(result);