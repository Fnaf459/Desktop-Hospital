using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PolyclinicDatabase.Models
{
    public class Treatment
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Urgency { get; set; }
        [Required]
        public string AreaOfAction { get; set; }
        [ForeignKey("TreatmentId")]
        public virtual List<PrescriptionTreatment> PrescriptionTreatments { get; set; }
        [ForeignKey("TreatmentId")]
        public virtual List<ProcedureTreatment> ProcedureTreatments { get; set; }
    }
}
