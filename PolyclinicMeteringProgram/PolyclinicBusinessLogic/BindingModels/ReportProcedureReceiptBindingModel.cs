using System;

namespace PolyclinicBusinessLogic.BindingModels
{
    public class ReportProcedureReceiptBindingModel
    {
        public string FileName { get; set; }
        public int PharmacistId { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
    }
}
