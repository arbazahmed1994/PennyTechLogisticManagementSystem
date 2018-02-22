using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.Models
{
    public class LoginModel : BaseModel<LoginModel>
    {

        public int UserCode { get; set; }

        public string FullName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

    }
}