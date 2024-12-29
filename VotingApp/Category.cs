namespace VotingApp
{
    internal class Category
    {
        static Category()
        {
            Categories = new List<Category>
            {
                new Category { Id = 1, Name = "Film Kategorileri", TotalVote = 0 },
                new Category { Id = 2, Name = "Tech Stack Kategorileri", TotalVote = 0 },
                new Category { Id = 3, Name = "Spor Kategorileri", TotalVote = 0}
            }; 
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalVote { get; set; }

        public static List<Category> Categories;
    }
}
