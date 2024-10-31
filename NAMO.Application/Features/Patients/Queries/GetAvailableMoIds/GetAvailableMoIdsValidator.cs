namespace NAMO.Application.Features.Patients.Queries.GetAvailableMoIds;

public class GetAvailableMoIdsValidator
{
    /// <summary>
    /// Проверяет подходит ли модель для запроса
    /// </summary>
    /// <returns>
    /// <para>true - соответствие условиям</para>
    /// <para>false - в противном случае</para>
    /// </returns>
    public bool Validate(GetAvailableMoIdsQuery? patient)
    {
        if (patient is null) return false;

        //Если Имя или Фамилия пустые
        if (string.IsNullOrWhiteSpace(patient.FirstName) || string.IsNullOrWhiteSpace(patient.LastName) || !patient.ParsedBirthDate.HasValue) 
            return false;

        //Если и СНИЛ и ПОЛИС пустые
        if (string.IsNullOrWhiteSpace(patient.PolisS) && string.IsNullOrWhiteSpace(patient.PolisN)) 
            return false;

        return true;
    }
}
