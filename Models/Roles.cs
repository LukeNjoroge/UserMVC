using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserMVC.Model
{
    public class Roles
    {
        public int RoleID { get; set; }
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }
        public int RoleStatus { get; set; }
    }
}
