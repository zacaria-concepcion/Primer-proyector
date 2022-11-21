using Zacaria20181285.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace  Zacaria20181285.Data.Context;


public class Zacaria20181285DbContext:DbContext
{

    public Zacaria20181285DbContext(DbContextOptions options):base(options)
    {
        
    }
    public virtual DbSet<P> Pe {get; set;} = null!;
    public virtual DbSet<Estudiante> Estudiante {get; set;} = null!;



}  

