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
    }
}