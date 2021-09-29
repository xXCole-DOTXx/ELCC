using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;

#nullable disable

namespace EnvApp.Models.DB
{
    public partial class NR_User
    {
        public long ID { get; set; }
        public string Name { get; set; }
        public string Email_Address { get; set; }
        public string Section { get; set; }
        public string User_Type { get; set; }
        public string AD_Number { get; set; }
    }
}
