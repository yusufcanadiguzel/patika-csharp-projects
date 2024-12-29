﻿namespace VotingApp
{
    internal class User
    {
        static User()
        {
            Users = new List<User>()
            {
                new User() {Username = "admin"}
            };
        }

        public string Username { get; set; }
        public static List<User> Users;
    }
}