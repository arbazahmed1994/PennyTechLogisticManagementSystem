using PennyTechManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PennyTechManagementSystem.Models
{
    public class EmployeeUser
    {
        public string UserCode { get; set; }
        public string FullName { get; set; }
        public string FatherName { get; set; }
        public string IdentityCardNumber { get; set; }
        public string FatherIdentityCardNumber { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public double Salary { get; set; }
        public string Experiance { get; set; }
        public string EOBINumber { get; set; }
        public string NTSNumber { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsUpdated { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime DeletedDate { get; set; }
        public int UpdatedBy { get; set; }
        public int DeletedBy { get; set; }

        public IEnumerable<MaritalStatu> MaritalStatusCode { get; set; }
        public int MaritalStatusID { get; set; }

        public IEnumerable<City> CityList { get; set; }
        public int CityID { get; set; }

        public IEnumerable<Country> CountriesList { get; set; }
        public int Nationality { get; set; }

        public IEnumerable<Religion> ReligionList { get; set; }
        public int ReligionID { get; set; }

        public IEnumerable<Education> EducationList { get; set; }
        public int EducationID { get; set; }

        public IEnumerable<Department> DepartmentList { get; set; }
        public string DepartmentCode { get; set; }

        public IEnumerable<Designation> DesignationList { get; set; }
        public int DesignationID { get; set; }

        public IEnumerable<Gender> GenderList { get; set; }
        public int GenderID { get; set; }
        
    }
}
