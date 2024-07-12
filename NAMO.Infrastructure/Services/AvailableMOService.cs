using NAMO.Application.DTOs.Response;
using NAMO.Application.Interfaces;
using NAMO.Application.Interfaces.Repositories;
using NAMO.Domain.Common;
using NAMO.Domain.Entities;

namespace NAMO.Infrastructure.Services
{
    public class AvailableMOService : IAvailableMOService
    {
        private readonly IMORepository _moListRepository;

        public AvailableMOService(IMORepository mORepository)
        {
            _moListRepository = mORepository;
        }

        public async Task<List<int>> GetAvailableMO(PersonResponseDTO? patientInfo, PatientInfoRequest patient)
        {
            try
            {
                //Получаем МО, соответствующие прикреплению пациента
                var moByOnlyAttachment = await _moListRepository.GetAttachmentMOsAsync(patientInfo?.AttachmentData?.CodeMO);
                //Получаем МО, которые работают без прикрепления
                var moByNonOnlyAttachment = await _moListRepository.GetNonAttachmentMOsAsync();

                //Наполняем основной список МО теми МО, которые подходят ему по некоторым параметрам: возраст, пол, район
                moByOnlyAttachment.AddRange(moByNonOnlyAttachment.
                    FilterByAge(patient.BirthDate).
                    FilterBySex(patient.Sex).
                    FilterByDistrict(moByOnlyAttachment.FirstOrDefault()?.DistrictCode));

                //Получаем МО, которые обязательно должны попасть в ответ 
                var moByObligatory = await _moListRepository.GetObligatoryMOAsync();
                moByOnlyAttachment.AddRange(moByObligatory);

                //Удаляем дубликаты
                moByOnlyAttachment.Distinct().ToList();

                return moByOnlyAttachment.Select(x => x.LpuId).ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
