using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PolyclinicDatabase.Models
{
    public class Prescription
    {
        public int Id { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public string PharmacyAddress { get; set; }

        [ForeignKey("PrescriptionId")]
        public virtual List<PrescriptionMedicine> PrescriptionMedicines { get; set; }
        [ForeignKey("PrescriptionId")]
        public virtual List<PrescriptionTreatment> PrescriptionTreatments { get; set; }
    }
}
