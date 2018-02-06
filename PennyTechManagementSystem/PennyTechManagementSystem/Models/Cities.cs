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
    
    public partial class City
    {    
        public int CityID { get; set; }
        public string CityName { get; set; }
        public int CountryID { get; set; }
    
        public IEnumerable<Country> CountryList { get; set; }
    }
}
