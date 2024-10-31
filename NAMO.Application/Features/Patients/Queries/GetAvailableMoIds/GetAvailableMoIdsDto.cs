namespace NAMO.Application.Features.Patients.Queries.GetAvailableMoIds;

public class GetAvailableMoIdsDto
{
    public required List<int> Organisations { get; set; }
    public int Status { get; set; }
    public string? Message { get; set; }
}
