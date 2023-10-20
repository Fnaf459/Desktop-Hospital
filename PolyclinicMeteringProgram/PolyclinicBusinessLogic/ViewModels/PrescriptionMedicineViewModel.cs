using System.ComponentModel;

namespace PolyclinicBusinessLogic.ViewModels
{
    public class PrescriptionMedicineViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название лекарства")]
        public string MedicineName { get; set; }
        [DisplayName("Количество")]
        public int MedicineCount { get; set; }
    }
}
