

namespace KR
{

    internal class Program
    {

        static List<Animals> _allAnimals = new List<Animals>()
        {
            new HomeAnimals("Домашнее животное"),
            new HomeAnimals("Вьючное животное")
        };


        static void Main(string[] args)
        {

            bool isWork = true;

            ShowAllObjs(_allAnimals);

            while (isWork)
            {
                Console.WriteLine("Выберите тип животного");
                int numAnim = int.Parse(Console.ReadLine());
                Animals selectedAnimals = _allAnimals[numAnim - 1];

                Console.WriteLine("Введите учетный номер животного");
                int Id = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите дуту рождения животного в формате гггг/мм/дд");
                string birthdaySTR = Console.ReadLine();
                DateTime birthday = GetBirthday(birthdaySTR);

                Console.WriteLine("Введите команды животного");
                string commands = Console.ReadLine();








            }





        }


        static void ShowAllObjs<T>(IList<T> odjs) // общий метод
        {

            for (int i = 0; i < odjs.Count; i++)
            {
                Console.WriteLine($"{i + 1} {odjs[i]}");
            }

        }

        static DateTime GetBirthday(string animalDateInput)
        {
            DateTime date = DateTime.Parse(animalDateInput);
            return date;
        }

        public class Animals  //Animals
        {
            protected int _petId;
            protected string _name;
            protected DateTime _birthday;
            protected string _commands;


            public Animals(int petId, string name, string commands = "Default", DateTime? birthday = null)
            {
                _petId = petId;
                _name = name;
                _commands = commands;
                _birthday = birthday ?? DateTime.Now;
            }


            public override string ToString()
            {
                return $"{_petId} {_name} {_commands} {_birthday.ToShortDateString()}";
            }


        }

        public class HomeAnimals : Animals
        {
            public int _homeAnimals { get; private set; }
            public int _packedAnimals { get; private set; }

            public HomeAnimals(int packedAnimals, int petId, string name, string commands = "Default", DateTime? birthday = null) : base(petId, name, commands, birthday) 
            {
                _packedAnimals = packedAnimals;
            }
            /*
            public HomeAnimals(int _homeAnimals, int petId, string name, string commands = "Default", DateTime? birthday = null) : base(petId, name, commands, birthday)
            {
                _homeAnimals = homeAnimals;
            }
            */
          /*
            public override string ToString()
            {
                return _homeAnimals;
                return _packedAnimals;
            }

            */
        }

        public class Cat : HomeAnimals
        {

            public HomeAnimals HomeAnimals { get; private set; }

            public Cat(HomeAnimals HomeAnimals, int petId, string name, string commands = "Default", DateTime? birthday = null) : base(HomeAnimals, petId, name, commands, birthday)
            {
                HomeAnimals = HomeAnimals;
            }


            public override string ToString()
            {
                return $"{base.ToString()} {HomeAnimals}";
            }

        }
        /*
        public class Dog : HomeAnimals
        {

            public Animals Animals { get; private set; }

            public Dog(Animals animals, int petId, string name, string commands = "Default", DateTime? birthday = null) : base(petId, name, commands, birthday)
            {
                Animals = animals;
            }


            public override string ToString()
            {
                return $"{base.ToString()} {Animals}";
            }

        }

        public class Hamster : HomeAnimals
        {

            public Animals Animals { get; private set; }

            public Hamster(Animals animals, int petId, string name, string commands = "Default", DateTime? birthday = null) : base(petId, name, commands, birthday)
            {
                Animals = animals;
            }


            public override string ToString()
            {
                return $"{base.ToString()} {Animals}";
            }

        }

        public class Horse : HomeAnimals
        {

            public Animals Animals { get; private set; }

            public Horse(Animals animals, int petId, string name, string commands = "Default", DateTime? birthday = null) : base(petId, name, commands, birthday)
            {
                Animals = animals;
            }


            public override string ToString()
            {
                return $"{base.ToString()} {Animals}";
            }

        }

        public class Camel : HomeAnimals
        {

            public Animals Animals { get; private set; }

            public Camel(Animals animals, int petId, string name, string commands = "Default", DateTime? birthday = null) : base(petId, name, commands, birthday)
            {
                Animals = animals;
            }


            public override string ToString()
            {
                return $"{base.ToString()} {Animals}";
            }

        }

        public class Donkey : HomeAnimals
        {

            public Animals Animals { get; private set; }

            public Donkey(Animals animals, int petId, string name, string commands = "Default", DateTime? birthday = null) : base(petId, name, commands, birthday)
            {
                Animals = animals;
            }


            public override string ToString()
            {
                return $"{base.ToString()} {Animals}";
            }

        }

        */
















    }





}













