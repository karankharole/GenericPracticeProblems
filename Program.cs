namespace GenericPracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double maxNumber = GenericTestMax.MaxFloatNumber(64.3, 15.3, 143.2);
            Console.WriteLine(" Maximum float Number is : " + maxNumber);
        }
    }
}