using NAMO.Application.DTOs.Response;
using PatiVerWcf;

namespace NAMO.Infrastructure.Mappings
{
    public static class ConvertResponseToResponseDTO
    {
        /// <summary>
        /// Преобразует ответ от PatiVer в объект DTO
        /// </summary>
        /// <param name="personResponse">Объект с данными из PatiVer</param>
        /// <returns>Объект DTO, содержащий идентичные поля</returns>
        public static PersonResponseDTO ConvertPersonResponseToPersonResponseDTO(this PersonResponse personResponse)
        {
            return new PersonResponseDTO(
                personResponse.SearchResult,
                personResponse.PatientData.ConvertPatientDataToPatientDataDTO(),
                personResponse.AttachmentData.ConvertPatientAttachmentToPatientAttachmentDTO(),
                personResponse.PolisData.ConvertPolisToPatientPolisDTO(),
                personResponse.MessageData);

        }
    }
}
