namespace Sample_CV.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Service(int serviceId, string serviceName)
        {
            Id=serviceId;
            Name=serviceName;
        }
    }
}
