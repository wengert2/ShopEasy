using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopEasy.Models.DataLayer
{
    public partial class InvoiceItem
    {
        [Key]
        public string Id { get; set; }
        
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        [ForeignKey(nameof(InvoiceId))]
        [InverseProperty(nameof(Invoices.InvoiceItem))]
        public virtual Invoices Invoice { get; set; }
        [ForeignKey(nameof(ProductId))]
        [InverseProperty(nameof(Products.InvoiceItem))]
        public virtual Products Product { get; set; }
    }
}
