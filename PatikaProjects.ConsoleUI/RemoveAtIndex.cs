namespace PatikaProjects.ConsoleUI
{
    public class RemoveAtIndex
    {
        public static void RemoveCharacter()
        {
            // Ekrandan bir string bir de sayı alan (aralarında virgül ile), ilgili string ifade içerisinden verilen indexteki karakteri çıkartıp ekrana yazdıran console uygulasını yazınız.

            string input;
            int index;

            Console.Write("Lütfen bir kelime giriniz: ");
            input = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Silmek istediğiniz index numarasını giriniz: ");
            index = int.Parse(Console.ReadLine()!);
            Console.WriteLine();

            input = input.Remove(index, 1);

            Console.WriteLine(input);
        }
    }
}
