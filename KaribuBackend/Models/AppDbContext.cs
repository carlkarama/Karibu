using System.Data.Entity;

public class AppDbContext: DbContext
{
    public AppDbContext() : base("DefaultConnection")  {

    }
}