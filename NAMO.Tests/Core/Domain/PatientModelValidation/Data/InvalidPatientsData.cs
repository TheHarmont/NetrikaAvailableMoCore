using NAMO.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NAMO.Tests.Core.Domain.PatientModelValidation.Data
{
    public class InvalidPatientsData : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                //Пустой запрос
                new PatientInfoRequest
                {
                }
            };

            yield return new object[]
            {
                //Пустой запрос
                new PatientInfoRequest
                {
                    PolisN = "",
                    PolisS = "",
                    SNILS = "",
                    FirstName = "",
                    LastName = "",
                    MiddleName = "",
                    BirthDate = "",
                    Sex = "",
                }
            };

            yield return new object[]
            {
                //Есть имя, нет фамилии
                new PatientInfoRequest
                {
                    PolisN = "",
                    PolisS = "",
                    SNILS = "",
                    FirstName = "Имя",
                    LastName = "",
                    MiddleName = "",
                    BirthDate = "",
                    Sex = "M",
                }
            };

            yield return new object[]
            {
                //Есть Фамилия, нет имени
                new PatientInfoRequest
                {
                    PolisN = "",
                    PolisS = "",
                    SNILS = "",
                    FirstName = "Имя",
                    LastName = "",
                    MiddleName = "",
                    BirthDate = "",
                    Sex = "M",
                }
            };

            yield return new object[]
            {
                //Есть имя, нет фамилии
                new PatientInfoRequest
                {
                    PolisN = "",
                    PolisS = "",
                    SNILS = "",
                    FirstName = "Имя",
                    LastName = "",
                    MiddleName = "",
                    BirthDate = "",
                    Sex = "M",
                }
            };

            yield return new object[]
            {
                //ФИО дата рождения некорректная
                new PatientInfoRequest
                {
                    PolisN = "",
                    PolisS = "",
                    SNILS = "",
                    FirstName = "Имя",
                    LastName = "Фамилия",
                    MiddleName = "Отчество",
                    BirthDate = "20.2023.18",
                    Sex = "M",
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
