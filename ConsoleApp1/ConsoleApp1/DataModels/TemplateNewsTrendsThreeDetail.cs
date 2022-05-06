using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataModels
{
    [Table("TemplateNewsTrendsThreeDetail")]
    public  class TemplateNewsTrendsThreeDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 1, TypeName = "INT")]
        public int Id { get; set; }

        [Column(Order = 2, TypeName = "VARCHAR")]
        [StringLength(40)]
        [Required]
        public string TextToPage { get; set; }

        [Column(Order = 3, TypeName = "VARCHAR")]
        [StringLength(100)]
        [Required]
        public string Link { get; set; }

        [Column(Order = 4, TypeName = "VARCHAR")]
        [StringLength(100)]
        public string RolloVer { get; set; }

        [Column(Order = 5, TypeName = "BIT")]
        public bool Status { get; set; }

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


        [ForeignKey("TemplateNewsTrendsThree")]
        public int TemplateNewsTrendsThreeId { get; set; }
        public TemplateNewsTrendsThree TemplateNewsTrendsThree { get; set; }
    }
}
