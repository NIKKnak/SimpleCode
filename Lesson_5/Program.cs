

using MiNET.Effects;
using MiNET.Entities.Passive;
using SixLabors.ImageSharp;

namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("введите скорость");
            int speed = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите номер");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите название");
            string name = Console.ReadLine();



            Car ferrari = new Car(speed, number, name);

            

        }



       

    }









    public class Car
    {
        public int _speed;
        public int _number;
        public string _name;


        public Car(int speed, int number, string name)
        {
            _speed = speed;
            _number = number;
            _name = name;

        }

        public void Show()
        {
            Console.WriteLine($"скорость{_speed} , номер {_number} , имя {_name}");
        }
    }



}