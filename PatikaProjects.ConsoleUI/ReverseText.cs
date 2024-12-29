namespace PatikaProjects.ConsoleUI
{
    internal class ReverseText
    {
        // Verilen string ifade içerisindeki karakterleri bir önceki karakter ile yer değiştiren console uygulamasını yazınız.
        public static void Reverse()
        {
            string input;
            string reversedText = "";

            Console.Write("Lütfen bir değer giriniz: ");
            input = Console.ReadLine();
            Console.WriteLine();

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedText += input[i];
            }

            Console.WriteLine($"Ters çevrilmiş hali: {reversedText}");
        }
    }
}
