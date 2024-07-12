using NAMO.Domain.Entities.dbEntities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMO.Domain.Common
{
    public static class MOFilter
    {
        private static string[] sexFilterParameter = new string[] { "M", "М", "MALE" };

        /// <summary>
        /// Фильтрует список доступных МО согласно возрасту пациента
        /// </summary>
        public static List<MoList> FilterByAge(this List<MoList> list, string? birthdate)
        {
            if (!DateTime.TryParse(birthdate, out DateTime birthDate)) return list;

            if (!((DateTime.Now - birthDate).TotalDays >= 6680)) return list; // 18.3 years
            
            return list.Where(x => !x.OnlyChild).ToList();
        }

        /// <summary>
        /// Фильтрует список доступных МО согласно полу пациента
        /// </summary>
        public static List<MoList> FilterBySex(this List<MoList> list, string? sex)
        {
            if (String.IsNullOrEmpty(sex)) return list;
            
            if (!sexFilterParameter.Contains(sex.ToUpper())) return list;
              
            return list = list.Where(x => !x.OnlyFemale).ToList();
        }

        /// <summary>
        /// Фильтрует список доступных МО по району прикрепления (если есть)
        /// </summary>
        public static List<MoList> FilterByDistrict(this List<MoList> list, string? districtCode)
        {
            if(string.IsNullOrEmpty(districtCode)) return list;

            return list.Where(x => x.DistrictCode == districtCode).ToList();
        }
    }
}
