namespace ConsoleToDoApp
{
    public class User
    {
        public int UserId { get; set; }

        public static List<User> Users = new List<User>()
        {
            new User{UserId = 1},
            new User{UserId = 2},
            new User{UserId = 3}
        };
    }
}
