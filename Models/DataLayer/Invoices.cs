using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopEasy.Models.DataLayer
{
    public partial class Invoices
    {
        public Invoices()
        {
            InvoiceItem = new HashSet<InvoiceItem>();
        }

        [Key]
        public int InvoiceId { get; set; }
        public int CustomerId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal SalesTax { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalPayment { get; set; }

        [ForeignKey(nameof(CustomerId))]
        [InverseProperty(nameof(Customers.Invoices))]
        public virtual Customers Customer { get; set; }
        [InverseProperty("Invoice")]
        public virtual ICollection<InvoiceItem> InvoiceItem { get; set; }
    }
}
