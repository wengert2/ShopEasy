using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopEasy.Models.DataLayer
{
    public partial class Customers
    {
        public Customers()
        {
            Invoices = new HashSet<Invoices>();
            Logins = new HashSet<Logins>();
        }

        [Key]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(20)]
        public string Phone { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Discount { get; set; }

        [InverseProperty("Customer")]
        public virtual ICollection<Invoices> Invoices { get; set; }
        [InverseProperty("Customer")]
        public virtual ICollection<Logins> Logins { get; set; }
    }
}
