using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataModels
{
    [Table("VirtualCourse")]
    public  class VirtualCourse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1, TypeName = "INT")]
        public int Id { get; set; }

        [Column(Order = 2, TypeName = "INT")]
        [Required]
        public int IdCourse { get; set; }

        [Column(Order = 3, TypeName = "INT")]
        [Required]
        public int IdUser { get; set; }

        [Column(Order = 4, TypeName = "INT")]
        [Required]
        public int IdComunity { get; set; }

        [Column(Order = 5, TypeName = "INT")]
        [Required]
        public int IdCompany { get; set; }

        [Column(Order = 6, TypeName = "DATETIME")]
        public DateTime RegistrationDate { get; set; }

        [Column(Order = 7, TypeName = "BIT")]
        public bool  Publish { get; set; }

        [Column(Order = 8, TypeName = "BIT")]
        public bool  Status { get; set; }

        [Column(Order = 9, TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Contact { get; set; }
    }
}
