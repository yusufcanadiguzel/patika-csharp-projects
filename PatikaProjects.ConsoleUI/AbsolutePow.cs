namespace PatikaProjects.ConsoleUI
{
    internal class AbsolutePow
    {
        public static void Run()
        {
            //Ekrandan girilen n tane sayının 67'den küçük yada büyük olduğuna bakan. Küçük olanların farklarının toplamını, büyük ise de farkların mutlak karelerini alarak toplayıp ekrana yazdıran console uygulamasını yazınız.

            int numberCounter = 0;
            int lessTotal = 0;
            int greaterTotal = 0;

            Console.Write("Lütfen kaç sayı girmek istediğinizi giriniz: ");
            numberCounter = int.Parse(Console.ReadLine()!);
            Console.WriteLine();

            for (int i = 0; i < numberCounter; i++)
            {
                int number;

                Console.Write("Lütfen bir sayı giriniz: ");
                number = int.Parse(Console.ReadLine()!);
                Console.WriteLine();

                if (number < 67)
                    lessTotal += 67 - number;
                else
                    greaterTotal += (int)Math.Pow(number - 67, 2);
            }

            Console.WriteLine($"Küçük sayıların mutlak farklarının toplamı: {lessTotal}");
            Console.WriteLine($"Büyük sayılarının mutlak farklarının karelerinin toplamı: {greaterTotal}");
        }
    }
}
