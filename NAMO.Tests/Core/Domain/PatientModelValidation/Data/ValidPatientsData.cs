using NAMO.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMO.Tests.Core.Domain.PatientModelValidation.Data
{
    public class ValidPatientsData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                //Все данные корректны
                new PatientInfoRequest
                {
                    PolisN = "12345",
                    PolisS = "12345",
                    SNILS = "12345",
                    FirstName = "Имя",
                    LastName = "Фамилия",
                    MiddleName = "Отчество",
                    BirthDate = "01.01.2000",
                    Sex = "M",
                }
            };

            yield return new object[]
            {
                //Есть только ФИО + ДР
                new PatientInfoRequest
                {
                    PolisN = "",
                    PolisS = "",
                    SNILS = "",
                    FirstName = "Имя",
                    LastName = "Фамилия",
                    MiddleName = "Отчество",
                    BirthDate = "01.01.2000",
                    Sex = "М",
                }
            };

            yield return new object[]
            {
                //Есть только снилс
                new PatientInfoRequest
                {
                    PolisN = "",
                    PolisS = "",
                    SNILS = "12345",
                    FirstName = "",
                    LastName = "",
                    MiddleName = "",
                    BirthDate = "",
                    Sex = "М",
                }
            };

            yield return new object[]
            {
                //Есть только полис
                new PatientInfoRequest
                {
                    PolisN = "",
                    PolisS = "",
                    SNILS = "12345",
                    FirstName = "",
                    LastName = "",
                    MiddleName = "",
                    BirthDate = "",
                    Sex = "М",
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
