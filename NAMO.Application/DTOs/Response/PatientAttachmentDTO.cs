using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NAMO.Application.DTOs.Response
{
    public class PatientAttachmentDTO
    {
        public string CodeMO { get; }
        public string? Sector { get; }
        public string? SectorName { get; }
        public string? SectorType { get; }
        public string Type { get; }
        public DateTime? BeginDate { get; }
        public DateTime? EndDate { get; }
        public string Reason { get; }
        public string? DetachReason { get; }
        public string? DoctorSnils { get; }

        public PatientAttachmentDTO(string codeMO, string? sector, string? sectorName, string? sectorType, string type, DateTime? beginDate, DateTime? endDate, string reason, string? detachReason, string? doctorSnils)
        {
            CodeMO = codeMO;
            Sector = sector;
            SectorName = sectorName;
            SectorType = sectorType;
            Type = type;
            BeginDate = beginDate;
            EndDate = endDate;
            Reason = reason;
            DetachReason = detachReason;
            DoctorSnils = doctorSnils;
        }
    }
}
