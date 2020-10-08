using Microsoft.EntityFrameworkCore;
using projetoIBM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace projetoIBM.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
             : base(options)
        { 
        }

        public DbSet<Prestacao> Prestacaos { get; set; }
        public DbSet<Contrato> Contratos  { get; set; }

        //  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       /// {
          //  optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Vendas;Data Source=DESKTOP-S8GP951\\sqlexpress");


    //    }
    }
}