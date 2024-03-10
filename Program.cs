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
        int avarage = arr.Sum() / arr.Length;

        return avarage;
    }

    public static int FindMax(int[] arr)
    {
        return arr.Max();
    }
}