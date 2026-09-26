namespace ShreeKrupaEngg.Models
{
    public class EnquiryModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CompanyName { get; set; }
        public string ServiceType { get; set; }
        public string Message { get; set; }
        public DateTime SubmittedDate { get; set; } = DateTime.Now;
    }
}
