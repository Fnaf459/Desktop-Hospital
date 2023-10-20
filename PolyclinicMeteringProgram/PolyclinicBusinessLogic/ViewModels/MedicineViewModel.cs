using System.ComponentModel;

namespace PolyclinicBusinessLogic.ViewModels
{
    public class MedicineViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название лекарства")]
        public string Name { get; set; }
        [DisplayName("Активное вещество")]
        public string ActiveSubstance { get; set; }
        [DisplayName("Классификация")]
        public string Classification { get; set; }
        public int PharmacistId { get; set; }
        [DisplayName("Имя аптекаря")]
        public string PharmacistName { get; set; }
    }
}
