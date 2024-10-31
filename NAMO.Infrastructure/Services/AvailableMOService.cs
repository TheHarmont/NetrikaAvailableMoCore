using Microsoft.Extensions.Logging;
using NAMO.Application.Common;
using NAMO.Application.Features.Patients.Queries.GetAvailableMoIds;
using NAMO.Application.Interfaces;
using NAMO.Application.Interfaces.Repositories;
using NAMO.Domain.Entities;

namespace NAMO.Infrastructure.Services;

public class AvailableMOService(
    ILogger<AvailableMOService> logger,
    IMORepository moRepository) : IAvailableMOService
{
    public async Task<List<int>> GetAvailableMOIdsAsync(PersonResponse patientInfo, GetAvailableMoIdsQuery query)
    {
        // Получаем МО, соответствующие прикреплению пациента
        var moByOnlyAttachment = await moRepository.GetOnlyAttachmentAndActiveMOsByCodeMoAsync(patientInfo.AttachmentData.CodeMO);

        // Получаем МО, которые работают без прикрепления и фильтруем их по параметрам: возраст, пол, район
        var moByNonOnlyAttachment = (await moRepository.GetNonAttachmentAndActiveMOsAsync())
            .FilterByAge(query.ParsedBirthDate)
            .FilterBySex(query.Sex)
            .FilterByDistrict(moByOnlyAttachment.FirstOrDefault()?.DistrictCode);

        // Добавляем МО, которые подходят по некоторым параметрам и обязательные МО
        var allMoList = moByOnlyAttachment
            .Concat(moByNonOnlyAttachment)
            .Concat(await moRepository.GetDisplayAnyMOAsync())
            .DistinctBy(x => x.LpuId)
            .Select(x => x.LpuId)
            .ToList();

        return allMoList;
    }
}
