using Haven.Models.ConcessionStuff;
using Microsoft.EntityFrameworkCore;
namespace Haven.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
        base(options)
        { }
        public DbSet<Movie> Movies { get; set; }

       
        public DbSet<Concession> Concessions { get; set; }

        public DbSet<Cart> Cart { get; set; }

        public DbSet<ConcessionOrder> ConcessionOrder { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            //----------------------------------Cart Foreign Key----------------------------
            // ConcessionOrder has foreign keys to both Cart and Concession
            
            /*
            modelBuilder.Entity<Cart>()
                //Dictate Relationship between entities
                .HasOne(c => c.ConcessionOrder)  // One Cart  to One ConcessionOrder
                .WithMany()  // Many ConcessionOrders to One Cart
                .HasForeignKey(c => c.OrderID)  // Foreign key in ConcessionOrder
                .OnDelete(DeleteBehavior.Cascade);  // Optional: Specify delete behavior
            */
  
            //-----------------------------------ConcessionOrder Foreign Key-------------------------------------
            // ConcessionOrder has foreign keys to both Cart and Concession
            
            
            modelBuilder.Entity<ConcessionOrder>()
                .HasOne(co => co.Cart)  // One ConcessionOrder to One Cart
                .WithMany()  // Many ConcessionOrders to One Cart
                .HasForeignKey(co => co.CartID)  // Foreign key in ConcessionOrder
                .OnDelete(DeleteBehavior.Cascade);  // Optional: Specify delete behavior
            


            modelBuilder.Entity<ConcessionOrder>()
                .HasOne(co => co.Concession)  // One ConcessionOrder to One Concession
                .WithMany()  // Many ConcessionOrders to One Concession
                .HasForeignKey(co => co.ItemID)  // Foreign key in ConcessionOrder
                .OnDelete(DeleteBehavior.Cascade);  // Optional: Specify delete behavior



            modelBuilder.Entity<Concession>().HasData(
               new Concession { ItemID = 1, ItemName = "Popcorn", Cost = 6.99 },
               new Concession { ItemID = 2, ItemName = "Soda", Cost = 4.58 },
               new Concession { ItemID = 3, ItemName = "Candy", Cost = 3.40 }
            );

        }//End of OnModelCreate


    }
}
