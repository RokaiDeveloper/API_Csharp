using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using API.Models;
namespace API.Models
{
    public class ReqContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options
            .UseSqlServer(@"Server=omniserver\sql2014;Database=12001_1;User ID=sa;Password=omni@50ftp4r;TrustServerCertificate=True;")
            .LogTo(Console.WriteLine, LogLevel.Information);
        public DbSet<API.Models.AlmoxarifadoRequisicao> AlmoxarifadoRequisicao { get; set; } = default!;
    }
}
