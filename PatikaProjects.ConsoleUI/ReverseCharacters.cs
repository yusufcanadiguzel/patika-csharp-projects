namespace PatikaProjects.ConsoleUI
{
    internal class ReverseCharacters
    {
        public static void Run()
        {
            // Verilen string ifade içerisindeki ilk ve son karakterin yerini değiştirip tekrar ekrana yazdıran console uygulamasını yazınız.

            string input = "";
            string newText = "";

            Console.Write("Lütfen istediğiniz değeri giriniz: ");
            input = Console.ReadLine()!;
            Console.WriteLine();

            newText += input.Last();
            newText += input.Substring(1, input.Length - 2);
            newText += input.First();

            Console.WriteLine($"Yeni değer: {newText}");
        }
    }
}
