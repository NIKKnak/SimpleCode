
namespace Lesson_74_oop
{
    enum Color
    {
        Red,
        Green,
        Blue,
        Yellow,
        YellowGreen,
        Bleck

    }


    class Program
    {

        static void Main(string[] args)
        {
            
            Point p = new Point();
            
            p.x = 1;
            p.y = 2;
            p.color = Color.Red;

            Console.WriteLine($"{p.x} {p.y} {p.color}");

        }



    }
}