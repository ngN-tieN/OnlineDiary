using Microsoft.EntityFrameworkCore;
using OnlineDiary.Utils;
using System.Collections.Generic;

namespace OnlineDiary.Models
{
    public class DiaryContext : DbContext
    {
        public DbSet<Diary> Diaries { get; set; }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = GetEnvVar.GetEnvString("MSSQL_CONNECTION_STRING");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }


}
