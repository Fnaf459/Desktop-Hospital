using System.ComponentModel.DataAnnotations;

namespace PolyclinicDatabase.Models
{
    public class PrescriptionTreatment
    {
        public int Id { get; set; }
        public int TreatmentId { get; set; }
        public int PrescriptionId { get; set; }
        [Required]
        public int Count { get; set; }
        public virtual Treatment Treatment { get; set; }
        public virtual Prescription Prescription { get; set; }
    }
}
