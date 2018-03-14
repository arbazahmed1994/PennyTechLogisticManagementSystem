using PennyTechManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using PennyTechManagementSystem.Repository;
using PennyTechManagementSystem.Constant;

namespace PennyTechManagementSystem.Models
{
    public class EmployeeUser : BaseModel<EmployeeUser>
    {
        private BasicRepository _basicRep = new BasicRepository();

        // MODEL --

        public IEnumerable<BasicModel> MaritalStatusCode { get; set; }
        public IEnumerable<SelectListItem> MaritalStatusList { get; set; }
        private int _maritalStatusID = 0;
        [Required]
        [Display(Name = "MaritalStatusID", ResourceType = typeof(NameHandling))]
        public int MaritalStatusID
        {
            get { return _maritalStatusID; }
            set { _maritalStatusID = value; }
        }

        
        public IEnumerable<City> Cities { get; set; }
        public IEnumerable<SelectListItem> CityList { get; set; }
        private int _cityID = 0;
        [Required]
        [Display(Name = "CityID", ResourceType = typeof(NameHandling))]
        public int CityID
        {
            get { return _cityID; }
            set { _cityID = value; }
        }

        
        public IEnumerable<BasicModel> Countries { get; set; }
        public IEnumerable<SelectListItem> CountriesList { get; set; }
        private int _nationality = 0;
        [Required]
        [Display(Name = "Nationality", ResourceType = typeof(NameHandling))]
        public int Nationality
        {
            get { return _nationality; }
            set { _nationality = value; }
        }

        
        public IEnumerable<BasicModel> Religion { get; set; }
        public IEnumerable<SelectListItem> ReligionList { get; set; }
        private int _religionID = 0;
        [Required]
        [Display(Name = "ReligionID", ResourceType = typeof(NameHandling))]
        public int ReligionID
        {
            get { return _religionID; }
            set { _religionID = value; }
        }


        public IEnumerable<BasicModel> Educations { get; set; }
        public IEnumerable<SelectListItem> EducationList { get; set; }
        private int _educationID = 0;
        [Required]
        [Display(Name = "EducationID", ResourceType = typeof(NameHandling))]
        public int EducationID
        {
            get { return _educationID; }
            set { _educationID = value; }
        }


        public IEnumerable<Department> Departments { get; set; }
        public IEnumerable<SelectListItem> DepartmentList { get; set; }
        private int _departmentCode = 0;
        [Required]
        [Display(Name = "DepartmentCode", ResourceType = typeof(NameHandling))]
        public int DepartmentCode
        {
            get { return _departmentCode; }
            set { _departmentCode = value; }
        }


        public IEnumerable<Designation> Designations { get; set; }
        public IEnumerable<SelectListItem> DesignationList { get; set; }
        private int _designationID = 0;
        [Required]
        [Display(Name = "DesignationID", ResourceType = typeof(NameHandling))]
        public int DesignationID
        {
            get { return _designationID; }
            set { _designationID = value; }
        }


        public IEnumerable<BasicModel> Genders { get; set; }
        public IEnumerable<SelectListItem> GenderList { get; set; }
        private int _genderID = 0;
        [Required]
        [Display(Name = "GenderID", ResourceType = typeof(NameHandling))]
        public int GenderID
        {
            get { return _genderID; }
            set { _genderID = value; }
        }
        
        public EmployeeUser()
        {
            DesignationsRepository _designationRep = new DesignationsRepository();
            Designations = _designationRep.Get();
            DesignationList = Designations.ToDesignationSelectListItems(DesignationID);

            DepartmentRepository _departmentRep = new DepartmentRepository();
            Departments = _departmentRep.Get();
            DepartmentList = Departments.ToDepartmentSelectListItems(DepartmentCode);

            CitiesRepository _citiesRep = new CitiesRepository();
            Cities = _citiesRep.Get();
            CityList = Cities.ToCitySelectListItems(CityID);
            
            ProcedureNameHandling.GetSP = "GetCountry";
            Countries = _basicRep.Get();
            CountriesList = Countries.ToCountrySelectListItems(Nationality);

            ProcedureNameHandling.GetSP = "GetGender";
            Genders = _basicRep.Get();
            GenderList = Genders.ToGenderSelectListItems(GenderID);

            ProcedureNameHandling.GetSP = "GetEducation";
            Educations = _basicRep.Get();
            EducationList = Educations.ToEducationSelectListItems(EducationID);

            ProcedureNameHandling.GetSP = "GetReligion";
            Religion = _basicRep.Get();
            ReligionList = Religion.ToReligionSelectListItems(ReligionID);

            ProcedureNameHandling.GetSP = "GetMaritalStatus";
            MaritalStatusCode = _basicRep.Get();
            MaritalStatusList = MaritalStatusCode.ToMaritalStatusSelectListItems(MaritalStatusID);
        }


        // UN_REQUIRED --

        public int UserCode { get; set; }
        
        [Display(Name = "FatherIdentityCardNumber" , ResourceType = typeof(NameHandling))]
        public string FatherIdentityCardNumber { get; set; }
        
        [Display(Name = "Phone" , ResourceType = typeof(NameHandling))]
        public string Phone { get; set; }
        
        [Display(Name = "Mobile" , ResourceType = typeof(NameHandling))]
        public string Mobile { get; set; }
        
        [Display(Name = "Address" , ResourceType = typeof(NameHandling))]
        public string Address { get; set; }
        
        [Display(Name = "Salary" , ResourceType = typeof(NameHandling))]
        public double Salary { get; set; }
        
        [Display(Name = "EOBINumber" , ResourceType = typeof(NameHandling))]
        public string EOBINumber { get; set; }
        
        [Display(Name = "NTSNumber" , ResourceType = typeof(NameHandling))]
        public string NTSNumber { get; set; }

        public int EntryUser { get; set; }

        [DataType(DataType.Date)]
        public DateTime EntryDate { get; set; }

        // COPY of ID for NAME
        public string MaritalStatusName { get; set; }
        public string GenderName { get; set; }
        public string CityName { get; set; }
        public string CountryName { get; set; }
        public string ReligionName { get; set; }
        public string EducationName { get; set; }
        public string DepartmentName { get; set; }
        public string DesignationName { get; set; }
        public string NAME { get; set; }

        
        // REQUIRED --

        [Required]
        [Display(Name = "FullName" , ResourceType = typeof(NameHandling))]
        public string FullName { get; set; }

        [Required]
        [Display(Name = "FatherName", ResourceType = typeof(NameHandling))]
        public string FatherName { get; set; }

        [Required]
        [Display(Name = "IdentityCardNumber", ResourceType = typeof(NameHandling))]
        public string IdentityCardNumber { get; set; }

        [DataType(DataType.Date)]
        private DateTime _dob = DateTime.Now.Date;
        [Required]
        [Display(Name = "DateOfBirth", ResourceType = typeof(NameHandling))]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth
        {
            get { return _dob; }
            set { _dob = value; }
        }

        [Required]
        [Display(Name = "Experiance", ResourceType = typeof(NameHandling))]
        public string Experiance { get; set; }

        [Required]
        [Display(Name = "Username", ResourceType = typeof(NameHandling))]
        public string Username { get; set; }

        [Required]
        [Display(Name = "Password", ResourceType = typeof(NameHandling))]
        public string Password { get; set; }

    }
}
