using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataModels
{
    [Table("AnoucingProgress")]
    public  class AnoucingProgress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1, TypeName = "INT")]
        public int Id { get; set; }

        [Column(Order = 2, TypeName = "INT")]
        [Required]
        public int IdUser { get; set; }

        [Column(Order = 3, TypeName = "INT")]
        [Required]
        public int IdEconomicSector { get; set; }

        [Column(Order = 4, TypeName = "INT")]
        [Required]
        public int IdProductService { get; set; }

        [Column(Order = 5, TypeName = "DATETIME")]
        public DateTime RegistrationDate { get; set; }

        [Column(Order = 6, TypeName = "DATETIME")]
        public DateTime PublishDate { get; set; }

        [Column(Order = 7, TypeName = "BIT")]
        public bool Status { get; set; }
    }
}
