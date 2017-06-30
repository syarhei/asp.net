using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Video.Models {
    public class VideoContext : DbContext {
        public DbSet<Video> Videos { set; get; }
    }
}