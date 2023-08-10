

using System.Xml.Linq;

class Program
{


    static List<Worker> _allUsers = new List<Worker>();
    static List<Job> _allJobs = new List<Job>()
    {
        new Job("Программист",100),
        new Job("PM",150),
        new Job("Тестер",100),
    };

    static void Main(string[] args)
    {

        bool isWork = true;

        ShowAllObjs(_allJobs);



        while (isWork)
        {


            Console.WriteLine("Выберите номер вакансии");
            int jobNum = int.Parse(Console.ReadLine());

            Job selectedJob = _allJobs[jobNum - 1];



            Console.WriteLine("введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("введите фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("введите дату в формате гггг/мм/дд");
            string birthdaySTR = Console.ReadLine();
            DateTime birthday = GetBirthday(birthdaySTR);


            Worker newUser = new Worker(selectedJob, name, surname, birthday); // аргументы из введенных сверху данныйх от пользователя

            _allUsers.Add(newUser);

            Console.WriteLine($"Успешно. Пользователь {newUser} зарегистрирован");

            Console.WriteLine($"Хотите продолжить? Enter/Delete");
            var userAnswer = Console.ReadKey();

            if (userAnswer.Key == ConsoleKey.Enter) Console.WriteLine("\n--------------------------");

            if (userAnswer.Key == ConsoleKey.Delete)
            {
                isWork = false;
            }

        }

        /*
        User user1 = new User("alex", "frid", new DateTime(1991, 1, 1)); // создание нового пользователя

        _allUsers.Add(user1);
        */

        ShowAllObjs(_allUsers); // вывод
    }



    static void ShowAllObjs<T>(IList<T> odjs) // общий метод
    {

        for (int i = 0; i < odjs.Count; i++)
        {
            Console.WriteLine($"{i + 1} {odjs[i]}");
        }

    }

    /*

    static void ShowAllUsers() // метод вывода (показывает введенных пользователей)
    {

        for (int i = 0; i < _allUsers.Count; i++)
        {
            Console.WriteLine($"{i + 1} {_allUsers[i]}");
        }

    }

    static void ShowAllJobs() // метод вывода (показывает введенных пользователей)
    {

        for (int i = 0; i < _allJob.Count; i++)
        {
            Console.WriteLine($"{i + 1} {_allJob[i]}");
        }

    }


    */

    static DateTime GetBirthday(string userDateInput)
    {
        DateTime date = DateTime.Parse(userDateInput);
        return date;
    }

    abstract class User
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public DateTime Birthday { get; private set; }

        /*
        public User(string name)    // констуктор метода User
        {
            Name = name;
        }

        public User() // контстуркор метода с перегрузкой (когда есть несколько конструкторов)
        {

        }
        public User(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        */
        public User(string name, string surname = "Default", DateTime? birthday = null) // устаовили значение по умолчанию, можно удалить остальные конструкторы
        {
            Name = name;
            Surname = surname;
            Birthday = birthday ?? DateTime.Now; // если birthday не заполнена ставится ?? DateTime .Now
        }

        public override string ToString() // переопределение ToString
        {
            return $"{Name} {Surname} {Birthday.ToShortDateString()}"; // полиморфизм
        }

    }

    class Worker : User
    {

        public Job Job { get; private set; }



        public Worker(Job job, string name, string surname, DateTime? birthday = null) : base(name, surname, birthday)
        {
            Job = job;
        }

        public override string ToString()
        {
            return $"{base.ToString()} {Job}";
        }

        public override string ToString()
        {
            return $"{base.ToString()} {Job}";
        }

    }

    class Job
    {
        public string Title { get; private set; }
        public decimal Salary { get; private set; }

        public Job(string title, decimal salary)
        {
            Title = title;
            Salary = salary;
        }

        public override string ToString()
        {
            return Title;
        }

    }

}