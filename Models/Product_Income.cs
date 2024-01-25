using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class Product_Income : BaseEntity
    {
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal IncomingPrice { get; set; }
        [Required]
        public decimal OutComingPrice { get; set; }
        [Required]
        public DateTime IncomingDate { get; set; }
        [Required]
        public int ProductId { get; set; }
        public Product Product = new();
    }
}
