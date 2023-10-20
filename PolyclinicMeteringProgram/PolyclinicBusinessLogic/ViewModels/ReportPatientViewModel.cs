using System;
using System.ComponentModel;

namespace PolyclinicBusinessLogic.ViewModels
{
    public class ReportPatientViewModel
    {
        public int Id { get; set; }
        [DisplayName("Название лекарства")]
        public string MedicineName { get; set; }
        [DisplayName("Имя пациента")]
        public string PatientName { get; set; }
        [DisplayName("Номер телефона")]
        public string PhoneNumber { get; set; }
        [DisplayName("Дата рождения")]
        public DateTime DateOfBirth { get; set; }
    }
}