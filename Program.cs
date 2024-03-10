class Program
{
    public static void Main()
    {
        int[] arr = [2, 4, 6];

        Console.WriteLine(CalcAvg(arr));
    }

    public static int CalcAvg(int[] arr)
    {
        int avarage = arr.Sum() / arr.Length;

        return avarage;
    }
}