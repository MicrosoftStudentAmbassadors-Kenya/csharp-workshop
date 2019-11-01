
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Efcoreproject.Ef
{
    public class AutoLotContext : DbContext
    {
       public AutoLotContext(DbContextOptions options):base(options)
       {
           
       }
       protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder){
           if(!optionbuilder.IsConfigured){
               var connectionString =
               @"server=(localDb)MSSQLocalDB; database=autolot;intergrated security=true;";
               optionbuilder.UseSqlServer(connectionString,options =>options.EnableRetryOnFailure())
               .ConfigureWarnings(warning => warning.Log(RelationalEventId.QueryPossibleExceptionWithAggregateOperatorWarning));
               
           }
       } 
    }

}