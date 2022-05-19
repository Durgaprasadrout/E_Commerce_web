using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_web.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        public int categoryId { get; set; }
        [Required]
        [StringLength(30)]
        [Column(TypeName = "Varchar")]
        public string categoryName { get; set; }
        [Required]
        [StringLength(300)]
        [Column(TypeName = "Varchar")]
        public string description { get; set; }


    }
}
