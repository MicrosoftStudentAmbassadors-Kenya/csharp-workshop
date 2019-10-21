## EfCoreProject
## Libraries to use
1. Microsoft.EntityFrameworkCore
2. Microsoft.EntityFramework.Design
3. Microsoft.EntityFramework.Relational
4. Microsoft.EntityFramework.SqlServer
5. Microsoft.EntityFrameworkCore.Tools

Created a folder Base and added a file **EntityBase.cs** with code.
```Csharp
using System.ComponentModel.DataAnnotations;
namespace Efcoreproject.Base
{
    public class EntityBase
    {

        [Key]
        public int Id{ get; set; }
        [Timestamp]
        public byte[] Timestamp { get; set; }   
    }
}
```
The primary key(id) will be sequence in SQL sever, and the Timestamp column will be used for concurrency checking.

##  The Customer Class
Add a new file named **custome.cs** class,clear out the existing code and replace with the following.
```CSharp
namespace Efcoreproject.Base
{
    public class Customer
    {
        [StringLength(50)]
     public string FirstName { get; set; }   
     [StringLength(50)]
     public string LastName { get; set; }
     public List<Order> Orders { get; set; } = new List<Order>();
     [NotMapped]
     public string FullName { get; set; }
    }
}
```
# many other class => see in the base folder.
## DbContext
The DbContextOptions instance is created by the DbContextOptionbuilder Class, and it allows you to specify the database provider, the connection string and any provider specific options. The fact that it is injected into the class for changing the rovider at runtime. While this might not be prctical to change from SQl Server to oracle. (since there are probably too many otherconsiderations in play), this works great for changing to the new InMemory prvider. This provider works great as a tesing too for your data access layer without needing to have a physical database. 

In addition to the dependency Injections (DI) support, there is a fallback mechanism built into the onconfiguration() base method. This method exposes a DbContextOptionBuilder tha can be used to confirm that the context was configured and if not allow you to configure it. Add the following.

```CSharp
  public class AutoLotContext : DbContext
    {
       public AutoLotContext(DbContextOptions options):base(options)
       {
           
       }
```
The IsConfigured property is set to true if the context was configured in the contructor, and it is set to false if not. The next two sections explained the configured settings.

## Connection Resiliency
Enabling connections resiliency sets Ef to automatically retr database operations if certain transient errors occurs.These retry attempt happens a cetaine amount of times, with a set delay between each retry. This can improve your users experience cutting down on failures when there isa simple hiccup in the connections (for example). You can create a custome execution strategy, but for SQl server you don't need to do this since the team has provided SqlSeverRetryingExecutionStrategy for you. Additionally, the provider team has enabled a shortcut to add this ecectio strategy to your connection. By addint in the following DbContext option transient sql sever and or Sql azure errors will be retried u to six times (that number and the delay beween each is configurable). 

 ```CSharp
      options = options.EnableRetryOnFailure())
 ```
 If the retry limit is exceeded, Ef will throw a RetryLimitExceededException. Trapping for this error in your apps enables you to act accordinngly to the application requirements.

 ## Mixed Clien and Server Evaluations
