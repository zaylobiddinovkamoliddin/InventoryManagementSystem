using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementSystem.Models
{
    public class Admin : BaseEntity
    {
        [Required, StringLength(100)]
        public string FullName { get; set; } = string.Empty;
        [Required, StringLength(20)]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required, StringLength(20)]
        public string Password { get; set; } = string.Empty;
    }
}
