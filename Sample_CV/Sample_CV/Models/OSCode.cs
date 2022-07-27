namespace Sample_CV.Models
{
    public class OSCode
    {
        public long Id { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }

        public OSCode(long id, string image, string title, string description, string url)
        {
            Id = id;
            Title = title;
            Description = description;
            Url = url;
            Image = image; 
        }
    }
}
