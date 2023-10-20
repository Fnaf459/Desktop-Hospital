using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace PolyclinicBusinessLogic.ViewModels
{
    public class ReceiptViewModel
    {
        public int Id { get; set; }
        [DisplayName("Дата поступления")]
        public DateTime Date { get; set; }
        [DisplayName("Имя доставщика")]
        public string DeliverymanName { get; set; }
        [DisplayName("Список лекарств")]
        public Dictionary<int, (string, int)> ReceiptMedicines { get; set; }
    }
}
