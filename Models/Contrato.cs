using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace projetoIBM.Models
{
    public class Contrato
    {
        [Key]

         public int IdContrato  { get;set; }
         public DateTime  DataContrato { get; set; }

         public int QuantidadeParcelas  { get; set; }
         public decimal ValorFinanciado { get; set; }

         public int IdPrestacao { get; set; }
         public  Prestacao Prestacao { get; set; }
         
        
    }
}