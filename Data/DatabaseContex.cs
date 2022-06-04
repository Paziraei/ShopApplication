using Microsoft.EntityFrameworkCore;
namespace Data;

public class DatabaseContex : DbContext
{
    public DatabaseContex()
    {
    }

    #region All DbSets
    public DbSet<Models.Address> Address { get; set; }
    public DbSet<Models.Basket> Baskets { get; set; }
    public DbSet<Models.Brand> Brands { get; set; }
    public DbSet<Models.Category> Categories { get; set; }
    public DbSet<Models.City> Cities { get; set; }
    public DbSet<Models.Order> Orders { get; set; }
    public DbSet<Models.Product> Products { get; set; }
    public DbSet<Models.ProductBasket> ProductBaskets { get; set; }
    public DbSet<Models.ProductOrder> ProductOrders { get; set; }
    public DbSet<Models.Role> Roles { get; set; }
    public DbSet<Models.SaleDiscount> SaleDiscounts { get; set; }
    public DbSet<Models.State> States { get; set; }
    public DbSet<Models.User> Users { get; set; }
    public DbSet<Models.UserRole> UserRoles { get; set; }
    #endregion

    #region OnConfiguring
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string databaseName = "ShopDb";

        optionsBuilder
            .UseSqlServer($"Data Source=.;Initial Catalog={databaseName};Integrated Security=True");

        base.OnConfiguring(optionsBuilder);
    }
    #endregion

    protected override void OnModelCreating(ModelBuilder Builder)
    {
        //user , userRole:

        Builder.Entity<Models.User>()
              .HasMany(current => current.UserRoles)
              .WithOne(current => current.User)
              .HasForeignKey(current => current.UserId)
              .OnDelete(DeleteBehavior.NoAction); // ok

        //-------------------------------------------------------
        //Role , userRole

        Builder.Entity<Models.Role>()
            .HasMany(current => current.UserRoles)
            .WithOne(current => current.Role)
           .HasForeignKey(current => current.RoleId)
           .OnDelete(DeleteBehavior.NoAction); //? ok

        //--------------------------------------------------------

        //user , prudoct

        Builder.Entity<Models.Product>()
            .HasOne(current => current.User)
            .WithMany(current => current.Products)
            .HasForeignKey(current => current.UserId)
            .OnDelete(DeleteBehavior.SetNull);// ok
        //-------------------------------------------------------

        //user , address

        Builder.Entity<Models.User>()
           .HasMany(current => current.Addresses)
            .WithOne(current => current.User)
            .HasForeignKey(current => current.UserId)
            .OnDelete(DeleteBehavior.Cascade);// !!!
        //---------------------------------------------------------

        //user , Basket

        Builder.Entity<Models.Basket>()
           .HasOne(current => current.User)
           .WithMany(current => current.Basket)
           .HasForeignKey(current => current.UserId)
           .OnDelete(DeleteBehavior.Cascade);// !!!

        //------------------------------------------------------

        //prudoct , category

        Builder.Entity<Models.Product>()
          .HasOne(current => current.Category)
          .WithMany(current => current.Products)
          .HasForeignKey(current => current.CategoryId)
          .OnDelete(DeleteBehavior.SetNull); //!!!

        //---------------------------------------------------

        //product , product order

        Builder.Entity<Models.Product>()
            .HasMany(current => current.ProductOrders)
            .WithOne(current => current.Product)
            .HasForeignKey(current => current.ProductId)
            .OnDelete(DeleteBehavior.NoAction);//!!!

        //---------------------------------------------------

        //Product 1, Product basket (*)

        //Builder.Entity<Models.ProductBasket>()
        //   .HasOne(current => current.Product)
        //   .WithMany(current => current.ProductBaskets)
        //   .HasForeignKey(current => current.ProductId)
        //   .OnDelete(DeleteBehavior.Cascade);// !!!

        Builder.Entity<Models.Product>()
           .HasMany(current => current.ProductBaskets)
           .WithOne(current => current.Product)
           .HasForeignKey(current => current.ProductId)
           .OnDelete(DeleteBehavior.Cascade);// !!!

        // basket , product basket
        Builder.Entity<Models.Basket>()
           .HasMany(current => current.ProductBaskets)
           .WithOne(current => current.Basket)
           .HasForeignKey(current => current.BasketId)
           .OnDelete(DeleteBehavior.NoAction);// !!!

        // basket , product basket
        Builder.Entity<Models.Basket>()
           .HasMany(current => current.NextProductBaskets)
           .WithOne(current => current.NextBasket)
           .HasForeignKey(current => current.NextBasketId)
           .OnDelete(DeleteBehavior.NoAction);// !!!

        //--------------------------------------------------

        //Product , brand

        Builder.Entity<Models.Product>()
            .HasOne(current => current.Brand)
            .WithMany(current => current.Product)
            .HasForeignKey(current => current.BrandId)
            .OnDelete(DeleteBehavior.SetNull);

        //--------------------------------------------------

        //Product , gallery

        Builder.Entity<Models.Gallery>()
             .HasOne(current => current.Product)
             .WithMany(current => current.Galleries)
             .HasForeignKey(current => current.ProductId)
             .OnDelete(DeleteBehavior.Cascade);

        //-----------------------------------------------------

        //Product, sale discount

         Builder.Entity<Models.SaleDiscount>()
           .HasOne(current => current.Product)
           .WithMany(current => current.SaleDiscounts)
           .HasForeignKey(current => current.ProductId)
           .OnDelete(DeleteBehavior.Cascade);// !!!

        //------------------------------------------------------

        //Product order , order

        Builder.Entity<Models.ProductOrder>()
         .HasOne(current => current.Order)
         .WithMany(current => current.ProductOrders)
         .HasForeignKey(current => current.OrderId)
         .OnDelete(DeleteBehavior.NoAction);

        //-----------------------------------------------------

        //State , city

        Builder.Entity<Models.State>()
            .HasMany(current => current.Cities)
            .WithOne(current => current.State)
            .HasForeignKey(current => current.StateId)
            .OnDelete(DeleteBehavior.NoAction);

        //-----------------------------------------------------
        
        //address , city

        Builder.Entity<Models.City>()
            .HasMany(current => current.Addresses)
            .WithOne(current => current.City)
            .HasForeignKey(current => current.CityId)
            .OnDelete(DeleteBehavior.SetNull);

        //---------------------------------------------------

        //Sale discount , category

        Builder.Entity<Models.Category>()
           .HasMany(current => current.SaleDiscounts)
           .WithOne(current => current.Category)
           .HasForeignKey(current => current.CategoryId)
           .OnDelete(DeleteBehavior.Cascade);

        //---------------------------------------------------

    }

}
