class Program
{
    public static void Main()
    {
        int[] arr = [2, 4, 6, 8];

        Console.WriteLine(CalcAvg(arr));
        Console.WriteLine(FindMax(arr));
    }

    public static int CalcAvg(int[] arr)
    {   
        int sum = 0;

        foreach (int i in arr)
        {
            sum += i;
        }

        int avarage = sum / arr.Length;

        return avarage;
    }

    public static int FindMax(int[] arr)
    {
        int max = arr.Max();
        return max;
    }
}