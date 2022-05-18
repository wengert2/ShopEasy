using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopEasy.Models.DataLayer
{
    public partial class Products
    {
        public Products()
        {
            InvoiceItem = new HashSet<InvoiceItem>();
        }

        [Key]
        public int ProductId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Category { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [InverseProperty("Product")]
        public virtual ICollection<InvoiceItem> InvoiceItem { get; set; }
    }
}
