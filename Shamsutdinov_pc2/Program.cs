class Program
{
    static void Main(string[] args)
    {
        int number = Functions.GenerateNumber(1, 10);

        Console.WriteLine("Угадай число от 1 до 10");

        int yourNumber = 0;

        while (true)
        {
            yourNumber = Convert.ToInt32(Console.ReadLine());

            if (yourNumber == number) break;

            Console.WriteLine("Неправильно");
        }
        Console.WriteLine("Правильно.");
    }
}