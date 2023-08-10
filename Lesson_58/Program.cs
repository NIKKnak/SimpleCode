


class Program
{
    // добавить элемент по индексу
    static void Insert(ref int[] array, int value, int index)
    {
        int[] newArray = new int[array.Length + 1];
        newArray[index] = value;

        for (int i = 0; i < index; i++)
        {
            newArray[i] = array[i];
        }

        for (int i = 0; i < array.Length; i++)
        {
            newArray[i + 1] = array[i];
        }

        array = newArray;
    }

    // добавить элемент в начало массива
    static void AddFirst(ref int[] array, int value)
    {
        Insert(ref array, value, 0);
    }
    // добавить элемент в конец массива
    static void AddLast(ref int[] array, int value)
    {
        Insert(ref array, value, array.Length);
    }









    static void Main(string[] args)
    {

        int[] myArray = { 1, 2, 3, 4, 5, };

        Insert(ref myArray, 7, 0);

    }


    // удалить элемент из массива по индексу
    static void RemoveAt(ref int[] array, int index)
    {
        int[] newArray = new int[array.Length - 1];

        for (int i = 0; i < index; i++)
        {
            newArray[i] = array[i];
        }

        for (int i = index+1; i < array.Length; i++)
        {
            newArray[i-1] = array[i];
        }

    }

    // удалить первый элемент из массива
    static void RemoveFirst(ref int[] array)
    {
        RemoveAt(ref array, 0);
    }

    // удалить последний элемент из массива
    static void RemoveLast(ref int[] array)
    {
        RemoveAt(ref array, array.Length -1);
    }


















}