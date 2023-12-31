﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PolyclinicDatabase.Models
{
    public class Pharmacist
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        [ForeignKey("PharmacistId")]
        public virtual List<Medicine> Medicines { get; set; }
    }
}