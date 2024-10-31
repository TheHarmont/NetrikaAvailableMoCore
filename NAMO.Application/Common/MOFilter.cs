using NAMO.Domain.Entities.dbEntities;

namespace NAMO.Application.Common;

public static class MOFilter
{
    private static string[] SexFilterParameter = new string[] { "M", "М", "MALE" };

    /// <summary>
    /// Фильтрует список МО по возрасту пациента
    /// </summary>
    public static List<MO> FilterByAge(this List<MO> list, DateTime? birthdate)
    {
        return birthdate.HasValue && (DateTime.Now - birthdate.Value).TotalDays >= 6680
            ? list.Where(x => !x.OnlyChild).ToList()
            : list;
    }

    /// <summary>
    /// Фильтрует список МО по полу пациента
    /// </summary>
    public static List<MO> FilterBySex(this List<MO> list, string? sex)
    {
        return !string.IsNullOrEmpty(sex) && SexFilterParameter.Contains(sex.ToUpper())
            ? list.Where(x => !x.OnlyFemale).ToList()
            : list;
    }

    /// <summary>
    /// Фильтрует список МО по району прикрепления пациента
    /// </summary>
    public static List<MO> FilterByDistrict(this List<MO> list, string? districtCode)
    {
        return !string.IsNullOrEmpty(districtCode)
            ? list.Where(x => x.DistrictCode == districtCode).ToList()
            : list;
    }
}
