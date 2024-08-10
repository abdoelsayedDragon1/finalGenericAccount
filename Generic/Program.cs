namespace Generic
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            bool IsEqual = ClsCalculator.AreEqual(10, 20);
            bool IsEqual2 = ClsCalculator.AreEqual("ABC", "ABC0");
            bool IsEqual3 = ClsCalculator.AreEqual(10.5, 20.5);
            if (IsEqual2)
            {
                Console.WriteLine("Both are Equal");
            }
            else
            {
                Console.WriteLine("Both are Not Equal");
            }
            Console.WriteLine();


            //bool IsEqual = ClsCalculator.AreEqual<int>(10, 20);
            //bool IsEqual2 = ClsCalculator.AreEqual<string>("ABC", "ABC");
            //bool IsEqual3 = ClsCalculator.AreEqual<double>(10.5, 20.5);
            //bool IsEqual4 = ClsCalculator.AreEqual<Account>(new(1,"abdo"),new(2, "abdo"));

            //if (IsEqual4)
            //{
            //    Console.WriteLine("Both are Equal");
            //}
            //else
            //{
            //    Console.WriteLine("Both are Not Equal");
            //}
            //Console.ReadKey();



        }
    }
}
