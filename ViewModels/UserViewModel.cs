using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;
using UserMVC.Models;

namespace UserMVC.Model
{
    public class UserViewModel
    {
        public User UserAdd { get; set; }

        public List<SelectListItem> ListRoles { get;set; }

        public List<SelectListItem> ListGender { get; set; }

        [NotMapped]
        public List<Role> RoleList { get; set; }
    }
}