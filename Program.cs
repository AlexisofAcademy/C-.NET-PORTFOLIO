using System;
using System.Collection.Gneric;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst 
{
    class Program 
    {

        static void Main(string[] args)
        {
            using (var context = new MyDbContext())
            {
                var purchase = new Purchase() 
                {
                    Id = 1,
                    Product = "Shoes",
                    Price = 49.95m
                };
                context.Purchases.Add(purchase);

                context.SaveChanges(); 

                var purchaseRecords = context.Purchase.Where(p => p.Price < 100m); 
            }
        }
    }
  
    public class MyDbContext : MyDbContext 

        public DbSet<Purchase> Purchases { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyDb");
        }

    
    public class Purchase 
    {
       public int Id { get; set; }

       public string Product { get; set; }

       public decimal Price { get; set; }   
    }







}
