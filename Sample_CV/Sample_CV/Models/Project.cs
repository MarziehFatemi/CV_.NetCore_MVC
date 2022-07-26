namespace Sample_CV.Models
{
    public class Project
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string  Discription { get; set; }
        public string Client { get; set; }
        public string Image { get; set; }


        public Project(long id, string name, string discription, string client, string image)
        {
            Id = id;
            Name = name;
            Discription = discription;
            Client = client;
            Image = image;
        }
    }
}
