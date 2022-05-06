using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataModels
{
    [Table("TemplateNewsTrendsOne")]
    public class TemplateNewsTrendsOne
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1, TypeName = "INT")]
        public int Id { get; set; }

        [Column(Order = 2, TypeName = "VARCHAR")]
        [StringLength(40)]
        [Required]
        public string Title { get; set; }

        [Column(Order = 3, TypeName = "VARCHAR")]
        [StringLength(500)]
        [Required]
        public string TextArea { get; set; }

        [Column(Order = 4, TypeName = "VARCHAR")]
        [StringLength(20)]
        public string LinkText { get; set; }

        [Column(Order = 5, TypeName = "VARCHAR")]
        [StringLength(100)]
        public string Link { get; set; }

        [Column(Order = 6, TypeName = "VARCHAR")]
        [StringLength(100)]
        public string RolloVer { get; set; }

        [Column(Order = 7, TypeName = "BIT")]
        public bool Status { get; set; }

        [Column(Order = 8, TypeName = "INT")]
        [Required]
        public int Section { get; set; }

        [Column(Order = 9, TypeName = "INT")]
        [Required]
        public int IdUserCreate { get; set; }

        [Column(Order = 10, TypeName = "INT")]
        [Required]
        public int IdUserUpdate { get; set; }

        [Column(Order = 11, TypeName = "DATETIME")]
        public DateTime CreateDate { get; set; }

        [Column(Order = 12, TypeName = "DATETIME")]
        public DateTime LastUpdate { get; set; }

       
    }
}
