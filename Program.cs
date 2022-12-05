namespace GenericPracticeProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string maxString = GenericTestMax.MaxStringValue("Apple" , "BananaS" , "Peach");
            Console.WriteLine(" Maximum String value is : " + maxString);
        }
    }
}