namespace GenericPracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string maxString = GenericTestMax.MaxStringValue("Apple" , "Peach" , "Banana");
            Console.WriteLine(" Maximum String value is : " + maxString);
        }
    }
}