using Microsoft.EntityFrameworkCore;
namespace Data;

public class DbSetContex :DbContext
{
    public DbSetContex()
    {
    }

    #region All DbSets
    public DbSet<Models.Address> Address { get; set; }
    public DbSet<Models.Basket> Baskets { get; set; }
    public DbSet<Models.Brand> Brands { get; set; }
    public DbSet<Models.Category> Categories { get; set; }
    public DbSet<Models.City> Cities { get; set; }
    public DbSet<Models.Order> Orders { get; set; }
    public DbSet<Models.Product> Prodacts { get; set; }
    public DbSet<Models.ProdactBasket> ProdactBaskets { get; set; }
    public DbSet<Models.ProdactOrder> ProdactOrders { get; set; }
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


   
}
