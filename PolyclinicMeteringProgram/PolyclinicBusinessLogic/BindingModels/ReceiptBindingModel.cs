using System;
using System.Collections.Generic;

namespace PolyclinicBusinessLogic.BindingModels
{
    public class ReceiptBindingModel
    {
        public int? Id { get; set; }
        public DateTime Date { get; set; }
        public string DeliverymanName { get; set; }
        public Dictionary<int, (string, int)> ReceiptMedecines { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
