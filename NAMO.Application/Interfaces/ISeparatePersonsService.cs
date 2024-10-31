using NAMO.Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMO.Application.Interfaces;

public interface ISeparatePersonsService
{
    /// <summary>
    /// Возвращает результат, содержащий список Id медицинских организаций
    /// </summary>
    public Task<Result<List<int>>> GetAvailableMoIdsAsync(string? polis);
}
