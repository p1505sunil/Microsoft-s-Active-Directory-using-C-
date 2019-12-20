using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class User
    {
        public int Id { get; set; }
        [Display(Name = "Display Name")]
        public string DisplayName { get; set; }
        public string Samaccountname { get; set; }
    }

    public class Group
    {
        public int Id { get; set; }
        [Display(Name = "Group Name")]
        public string GroupName { get; set; }

    }
}