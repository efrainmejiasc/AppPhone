using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.DataModels
{
    [Table("TemplateNewsTrendsSixDetail")]
    public  class TemplateNewsTrendsSixDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1, TypeName = "INT")]
        public int Id { get; set; }

        [Column(Order = 2, TypeName = "VARCHAR")]
        [StringLength(357)]
        [Required]
        public string Text { get; set; }

        [Column(Order = 3, TypeName = "VARCHAR")]
        [StringLength(100)]
        [Required]
        public string Link { get; set; }
        [Column(Order = 4, TypeName = "BIT")]
        public bool Status { get; set; }

        [Column(Order = 5, TypeName = "INT")]
        [Required]
        public int Section { get; set; }

        [Column(Order = 6, TypeName = "INT")]
        [Required]
        public int IdUserCreate { get; set; }

        [Column(Order = 7, TypeName = "INT")]
        [Required]
        public int IdUserUpdate { get; set; }

        [Column(Order = 8, TypeName = "DATETIME")]
        public DateTime CreateDate { get; set; }

        [Column(Order = 9, TypeName = "DATETIME")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey("TemplateNewsTrendsSix")]
        public int TemplateNewsTrendsSixId { get; set; }
        public TemplateNewsTrendsSix TemplateNewsTrendsSix { get; set; }
    }
}
