﻿using System;
using System.ComponentModel;

namespace PolyclinicBusinessLogic.ViewModels
{
    public class ReportReceiptViewModel
    {
        int Id { get; set; }
        [DisplayName("Название процедуры")]
        public string ProcedureName { get; set; }
        [DisplayName("Дата поступления")]
        public DateTime Date { get; set; }
        [DisplayName("Имя доставщика")]
        public string DeliverymanName { get; set; }
    }
}
