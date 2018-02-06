
using System;
namespace WindowsFormsApplication2
{
    public class Navbar
    {
        public int MenuID { get; set; }
        public string LinkText { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public string Icon { get; set; }
        public Nullable<int> ParentID { get; set; }
        public Nullable<int> ShowInMenu { get; set; }
        public Nullable<int> IsParent { get; set; }
        public Nullable<int> SequenceNumber { get; set; }
        public Nullable<int> IsNested { get; set; }
    }
}
