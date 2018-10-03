using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace WebApplication1.Models
{
    public class LogonController : Controller
    {
        public partial class Users
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Account { get; set; }
            public string City { get; set; }
            public string Email { get; set; }
            public string Address { get; set; }
            public string BirthDay { get; set; }
            public string AuthenCard { get; set; }
        }
    }
}