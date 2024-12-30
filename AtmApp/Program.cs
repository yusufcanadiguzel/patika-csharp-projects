/* 
 Uygulama ilk çalıştığında kullanıcıdan yamak istediği işlemi öğrenmelidir. Bunlar ATM üzerinden yapılabilecek temem işlemledir. Para çekme, para yatırma, ödeme yapma vs.. İsteğe bağlı olarak genişletilebilir. Öncelikle ATM ye giriş yapan kullanıcın sistemde kayıtlı bir kullanıcı olduğundan emin olunmalıdır.

Uygulamada bir de gün sonu seçeneği olmalıdır. Gün sonu alınmak istendiğinde, gün içerisinde yapılan transaction ların logları ve fraud olabilecek yani hatalı giriş denemeleri log gösterilmelidir. Aynı client'ın bilgisayarında belirlenen bir lokasyona EOD_Tarih(DDMMYYY formatında).txt adında bir dosyaya yazılmalıdır.
 */

using AtmApp;

bool isFinished = false;

string username;

int totalVote = 0;

User user;

do
{
    Console.Write("Lütfen kullanıcı adınızı giriniz: ");
    username = Console.ReadLine()!;
    Console.WriteLine();

    if (CheckUser(username))
        MainMenu();
    else
        Register();
} while (!isFinished);

// Kullanıcı teyiti
bool CheckUser(string usernameCheck)
{
    user = User.Users.Where(u => u.Username.Equals(usernameCheck)).FirstOrDefault()!;

    if (user is not null)
    {
        return true;
    }

    else
        return false;
}

// Ana menü
void MainMenu()
{
    string optionNumber;

    Console.WriteLine("Ana Menü");
    Console.WriteLine("-----------");
    Console.WriteLine("1 - Para Çekme");
    Console.WriteLine("2 - Para Yatırma");
    Console.WriteLine("3 - Gün Sonu Raporu");


    Console.Write("Lütfen yapmak istediğiniz işlemin numarasını giriniz: ");
    optionNumber = Console.ReadLine()!;
    Console.WriteLine();

    switch (optionNumber)
    {
        case "1":
            Withdraw(user);
            break;
        case "2":
            Deposit(user);
            break;
        case "3":
            EndDay();
            break;
        default:
            break;
    }
}

// Para çekme işlemi
void Withdraw(User user)
{
    decimal amount;

    bool withdrawSuccess = false;

    do
    {
        Console.WriteLine("Lütfen çekmek istediğiniz tutarı giriniz: ");
        amount = decimal.Parse(Console.ReadLine()!);
        Console.WriteLine();

        if (user.Balance >= amount)
        {
            user.Balance -= amount;
            Console.WriteLine($"Kalan bakiyeniz: {user.Balance}");
            withdrawSuccess = true;
            LogManager.Log($"{user.Username} adlı kullanıcı hesabından para çekti.");
        }
        else
        {
            Console.WriteLine("Bakiyeniz işlem için yeterli değil. Ana menüye yönlendiriliyor...");
            LogManager.Log($"{user.Username} adlı kullanıcı para çekme işleminde geçersiz tutar girdi.");
            withdrawSuccess = true;
        }
    }
    while (!withdrawSuccess);
}

// Kayıt olma işlemi
void Register()
{
    string input;
    string newUsername;

    bool isSuccess = false;

    do
    {
        Console.Write("Kullanıcı adı bulunamadı. Kayıt olmak ister misiniz?(e/h): ");
        input = Console.ReadLine()!;
        Console.WriteLine();

        if (input == "h")
        {
            isFinished = true;
            return;
        }
        else
        {
            Console.Write("Lütfen istediğiniz kullanıcı adını giriniz: ");
            newUsername = Console.ReadLine()!;
            Console.WriteLine();

            if (CheckUser(newUsername))
            {
                Console.WriteLine("Kullanıcı adı sistemde kayıtlı! İşlem sonlandırılıyor...");
                LogManager.Log($"{newUsername} sistemde kayıtlı olmasına rağmen tekrar kaydolmaya çalıştı.");
                return;
            }
            else
            {
                User.Users.Add(new User { Username = newUsername });
                Console.WriteLine("Kayıt işlemi başarılı!");
                isSuccess = true;
                LogManager.Log($"{username} adlı kullanıcı sisteme kayıt oldu.");
            }
        }
    }
    while (!isSuccess);
}

// Para yatırma işlemi
void Deposit(User user)
{
    decimal amount;

    bool depositSuccess = false;

    do
    {
        Console.WriteLine("Lütfen yatırmak istediğiniz tutarı giriniz: ");
        amount = decimal.Parse(Console.ReadLine()!);
        Console.WriteLine();

        user.Balance += amount;
        Console.WriteLine($"Yeni bakiyeniz: {user.Balance}");
        depositSuccess = true;
        LogManager.Log($"{user.Username} adlı kullanıcı hesabına para yatırdı.");
    }
    while (!depositSuccess);
}

void EndDay()
{
    Console.WriteLine("Gün Sonu Raporu");
    Console.WriteLine("--------\n");

    LogManager.GetLogs();

    isFinished = true;
}