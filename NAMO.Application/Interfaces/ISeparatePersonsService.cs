using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMO.Application.Interfaces
{
    public interface ISeparatePersonsService
    {
        /// <summary>
        /// Возвращает список Id медицинских организаций
        /// </summary>
        /// <param name="polis">Номер полиса пациента</param>
        public Task<List<int>?> GetAvailableMoAsync(string? polis);
    }
}
