using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NAMO.Application.DTOs.Response
{
    public class PersonResponseDTO
    {
        public string SearchResult { get; }
        public PatientDataDTO? PatientData { get; }
        public PatientAttachmentDTO? AttachmentData { get; }
        public PolisDTO? PolisData { get; }
        public string? MessageData { get; }

        public PersonResponseDTO(string searchResult, PatientDataDTO? patientData, PatientAttachmentDTO? attachmentData, PolisDTO? polisData, string? messageData)
        {
            SearchResult = searchResult;
            PatientData = patientData;
            AttachmentData = attachmentData;
            PolisData = polisData;
            MessageData = messageData;
        }
    }
}
