


Print();


static void Print()
{

    Console.WriteLine("введите символ: ");
    char sim = Console.ReadKey().KeyChar;
    Console.WriteLine("\nвведите количество элементов: ");
    int number = Convert.ToInt32(Console.ReadLine());
    
    for (int i = 0; i < number; i++)
    {
        Console.Write(sim);
    }
}