using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_web.Models
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }

        public int CustomerId { get; set; }

        [Required]
        public int OrderDate { get; set; }

        [Required]
        public double ShipDate { get; set; }


    }
}
