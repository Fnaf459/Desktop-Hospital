﻿using PolyclinicBusinessLogic.Interfaces;
using PolyclinicBusinessLogic.ViewModels;
using System.Collections.Generic;

namespace PolyclinicBusinessLogic.BusinessLogics
{
    public class ReceiptReportLogic
    {
        private readonly IProcedure _procedureStorage;
        private readonly IMedicine _medicineStorage;
        private readonly IReceipt _receiptStorage;
        public ReceiptReportLogic(IProcedure procedureStorage, IMedicine medicineStorage, IReceipt receiptStorage)
        {
            _procedureStorage = procedureStorage;
            _medicineStorage = medicineStorage;
            _receiptStorage = receiptStorage;
        }
        public List<ReportReceiptViewModel> GetProcedureRecepts(List<ProcedureViewModel> procedures)
        {
            var medicines = _medicineStorage.GetFullList();
            var receipts = _receiptStorage.GetFullList();
            var list = new List<ReportReceiptViewModel>();

            foreach (var procedure in procedures)
            {
                foreach (var medicine in medicines)
                {

                    if (procedure.ProcedureMedicines.ContainsKey(medicine.Id))
                    {
                        foreach (var receipt in receipts)
                        {
                            if (receipt.ReceiptMedicines.ContainsKey(medicine.Id))
                            {

                                list.Add(new ReportReceiptViewModel
                                {
                                    ProcedureName = procedure.Name,
                                    Date = receipt.Date,
                                    DeliverymanName = receipt.DeliverymanName
                                });
                            }
                        }
                    }
                }

            }
            return list;
        }
    }
}
