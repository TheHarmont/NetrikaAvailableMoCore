using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NAMO.Application.DTOs.Response
{
    public class PolisDTO
    {
        public string Num { get; }
        public string Type { get; }
        public DateTime BeginDate { get; }
        public DateTime? EndDate { get; }
        public DateTime? CloseDate { get; }
        public string SMO { get; }
        public string? CloseReason { get; }

        public PolisDTO(string num, string type, DateTime beginDate, DateTime? endDate, DateTime? closeDate, string smo, string? closeReason)
        {
            Num = num;
            Type = type;
            BeginDate = beginDate;
            EndDate = endDate;
            CloseDate = closeDate;
            SMO = smo;
            CloseReason = closeReason;
        }
    }
}
