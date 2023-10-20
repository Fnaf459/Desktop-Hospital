using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PolyclinicDatabase.Models
{
    public class Receipt
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string DeliverymanName { get; set; }
        [ForeignKey("ReceiptId")]
        public virtual List<ReceiptMedicine> ReceiptMedicines { get; set; }
    }
}
