using Tyuiu.RochevYA.Sprint0.Task7.V0.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int[] arrayNums = new int[] { 1, 2, 3, 4, 5 };

        for (int i = 0; i < arrayNums.Length; i++)
        {
            Console.Write(arrayNums[i]+", ");
        }

        Console.WriteLine();

        int[] arrayNums2 = new int[] { 1, 2, 3,4, 5 };
        for (int i = 0;i < arrayNums2.Length; i++)
        {
            Console.Write(arrayNums2[i]+", ");
        }

        if (arrayNums.Length==arrayNums2.Length)
        {
            int[] resultArray = DataService.AdditionArrays(arrayNums, arrayNums2);
            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.Write(resultArray[i]+", ");
            }
        }
        else
        {
            Console.WriteLine("Error. The sizes of the arrays not the same");
        }


        Console.ReadKey();
    }
}