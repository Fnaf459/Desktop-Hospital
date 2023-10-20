using System.ComponentModel;

namespace PolyclinicBusinessLogic.ViewModels
{
    public class PrescriptionTreatmentViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название лечения")]
        public string TreatmentName { get; set; }
        [DisplayName("Количество")]
        public int TreatmentCount { get; set; }
    }
}
