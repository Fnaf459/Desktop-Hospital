using System.ComponentModel.DataAnnotations;

namespace PolyclinicDatabase.Models
{
    public class ProcedureTreatment
    {
        public int Id { get; set; }
        public int TreatmentId { get; set; }
        public int ProcedureId { get; set; }
        [Required]
        public int Count { get; set; }
        public virtual Treatment Treatment { get; set; }
        public virtual Procedure Procedure { get; set; }
    }
}
