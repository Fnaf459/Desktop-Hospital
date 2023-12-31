﻿using System.ComponentModel.DataAnnotations;

namespace PolyclinicDatabase.Models
{
    public class ReceiptMedicine
    {
        public int Id { get; set; }
        public int MedicineId { get; set; }
        public int ReceiptId { get; set; }
        [Required]
        public int Count { get; set; }
        public virtual Medicine Medicine { get; set; }
        public virtual Receipt Receipt { get; set; }
    }
}
