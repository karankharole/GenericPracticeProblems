namespace GenericPracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Maximum Interger Number is : " + GenericTestMax.MaxIntNumber<int>(30, 20, 10));
            Console.WriteLine("Maximum Float Number is : " + GenericTestMax.MaxIntNumber<float>(30.3f, 45.20f, 76.10f));
            Console.WriteLine("Maximum String Number is : " + GenericTestMax.MaxIntNumber<string>("78", "34", "10"));
        }
    }
}