using PennyTechManagementSystem.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PennyTechManagementSystem.Models
{
    public class NavbarModel
    {
        public IEnumerable<NavbarItem> NavbarTop(int roleID)
        {
            var _rep = new NavbarRepository();
            return _rep.Get();
        }
    }

    public class NavbarItem : BaseModel<NavbarItem>
    {
        public int MenuID { get; set; }
        public string LinkText { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string Icon { get; set; }
        public int ParentID { get; set; }
        public int IsParent { get; set; }
        public int ShowInMenu { get; set; }
        public int SequenceNumber { get; set; }
        public int IsNested { get; set; }
        public int NestedParent { get; set; }
    }
}