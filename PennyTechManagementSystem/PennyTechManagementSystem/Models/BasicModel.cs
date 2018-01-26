using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.Models
{
    public class BasicModel : BaseModel<BasicModel>
    {

        //STATUS

        public int StatusID { get; set; }

        [Display(Name = "StatusName", ResourceType = typeof(NameHandling))]
        public string StatusName { get; set; }

        //RELIGION

        public int ReligionID { get; set; }

        [Display(Name = "ReligionName", ResourceType = typeof(NameHandling))]
        public string ReligionName { get; set; }

        //COUNTRIES

        public int CountryID { get; set; }

        [Display(Name = "CountryName", ResourceType = typeof(NameHandling))]
        public string CountryName { get; set; }

        //MARITAL STATUS

        public int MaritalStatusID { get; set; }

        [Display(Name = "MaritalStatusName", ResourceType = typeof(NameHandling))]
        public string MaritalStatusName { get; set; }

        //GENDER

        public int GenderID { get; set; }

        [Display(Name = "GenderName", ResourceType = typeof(NameHandling))]
        public string GenderName { get; set; }

        //EDUCATION

        public int EducationID { get; set; }

        [Display(Name = "EducationName", ResourceType = typeof(NameHandling))]
        public string EducationName { get; set; }

        //COMPANY BUSINESS TYPE

        public int CompanyBusinessTypeID { get; set; }

        [Display(Name = "CompanyBusinessTypeName", ResourceType = typeof(NameHandling))]
        public string CompanyBusinessTypeName { get; set; }

        //COLORS

        public int ColorID { get; set; }

        [Display(Name = "ColorName", ResourceType = typeof(NameHandling))]
        public string ColorName { get; set; }

    }
}