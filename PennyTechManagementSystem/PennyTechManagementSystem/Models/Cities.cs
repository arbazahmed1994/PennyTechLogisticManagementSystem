using PennyTechManagementSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PennyTechManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web.Mvc;
    
    public partial class City : BaseModel<City>
    {    
        public int CityID { get; set; }
       
        [Required]
        [Display(Name = "CityID", ResourceType = typeof(NameHandling))]
        public string CityName { get; set; }

        public IEnumerable<BasicModel> Countries { get; set; }
        public IEnumerable<SelectListItem> CountryList { get; set; }
        private int _countryID = 0;
        [Required]
        [Display(Name = "Country", ResourceType = typeof(NameHandling))]
        public int CountryID
        {
            get { return _countryID; }
            set { _countryID = value; }
        }
    }
}
