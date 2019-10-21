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




```