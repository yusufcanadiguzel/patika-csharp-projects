namespace PatikaProjects.ConsoleUI
{
    public class DrawCircle
    {
        // Kullanıcıdan alınan yarıçapa göre console'a Daire çizen uygulamayı yazınız.

        public static void GetCircle()
        {
            int radius;

            Console.Write("Yarıçapı giriniz: ");
            radius = int.Parse(Console.ReadLine()!);

            for (int y = -radius; y <= radius; y++)
            {
                for (int x = -radius; x <= radius; x++)
                {
                    double distance = Math.Sqrt(x * x + y * y);
                    if (distance >= radius - 0.5 && distance <= radius + 0.5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
