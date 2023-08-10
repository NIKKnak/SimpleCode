

Console.WriteLine("enter numder");
int enterNuber = Convert.ToInt32(Console.ReadLine());

int a = 0;


while (enterNuber > 0)
{
    a += enterNuber % 10;
    enterNuber /= 10;
}

