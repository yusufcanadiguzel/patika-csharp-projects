namespace PatikaProjects.ConsoleUI
{
    internal static class FibonacciAverage
    {
        public static void GetFibonacciAverage()
        {
            // Kulanıcıdan alınan derinliğe göre fibonacci serisindeki rakamların ortalamasını alıp ekrana yazdıran uygulamayı yazınız.
            // Fibonacci sayıları: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377

            int userInput;
            int total = 2;
            int numberPrev = 1;
            int numberNext = 1;
            double result = 0;

            Console.Write("Bir aralık giriniz: ");
            userInput = Convert.ToInt32(Console.ReadLine());


            for (int i = 2; i < userInput; i++)
            {
                total = numberPrev + numberNext;
                numberPrev = numberNext;
                numberNext = total;
                result += total;
            }

            Console.WriteLine($"Fibonacci ortalaması: {result / userInput}");
        }
    }
}
