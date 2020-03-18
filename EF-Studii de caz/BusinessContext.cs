namespace EF_Studii_de_caz
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class BusinessContext : DbContext
    {
        public DbSet<Business> Businesses { get; set; }
        public BusinessContext()
            : base("name=BusinessContext")
        {
        }

       
    }

 
}