using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_web.Models
{
    [Table("Products")]
    public class Products
    {
        [Key]
        public int ProductsId { get; set; }
        [Required]
        [StringLength(30)]
        [Column(TypeName = "Varchar")]
        public string ModelName { get; set; }
        [Required]
        public int ModelNumber { get; set; }
        [Required]
        public Double Unitcost { get; set; }
        [Required]
       
        public string Description { get; set; }

        public string CategoryId { get; set; }

    }
}
