using NAMO.Application.DTOs.Response;
using PatiVerWcf;

namespace NAMO.Infrastructure.Mappings
{
    public static class ConvertDataToDataDTO
    {
        /// <summary>
        /// Переводит PatientData в PatientDataDTO
        /// </summary>
        /// <param name="patientData">Объект с данными пациента из PatiVer</param>
        /// <returns>Объект DTO, содержащий идентичные поля</returns>
        public static PatientDataDTO ConvertPatientDataToPatientDataDTO(this PatientData patientData)
        {
            return new PatientDataDTO(
                patientData.FomsId,
                patientData.ENP,
                patientData.Surname,
                patientData.Sex,
                patientData.Name,
                patientData.Patronymic,
                patientData.BirthDate,
                patientData.Snils,
                patientData.BirthPlace,
                patientData.Citizenship,
                patientData.DocumentType,
                patientData.DocumentSeries,
                patientData.DocumentNumber,
                patientData.DocumentOrg,
                patientData.DocumentDate,
                patientData.RegAddress != null ? new AddressDTO(
                    patientData.RegAddress.Kladr,
                    patientData.RegAddress.Region,
                    patientData.RegAddress.SubRegion,
                    patientData.RegAddress.City,
                    patientData.RegAddress.Street,
                    patientData.RegAddress.House,
                    patientData.RegAddress.Corpus,
                    patientData.RegAddress.Flat
                    ) : null,
                patientData.Phone
                );
        }

        /// <summary>
        /// Переводит PatientAttachment в PatientAttachmentDTO
        /// </summary>
        /// <param name="patientAttachment">Объект с данными прикрепления пациента из PatiVer</param>
        /// <returns>Объект DTO, содержащий идентичные поля</returns>
        public static PatientAttachmentDTO ConvertPatientAttachmentToPatientAttachmentDTO(this PatientAttachment patientAttachment)
        {
            return new PatientAttachmentDTO(
                patientAttachment.CodeMO,
                patientAttachment.Sector,
                patientAttachment.SectorName,
                patientAttachment.SectorType,
                patientAttachment.Type,
                patientAttachment.BeginDate,
                patientAttachment.EndDate,
                patientAttachment.Reason,
                patientAttachment.DetachReason,
                patientAttachment.DoctorSnils
                );
        }

        /// <summary>
        /// Переводит Polis в PolisDTO
        /// </summary>
        /// <param name="polis">Объект с данными полиса пациента из PatiVer</param>
        /// <returns>Объект DTO, содержащий идентичные поля</returns>
        public static PolisDTO ConvertPolisToPatientPolisDTO(this Polis polis)
        {
            return new PolisDTO(
                polis.Num,
                polis.Type,
                polis.BeginDate,
                polis.EndDate,
                polis.CloseDate,
                polis.SMO,
                polis.CloseReason
                );
        }
    }
}
