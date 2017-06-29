using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC_APP.Models {
    public class PhoneContext : DbContext {
        public DbSet<Phone> Phones { set; get; }
    }
}