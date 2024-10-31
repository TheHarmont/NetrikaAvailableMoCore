using MediatR;
using NAMO.Application.Common;

namespace NAMO.Application.Features.Patients.Queries.GetAvailableMoIds;

public record GetAvailableMoIdsQuery : IRequest<Result<List<int>>>
{
    public string? PolisN { get; set; }
    public string? PolisS { get; set; }
    public string Polis => GetFullPolis(this);
    public string? SNILS { get; set; }
    /// <summary>
    /// Имя
    /// </summary>
    public string? FirstName { get; set; }
    /// <summary>
    /// Фамилия
    /// </summary>
    public string? LastName { get; set; }
    /// <summary>
    /// Отчество
    /// </summary>
    public string? MiddleName { get; set; }
    public string? BirthDate { get; set; }
    public DateTime? ParsedBirthDate => GetDateTimeBirthDate(this);
    public string? Sex { get; set; }

    public GetAvailableMoIdsQuery()
    {
    }

    private string GetFullPolis(GetAvailableMoIdsQuery data)
    {
        return (data.PolisS ?? "") + (data.PolisN ?? "");
    }

    private DateTime? GetDateTimeBirthDate(GetAvailableMoIdsQuery data)
    {
        return DateTime.TryParse(data.BirthDate, out DateTime parsedDate) ? parsedDate : (DateTime?)null;
    }
}


