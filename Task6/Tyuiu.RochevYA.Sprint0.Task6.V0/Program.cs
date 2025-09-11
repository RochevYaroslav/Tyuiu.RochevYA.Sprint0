using Tyuiu.RochevYA.Sprint0.Task6.V0.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] numsArray = { 1, 2, 3, 4, 5 };
        Console.WriteLine(DataService.AdditionArray(numsArray));
        Console.WriteLine(DataService.SubstractionArray(numsArray));
        Console.WriteLine(DataService.MultiplicationArray(numsArray));
        Console.ReadKey();
    }
}