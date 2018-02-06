
using System;
namespace WindowsFormsApplication2
{
    public class CompanyProfile
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int CompanyID { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string OwnerName { get; set; }
        public int BusinessTypeID { get; set; }
        public string NTNno { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Website { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        public string ContactNumber1 { get; set; }
        public string ContactNumber2 { get; set; }
        public string ContactNumber3 { get; set; }
        public string FaxNumber1 { get; set; }
        public string FaxNumber2 { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsUpdated { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime DeletedDate { get; set; }
        public int UpdatedBy { get; set; }
        public int DeletedBy { get; set; }
    
    }
}
