namespace PatikaProjects.ConsoleUI
{
    internal class CheckConsonants
    {
        public static void Run()
        {
            // Verilen string ifade içerisinde yanyana 2 tane sessiz varsa ekrana true, yoksa false yazdıran console uygulamasını yazınız.

            string input;
            char[] consonants = { 'a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö' };

            Console.Write("Lütfen kontrol etmek istediğiniz değeri giriniz: ");
            input = Console.ReadLine()!.ToLower();
            Console.WriteLine();

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (!consonants.Contains(input[i]) && !consonants.Contains(input[i + 1]))
                {
                    Console.WriteLine("True");
                    return;
                }
            }

            Console.WriteLine("False");
        }
    }
}
