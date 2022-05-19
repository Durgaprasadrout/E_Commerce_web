using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce_web.Models

{
    [Table("Customers")]
    public class Customers
    {
        [Key]
        public int customerId{get; set;}
        [Required]
        [StringLength (30)]
        [Column(TypeName ="Varchar")]
        public string fullName { get; set; }
        [Required]
        [StringLength(30)]
        [Column(TypeName = "nvarchar")]
        public string emailAddress { get; set; }
        [Required]
        [StringLength(30)]
        [Column(TypeName = "Varchar")]
        public  string password { get; set; }
        [Required]
        [StringLength(30)]
        [Column(TypeName = "Varchar")]
        public String deliveryAddress { get; set; }
    }
}
