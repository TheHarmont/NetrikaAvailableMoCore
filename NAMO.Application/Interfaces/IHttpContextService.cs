using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMO.Application.Interfaces
{
    public interface IHttpContextService
    {
        /// <summary>
        /// Возвращает IpAddress клиента
        /// </summary>
        string? GetClientIpAddresses();

        /// <summary>
        /// Возвращает адрес, куда был отправлен запрос
        /// </summary>
        public string? GetRequestEndpoint();

        /// <summary>
        /// Возвращает метод, который был отправлен запрос
        /// </summary>
        string? GetRequestMethod();
    }

}
