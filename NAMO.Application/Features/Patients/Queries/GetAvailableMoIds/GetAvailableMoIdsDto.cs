using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMO.Application.Features.Patients.Queries.GetAvailableMoIds
{
    public class GetAvailableMoIdsDto
    {
        public List<int>? Organisations { get; set; }
        public int Status { get; set; }
        public string? Message { get; set; }
    }
}
