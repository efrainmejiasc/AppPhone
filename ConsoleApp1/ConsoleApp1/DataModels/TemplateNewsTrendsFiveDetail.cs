using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleApp1.DataModels
{
    [Table("TemplateNewsTrendsFiveDetail")]
    public  class TemplateNewsTrendsFiveDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1, TypeName = "INT")]
        public int Id { get; set; }

        [Column(Order = 2, TypeName = "VARCHAR")]
        [StringLength(100)]
        [Required]
        public string TextRef { get; set; }

        [Column(Order = 3, TypeName = "VARCHAR")]
        [StringLength(100)]
        [Required]
        public string Link { get; set; }

        [Column(Order = 4, TypeName = "BIT")]
        public bool Status { get; set; }

        [Column(Order = 5, TypeName = "INT")]
        [Required]
        public int IdUserCreate { get; set; }

        [Column(Order = 6, TypeName = "INT")]
        [Required]
        public int IdUserUpdate { get; set; }

        [Column(Order = 7, TypeName = "DATETIME")]
        public DateTime CreateDate { get; set; }

        [Column(Order = 8, TypeName = "DATETIME")]
        public DateTime LastUpdate { get; set; }

        [ForeignKey("TemplateNewsTrendsFive")]
        public int TemplateNewsTrendsFiveId { get; set; }
        public TemplateNewsTrendsFive TemplateNewsTrendsFive { get; set; }

    }
}
