/* 
 Uygulama çalıştığında pre-defined olarak belirlenen kategoriler oylamaya sunulmak üzere listelenmelidir. Yalnızca sisemde kayırlı olan kullanıcılar oy verebilir. Oylama sırasında öncelikle kullanıcının username'i istenmelidir. Eğer sistemde kayıtlı değilse kayıt olmasına imkan sağlanmalı ve kaldığı yerden oylamaya devam edebilmelidir. Kategoriler isteğe bağlı olarak belirlenebilir.
 */

using VotingApp;

bool isFinished = false;

string username;

int totalVote = 0;

do
{
    Console.Write("Lütfen kullanıcı adınızı giriniz: ");
    username = Console.ReadLine()!;
    Console.WriteLine();

    if (CheckUser(username))
        UseVote();
    else
        Register();
} while (!isFinished);

ShowResults();

bool CheckUser(string usernameCheck)
{
    if (User.Users.FirstOrDefault(u => u.Username.Equals(usernameCheck)) is not null)
        return true;
    else
        return false;
}

void UseVote()
{
    string input;

    Console.WriteLine("Kategoriler");
    Console.WriteLine("-----------");

    Category.Categories.ForEach(c => Console.WriteLine($"{c.Id} - {c.Name}"));

    Console.Write("Oy vermek istediğiniz kategorinin numarasını giriniz: ");
    input = Console.ReadLine()!;
    Console.WriteLine();

    ConfirmVote(int.Parse(input));

    isFinished = true;
}

void ConfirmVote(int id)
{
    var category = Category.Categories.Where(c => c.Id == id).FirstOrDefault();
    category.TotalVote++;

    totalVote++;
}

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
                return;
            }
            else
            {
                User.Users.Add(new User { Username = newUsername });
                Console.WriteLine("Kayıt işlemi başarılı!");
                isSuccess = true;
            }
        }
    }
    while (!isSuccess);
}

void ShowResults()
{
    Console.WriteLine("Sonuçlar");
    Console.WriteLine("--------\n");

    Console.WriteLine($"Toplam kullanılan oy: {totalVote}");
    Category.Categories.ForEach(c => Console.WriteLine($"{c.Name} - Oy: {c.TotalVote} - Genel Yüzdeye Oranı: %{(double)c.TotalVote / totalVote * 100}"));
}