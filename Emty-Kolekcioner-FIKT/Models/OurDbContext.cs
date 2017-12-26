using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Emty_Kolekcioner_FIKT.Models
{
    public class OurDbContext : DbContext
    {
        public DbSet <UserAccount> UserAccount { get; set; }

        public DbSet <AddKolekcion> AddKolekcion { get; set; }

    }
}