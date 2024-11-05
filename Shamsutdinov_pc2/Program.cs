class Program
{
    static void Main(string[] args)
    {
        int number = Functions.GenerateNumber(1, 10);

        Console.WriteLine("Угадай число от 1 до 10");

        while (true)
        {
            try
            {
                int yourNumber = Convert.ToInt32(Console.ReadLine());

                if (yourNumber == number) break;
                else if (yourNumber > number)
                {
                    Console.WriteLine("Твоё число слишком большое");
                }
                else
                {
                    Console.WriteLine("Твоё число слишком маленькое");
                }
            }
            catch
            {
                Console.WriteLine("Это не число.");
                continue;
            }
        }
        Console.WriteLine("Правильно.");
    }
}