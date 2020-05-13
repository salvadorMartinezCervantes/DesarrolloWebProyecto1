using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace netProject.Models
{
    public class destinoContext : DbContext
    {
       
    
        public destinoContext() : base("name=destinoContext")
        {
        }

        public System.Data.Entity.DbSet<netProject.Models.destino> destinoes { get; set; }
    }
}
