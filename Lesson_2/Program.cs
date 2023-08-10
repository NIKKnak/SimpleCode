

string[] badWords = new string[] { "тупой", "урод" };

string textByUser = Console.ReadLine();

string[] textAsArray = textByUser.Split(' ');

foreach (string word in textAsArray) // выбрать слово предварительно разделенное пробелом
{
    foreach (string badW in badWords) // выбрать плохие слова
    {
        if(word.ToLower().Contains(badW)) // если введенное слово.в нижнем регистре. содержит плохое слово
        {
            Console.WriteLine($"Не прошло проверку. {word}");
            return;
        }
    }
}
Console.WriteLine("End");