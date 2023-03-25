using App.Entities.Concrete;
using System.Data.Entity;

namespace App.DataAccess.Concrete.EfEntityFramework
{
    public class NorthwindContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public NorthwindContext()
            :base("Data Source=DESKTOP-E15UN3T;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {

        }
    }
}
