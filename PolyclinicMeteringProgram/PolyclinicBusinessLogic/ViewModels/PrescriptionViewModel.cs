using System.Collections.Generic;
using System.ComponentModel;

namespace PolyclinicBusinessLogic.ViewModels
{
    public class PrescriptionViewModel
    {
        public int Id { get; set; }
        [DisplayName("Стоимость рецепта")]
        public int Price { get; set; }
        [DisplayName("Адрес аптеки")]
        public string PharmacyAddress { get; set; }
        public Dictionary<int, (string, int)> PrescriptionMedicines { get; set; }
        public Dictionary<int, (string, int)> PrescriptionTreatment { get; set; }
    }
}
