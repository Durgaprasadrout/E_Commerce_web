using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace E_Commerce_web.Models
{
    [Table("ShoppingCart")]
    public class ShoppingCart
    {

        public int RecordId { get; set; }
        [Key]
        public int CartId { get; set; }
        [Required]
        public int Quantity { get; set; }

        public int ProductId { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }

    }
}
