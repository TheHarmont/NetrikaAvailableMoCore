using NAMO.Application.DTOs.Response;
using NAMO.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMO.Application.Interfaces
{
    public interface IAvailableMOService
    {
        /// <summary>
        /// Возвращает список идентификаторов доступных МО
        /// </summary>
        /// <param name="patientInfo">Данные о пациенте из ФОМС</param>
        /// <param name="patient">Данные пациента из тела запроса</param>
        public Task<List<int>> GetAvailableMO(PersonResponseDTO? patientInfo, PatientInfoRequest patient);
    }
}
