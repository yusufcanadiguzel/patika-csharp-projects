using ConsoleToDoApp;

bool isDone = false;

do
{
    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
    Console.WriteLine("*******************************************");
    Console.WriteLine("(1) Board Listelemek (2) Board'a Kart Eklemek (3) Board'dan Kart Silmek (4) Kart Taşımak");

    // Uygulama ilk başladığında kullanıcıya yapmak istediği işlem seçtirilir.
    Console.Write("Tercihiniz: ");
    var choice = Console.ReadLine();
    Console.WriteLine();

    switch (choice)
    {
        case "1":
            ListBoard();
            break;
        case "2":
            AddCard();
            break;
        case "3":
            DeleteCard();
            break;
        case "4":
            UpdateCard();
            break;
        default:
            break;
    }

} while (!isDone);

// Board'ı ekrana yazar
void ListBoard()
{
    // TODO Line
    Console.WriteLine("TODO Line");
    Console.WriteLine("************************");
    ListCards(cards: Card.Cards.Where(c => c.Status == Status.ToDo).ToList());

    // IN PROGRESS Line
    Console.WriteLine("IN PROGRESS Line");
    Console.WriteLine("************************");
    ListCards(cards: Card.Cards.Where(c => c.Status == Status.InProgress).ToList());

    // Done Line
    Console.WriteLine("IN PROGRESS Line");
    Console.WriteLine("************************");
    ListCards(cards: Card.Cards.Where(c => c.Status == Status.Done).ToList());
}

// Kartları ekrana yazdırır
void ListCards(List<Card> cards)
{
    if (cards is null)
    {
        Console.WriteLine("~ BOŞ ~");
    }
    else
    {
        foreach (var card in cards)
        {
            Console.WriteLine($"Başlık      : {card.Title}");
            Console.WriteLine($"İçerik      : {card.Description}");
            Console.WriteLine($"Atanan Kişi : {card.UserId}");
            Console.WriteLine($"Büyüklük    : {card.Size}\n");
        }
    }
}

// Kart ekler
void AddCard()
{
    var card = new Card();

    Console.Write("Başlık Giriniz                                  :");
    card.Title = Console.ReadLine()!;
    Console.WriteLine();

    Console.Write("İçerik Giriniz                                  :");
    card.Description = Console.ReadLine()!;
    Console.WriteLine();

    Console.Write("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
    card.Size = (Sizes)Convert.ToInt32(Console.ReadLine()!);
    Console.WriteLine();

    Console.Write("Kişi Seçiniz                                    :");
    int userId = Convert.ToInt32(Console.ReadLine())!;
    if(!User.Users.Where(u => u.UserId == userId).Any())
    {
        Console.WriteLine("Hatalı giriş yaptınız. İşlem iptal edilmiştir.");
        return;
    }
    card.UserId = userId;
    Console.WriteLine();

    Card.Cards.Add(card);
    Console.WriteLine("Kart eklendi.");
}

// Kart siler
void DeleteCard()
{
    DeleteStart:
    Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
    Console.Write("Lütfen kart başlığını yazınız:");
    var cardTitle = Console.ReadLine()!;
    Console.WriteLine();

    var cards = Card.Cards.Where(c => c.Title.Equals(cardTitle));

    if (cards is null)
    {
        Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
        Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
        Console.WriteLine("* Yeniden denemek için : (2)");

        Console.Write("Tercih yapınız: ");
        var choice = Console.ReadLine()!;

        if (choice == "1")
            return;
        else
            goto DeleteStart;
    }
    else
    {
        foreach (var card in cards)
        {
            Card.Cards.Remove(card);
            Console.WriteLine("Silme işlemi başarılı.");
        }
    }
}

// Kartın durumunu günceller
void UpdateCard()
{
UpdateStart:
    Console.WriteLine("Öncelikle güncellemek istediğiniz kartı seçmeniz gerekiyor.");
    Console.Write("Lütfen kart başlığını yazınız:");
    var cardTitle = Console.ReadLine()!;
    Console.WriteLine();

    var card = Card.Cards.Where(c => c.Title.Contains(cardTitle)).FirstOrDefault();

    if (card is null)
    {
        Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
        Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
        Console.WriteLine("* Yeniden denemek için : (2)");

        Console.Write("Tercih yapınız: ");
        var choice = Console.ReadLine()!;

        if (choice == "1")
            return;
        else
            goto UpdateStart;
    }
    else
    {
        Console.WriteLine("Bulunan Kart Bilgileri:");
        Console.WriteLine("**************************************");
        Console.WriteLine($"Başlık : {card.Title} İçerik : {card.Description} Atanan Kişi : {card.UserId} Büyüklük : {card.Size} Line : {card.Status}");
        Console.WriteLine("Lütfen taşımak istediğiniz Line'ı seçiniz: (1) TODO (2) IN PROGRESS (3) DONE");

        Console.Write("Tercihiniz: ");
        card.Status = (Status)Convert.ToInt32(Console.ReadLine()!);
        Console.WriteLine();

        Console.WriteLine("İşlem başarılı.");
    }
}