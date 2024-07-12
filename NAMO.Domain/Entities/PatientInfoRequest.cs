using NAMO.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMO.Domain.Entities
{
    public class PatientInfoRequest : BasePatientData
    {
        public string? PolisN { get; set; }
        public string? PolisS { get; set; }
        public string? Polis => GetFullPolis(this);
        public string? SNILS { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string? FirstName { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string? LastName { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string? MiddleName { get; set; }
        public string? BirthDate { get; set; }
        public string? Sex { get; set; }

        /// <summary>
        /// Возвращает полный номер полиса
        /// </summary>
        private string GetFullPolis(PatientInfoRequest patient)
        {
            return (patient.PolisS ?? "") + (patient.PolisN ?? "");
        }
    }
}
