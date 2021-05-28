namespace MyKafka.Domain.Common
{
    public class BaseEntityWithAddress : BaseEntity
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public int ZipCode { get; set; }
        public string Bus { get; set; }
        public string Country { get; set; }
    }
}