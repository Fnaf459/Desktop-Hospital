﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PolyclinicDatabase.Models
{
    public class Patient
    {
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }        
        public string PhoneNumber { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        public int DoctorId { get; set; }
        public virtual Doctor Doctor { get; set; }
        [ForeignKey("PatientId")]
        public virtual List<PatientProcedure> PatientProcedures { get; set; }
    }
}
