namespace PatikaProjects.ConsoleUI
{
    internal class IntegerCouples
    {
        public static void Run()
        {
            /*
             Ekrandan girilen n tane integer ikililerin toplamını alan, eğer sayılar birbirinden farklıysa toplamlarını ekrana yazdıran, sayılar aynıysa toplamının karesini ekrana yazdıran console uygulamasını yazınız.

             Örnek Input: 2 3 1 5 2 5 3 3

             Output: 5 6 7 81
             */

            int[] numbers = { 2, 3, 1, 5, 2, 5, 3, 3 };
            List<int> result = [];

            for (int i = 0; i <= numbers.Length - 1; i += 2)
            {
                if (numbers[i] == numbers[i + 1])
                    result.Add((int)Math.Pow(numbers[i] * numbers[i + 1], 2));
                else
                    result.Add(numbers[i] + numbers[i + 1]);
            }

            result.ForEach(x => Console.Write($"{x} "));
        }
    }
}
