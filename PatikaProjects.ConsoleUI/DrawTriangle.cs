namespace PatikaProjects.ConsoleUI
{
    public class DrawTriangle
    {
        // Kullanıcıdan alınan boyut bilgisine göre console'a Üçgen çizen uygulamayı yazınız.

        public static void GetTriangle()
        {
            int height = 0;

            Console.Write("Boyut bilgisini giriniz: ");
            height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
