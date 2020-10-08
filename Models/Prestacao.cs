using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace projetoIBM.Models
{
    public class Prestacao
    {
         [Key]

         public int IdPrestacao  { get;set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        [DataType(DataType.Date)]
         public int  dataVencimentoPrestacao  { get; set; }
         [DataType(DataType.Date)]
         public int  dataPagamentoPrestacao { get; set; }
         public decimal valorPrestacao { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z]*$")]
        [Required]
        [StringLength(8)]
         public string StatusVencimento { get; set; }
        
    }
}