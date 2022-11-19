using Vehiculo_20200553.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Vehiculo_20200553.Data.Context;

public class Vehiculo_20200553DbContext:DbContext
{

    public Vehiculo_20200553DbContext(DbContextOptions options):base(options)
    {
    
    }
     public virtual DbSet<vehiculo> vehiculos {get; set;} = null!;

}
public interface Vehiculo_20200553
{
     public  DbSet<vehiculo> vehiculos {get; set;}
}
