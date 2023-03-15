internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Solution.MySqrt(2147483647));
    }
}
public class Solution
{

    public static int MySqrt(int x)
    {
        double sqr(double x)
        {
            return x * x;
        }


        for (int i = 0; i < int.MaxValue; i++)
        {
            if (sqr(i) == x) return i;
            else if (sqr(i) > x) return i - 1;
        }
        return 0;
    }
}