using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  WebApp.Model.Model;

namespace WebApp.DatabaseContext
{
  public  class ProjectDbContext : DbContext
    {
       public DbSet<StudentModel> Students { set; get; }
    }
}
