using NAMO.Application.DTOs.Response;
using NAMO.Application.Interfaces;
using NAMO.Domain.Common;
using NAMO.Domain.Entities;
using NAMO.Infrastructure.Mappings;
using PatiVerWcf;

namespace NAMO.Infrastructure.Services
{
    public class PatiVerService : IPatiVerService
    {
        private readonly WcfServiceClient _client;

        public PatiVerService()
        {
            _client = new WcfServiceClient();
        }

        public PersonResponseDTO? GetPersonResponseDTOByAllData(PatientInfoRequest patient)
        {
            PersonResponseDTO? patientInfo = GetPersonResponseDTOByFIO(patient);

            if (patientInfo is null)
                patientInfo = GetPersonResponseDTOByPOLIS(patient);

            if (patientInfo is null)
                patientInfo = GetPersonResponseDTOBySNILS(patient);

            return patientInfo;
        }

        public PersonResponseDTO? GetPersonResponseDTOByFIO(PatientInfoRequest patient) 
        {
            var patientInfo = _client.GetPersonInfo_FIO(
                patient.CodeFoms, 
                patient.LastName, 
                patient.FirstName, 
                patient.MiddleName, 
                patient.BirthDate, 
                patient.UsName, 
                patient.Pass, 
                patient.IPRA, 
                patient.MIS);

            //Если не удалось найти пациента
            if (patientInfo is null || patientInfo?.SearchResult != "1") return null;

            //Если у пациента нет прикрепления
            if (string.IsNullOrEmpty(patientInfo?.AttachmentData?.CodeMO)) return null;

            return patientInfo.ConvertPersonResponseToPersonResponseDTO();
        }

        public PersonResponseDTO? GetPersonResponseDTOBySNILS(PatientInfoRequest patient)
        {
            var patientInfo = _client.GetPersonInfo_SNILS(
                patient.CodeFoms,
                patient.SNILS,
                patient.UsName,
                patient.Pass,
                patient.IPRA,
                patient.MIS);

            //Если не удалось найти пациента
            if (patientInfo is null || patientInfo?.SearchResult != "1") return null;

            //Если у пациента нет прикрепления
            if (string.IsNullOrEmpty(patientInfo?.AttachmentData?.CodeMO)) return null;

            return patientInfo.ConvertPersonResponseToPersonResponseDTO();
        }

        public PersonResponseDTO? GetPersonResponseDTOByPOLIS(PatientInfoRequest patient)
        {
            var patientInfo = _client.GetPersonInfo_Polis(
                patient.CodeFoms,
                (patient.PolisS ?? "") + (patient.PolisN ?? ""),
                patient.UsName,
                patient.Pass,
                patient.IPRA,
                patient.MIS);

            //Если не удалось найти пациента
            if (patientInfo is null || patientInfo?.SearchResult != "1") return null;

            //Если у пациента нет прикрепления
            if (string.IsNullOrEmpty(patientInfo?.AttachmentData?.CodeMO)) return null;

            return patientInfo.ConvertPersonResponseToPersonResponseDTO();
        }

    }
}
