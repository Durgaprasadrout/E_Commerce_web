using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_web.Models
{
    [Table("OrderDetails")]
    public class OrderDetails
    {
        [Key]
        public int OrderId { get; set; }
        [Required]
        public int ProductId { get; set;}

        [Required]
        public int Quantity { get; set; }

        [Required]
        public double UnitCost { get; set; }


    }
}
