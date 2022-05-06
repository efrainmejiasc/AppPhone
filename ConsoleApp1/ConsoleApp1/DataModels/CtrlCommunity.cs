using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataModels
{
    [Table("CtrlCommunity")]
    public class CtrlCommunity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1, TypeName = "INT")]
        public int Id { get; set; }

        [Column(Order = 2, TypeName = "INT")]
        [Required]
        public int IdCommunity{ get; set; }

        [Column(Order = 3, TypeName = "INT")]
        [Required]
        public int IdUser { get; set; }

        [Column(Order = 4, TypeName = "DATETIME")]
        public DateTime RegistrationDate { get; set; }

        [Column(Order = 5, TypeName = "BIT")]
        public bool Status { get; set; }
    }
}
