namespace PatikaProjects.ConsoleUI
{
    internal class AreaCalculator
    {
        /*
         Alan Hesaplama
         C# Console uygulaması oluşturarak aşağıdaki gereksinimleri karşılayan uygulamayı yazınız.

         İşlem yapılmak istenen geometrik şekli kullanıcıdan alınmalı (Daire, Üçgen, Kare, Dikdörtgen vb..)
         Seçilen şekle göre, kenar bilgilerin kullanıcıdan alınmalı
         Hesaplanmak istenen boyutu kullanıcıdan alınmalı (Çevre, Alan, Hacim vb..)
         Hesap sonucunu anlaşılır şekilde geri döndürmeli.
         Dikkat Edilmesi Gereken Noktalar :

         Kod tekrarından kaçınılmalı
         Single Responsibility kuralına uygun şekilde, uygulama sınıflara ve metotlara bölünmeli. 
         */

        public static void Calculate()
        {
            int userInput;

            bool isFinished = false;

            do
            {
                Console.Write("Lütfen hesaplamak istediğiniz şekli seçiniz (1)Daire (2)Üçgen (3)Kare (4)Dikdörtgen : ");
                userInput = int.Parse(Console.ReadLine()!);
                Console.WriteLine();

                switch (userInput)
                {
                    case 1:
                        CalculateCircle();
                        CheckOperationEnd();
                        break;
                    case 2:
                        CalculateTriangle();
                        CheckOperationEnd();
                        break;
                    case 3:
                        CalculateSquare();
                        CheckOperationEnd();
                        break;
                    case 4:
                        CalculateRectangle();
                        CheckOperationEnd();
                        break;
                    default:
                        Console.WriteLine("Hatalı giriş yaptınız.");
                        break;
                }
            }
            while (!isFinished);

            void CalculateCircle()
            {
                double area;
                int radius;

                Console.WriteLine("Daire Alanı Hesaplama");
                Console.WriteLine("---------------------");

                Console.Write("Lütfen yarıçap bilgisini giriniz: ");
                radius = int.Parse(Console.ReadLine()!);
                Console.WriteLine();

                area = Math.PI * Math.Pow(radius, 2);

                Console.WriteLine($"Dairenin alanı = {area}");
            }

            void CalculateTriangle()
            {
                double area;
                int bottom;
                int height;

                Console.WriteLine("Üçgen Alanı Hesaplama");
                Console.WriteLine("---------------------");

                Console.Write("Lütfen taban uzunluğu bilgisini giriniz: ");
                bottom = int.Parse(Console.ReadLine()!);
                Console.WriteLine();

                Console.Write("Lütfen yükseklik bilgisini giriniz: ");
                height = int.Parse(Console.ReadLine()!);
                Console.WriteLine();

                area = bottom * (height / 2);

                Console.WriteLine($"Üçgenin alanı = {area}");
            }

            void CalculateSquare()
            {
                double area;
                int side;

                Console.WriteLine("Kare Alanı Hesaplama");
                Console.WriteLine("---------------------");

                Console.Write("Lütfen kenar uzunluğu bilgisini giriniz: ");
                side = int.Parse(Console.ReadLine()!);
                Console.WriteLine();

                area = side * side;

                Console.WriteLine($"Karenin alanı = {area}");
            }

            void CalculateRectangle()
            {
                double area;
                int longSide;
                int shortSide;

                Console.WriteLine("Dikdörtgen Alanı Hesaplama");
                Console.WriteLine("---------------------");

                Console.Write("Lütfen uzun kenar uzunluğunu giriniz: ");
                longSide = int.Parse(Console.ReadLine()!);
                Console.WriteLine();

                Console.Write("Lütfen kısa kenar uzunluğunu giriniz: ");
                shortSide = int.Parse(Console.ReadLine()!);
                Console.WriteLine();

                area = shortSide * longSide;

                Console.WriteLine($"Dikdörtgenin alanı = {area}");
            }

            void CheckOperationEnd()
            {
                string userInput = "";

                Console.WriteLine("Başka bir hesaplama yapmak ister misiniz? (e/h):");
                userInput = Console.ReadLine()!;

                isFinished = (userInput == "e") ? false : true;
            }
        }
    }
}
