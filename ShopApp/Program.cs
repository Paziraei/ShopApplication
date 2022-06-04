namespace ShopApp;

public static class Program
{
    static void Main(string[] args)
    {
        Data.DatabaseContex contex = new Data.DatabaseContex();  
        contex.Database.EnsureDeleted();    
        contex.Database.EnsureCreated();
        
    }
}
