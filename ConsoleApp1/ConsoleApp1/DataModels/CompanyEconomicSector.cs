using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataModels
{
    [Table("CompanyEconomicSector")]
    public class CompanyEconomicSector
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1, TypeName = "INT")]
        public int Id { get; set; }

        [Column(Order = 2, TypeName = "INT")]
        public int IdCompany { get; set; }

        [Column(Order = 3, TypeName = "INT")]
        public int IdEconomicSector { get; set; }

    }
}
