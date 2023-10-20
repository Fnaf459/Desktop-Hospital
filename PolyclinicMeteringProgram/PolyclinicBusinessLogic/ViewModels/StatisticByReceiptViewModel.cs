using System.ComponentModel;

namespace PolyclinicBusinessLogic.ViewModels
{
    public class StatisticByReceiptViewModel
    {
        [DisplayName("Имя доставщика")]
        public string DeliverymanName { get; set; }
        [DisplayName("Количество лекарств")]
        public int MedicineCount { get; set; }
    }
}
