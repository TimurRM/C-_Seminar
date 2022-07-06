internal class Program
{
    private static void Main(string[] args)
    {
        string text = "Дождь в нашей выжженной солнцем степи был редким и долгожданным гостем."
        + " Можно даже сказать, почётны.Все уже смотрели на небо в надежде увидеть хоть стайку"
        + " дождевых облачков. Когда же будет дождь? Пусть он придёт и землю хоть немного обольёт."
        + " Но небо чисто. Солнце высоко. Жара. И вот — о чудо! Пришёл он к нам однажды после обеда,"
        + " чуть к вечеру, как раз к полднику.";


        string Replace(string text, char oldValue, char newValue)
        {
            string result = string.Empty;

            int length = text.Length;
            for (int i = 0; i < length; i++)
            {
                if (text[i] == oldValue) result += newValue;
                else result += text[i];
            }

            return result;
        }
        string newText = Replace(text, ' ', '-');
        Console.WriteLine(newText);
        Console.WriteLine();
        newText = Replace(newText, 'и', 'i');
        Console.WriteLine(newText);
        Console.WriteLine();
    }
}