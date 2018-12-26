using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Orm
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
            : base(GetConnectionString()) { }

        private static string GetConnectionString()
        {
            return "SqlServerConnectionString";
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }//建立实体类与表的映射关系
    }
}
