using RodDB.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RodDB.Context
{
    public class MotoContext : DbContext
    {
        public DbSet<Moto> Motos { get; set; }

        public MotoContext() : base("MotoConnection")
        {

        }
    }
}