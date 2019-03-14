using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;

namespace MVCApp
{
    public class CustomUser: IdentityUser
    {
        public string Login { get; set; }

        //gkjgkjgkjgk
        public DateTime? LastVisit { get; set; }

        public virtual ICollection<Account> Accounts { get; set; }
    }
}