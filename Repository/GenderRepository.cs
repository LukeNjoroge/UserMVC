using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UserMVC.Model;

namespace UserMVC.Repository
{
    public class GenderRepository
    {
        public List<SelectListItem> FindAll()
        {
            List<SelectListItem> result = new List<SelectListItem>();
            result.Add(new SelectListItem { Value = "1", Text = "Male" });
            result.Add(new SelectListItem { Value = "2", Text = "Female" });

            return result;
        }

    }
}