namespace ConsoleToDoApp
{
    // Kart içeriği: Başlık, İçerik, Kullanıcı, Boyut, Durum
    public class Card
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public Sizes Size { get; set; }
        public Status Status { get; set; }

        public static List<Card> Cards = new List<Card>()
        {
            new Card{Title = "Projeyi oluştur.", Description = "İsterlere göre oluşturulmalı.", UserId = 1, Size = Sizes.M, Status = Status.Done},
            new Card{Title = "Nesneleri oluştur.", Description = "İsterlere göre oluşturulmalı.", UserId = 2, Size = Sizes.M, Status = Status.InProgress},
            new Card{Title = "Projeyi tamamla.", Description = "İsterlere göre tamamlanmalı.", UserId = 3, Size = Sizes.M, Status = Status.ToDo}
        };
    }

    public enum Sizes
    {
        XS, S, M, L, XL
    }

    public enum Status
    {
        ToDo, InProgress, Done
    }
}
