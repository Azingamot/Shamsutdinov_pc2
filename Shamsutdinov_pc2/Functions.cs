public class Functions
{
    public static int GenerateNumber(int min, int max)
    {
        Random rand = new Random();
        return rand.Next(min, max);
    }
}