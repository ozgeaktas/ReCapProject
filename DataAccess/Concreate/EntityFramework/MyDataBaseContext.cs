using Entities.Concreate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concreate.EntityFramework
{
   public  class MyDataBaseContext:DbContext //kurduğumuz entityframework ile DbContext geliyor.
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)//projem hangi veritabanıyla ilişkili
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyDataBase;Trusted_Connection=true"); //hangi veritabanına bağlanacağımızı söylüyoruz.
        }
        //hangi tabloya ne karşılık gelicek classlar veritabanıyla eşleşiyor.
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }


    }
}
