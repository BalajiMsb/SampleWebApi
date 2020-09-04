namespace TestApi.Models
{
    public class CurrencyDefinition :BaseEntity
    {
      
        public string Code { get; set; }
        public string Name { get; set; }
        public string CountryImage { get; set; }
        public string Status { get; set; }
        public string createdBy { get; set; }
        public string createdDate { get; set; }
        public string updatedBy { get; set; }
        public string updatedDate { get; set; }
    }
}