namespace Sample_CV.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }

        public Service(int serviceId, string serviceName)
        {
            ServiceId=serviceId;
            ServiceName=serviceName;
        }
    }
}
