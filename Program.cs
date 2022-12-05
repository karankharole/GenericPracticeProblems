namespace GenericPracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Maximum Interger Number is : " + GenericTestMax<int>.MaxIntegerNumber(30, 20, 10));
            Console.WriteLine("Maximum Float Number is : " + GenericTestMax<float>.MaxIntegerNumber(30.3f, 45.20f, 76.10f));
            Console.WriteLine("Maximum String Number is : " + GenericTestMax<string>.MaxIntegerNumber("AAA", "CCCCC", "HHHH"));
        }
    }
}