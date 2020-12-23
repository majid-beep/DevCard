namespace DevCard_mvc.Models
{
    public class Article
    {
        public long Id { set; get; }
        public string Title { set; get; }
        public string Description { set; get; }
        public string Image { set; get; }

        public Article(long id, string title, string description, string image)
        {
            Id = id;
            Title = title;
            Description = description;
            Image = image;
        }
    }
}

