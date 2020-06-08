﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Identity
{
    public class ApplicationUser :IdentityUser
    {
        public DateTime? Birthday { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public List<ApplicationUserRole> UserRoles { get; set; }
    }
}
