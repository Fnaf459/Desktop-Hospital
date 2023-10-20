namespace PolyclinicDatabase.Models
{ 
    public class PatientProcedure
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public int ProcedureId { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Procedure Procedure { get; set; }
    }
}
