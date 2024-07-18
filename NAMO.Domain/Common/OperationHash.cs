using NAMO.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMO.Domain.Common
{
    public static class OperationHash
    {
        /// <summary>
        /// Возвращает хэш строки
        /// </summary>
        /// <param name="req">Запрос по Полис</param>
        public static string GetHash(PatientInfoRequest req)
        {
            return string.Format("{0:X}", (
                req.LastName +
                req.FirstName +
                req.MiddleName +
                req.Polis +
                req.SNILS +
                DateTime.Now.ToString()).GetHashCode());
        }
    }
}
