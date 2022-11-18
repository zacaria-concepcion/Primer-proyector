using Zacaria20181285.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace  Zacaria20181285.Data.Context;


public class Zacaria20181285DbContext:DbContext,IZacaria20181285DbContext
{

    public LP3DbContext(DbContextOptions options):base(options)
    {
        
    }
    public virtual DbSet<P> Pe {get; set;} = null!;
    public virtual DbSet<Estudiante> Estudiante {get; set;} = null!;



}  