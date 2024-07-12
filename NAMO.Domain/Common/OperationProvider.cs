using NAMO.Domain.Entities;

namespace NAMO.Domain.Common
{
    public static class OperationProvider
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
                req.Polis+
                req.SNILS + 
                DateTime.Now.ToString()).GetHashCode());
        }
    }
}
