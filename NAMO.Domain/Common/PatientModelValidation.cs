using NAMO.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace NAMO.Domain.Common
{
    public static class PatientModelValidation
    {
        //Ключи уровней валидации
        private const string FIO = "FIO";
        private const string SNILS = "SNILS";
        private const string POLIS = "POLIS";

        /// <summary>
        /// Проверяет объект PatientInfoRequest на:
        /// <para>наличие ПОЛИСа и СНИЛСа</para>
        /// <para>наличие Имени и Фамилии</para>
        /// <para>корректную дату рождения</para>
        /// </summary>
        /// <returns>
        /// <para>true - соответствие условиям</para>
        /// <para>false - в противном случае</para>
        /// </returns>
        public static bool IsValid(this PatientInfoRequest patient)
        {
            //Объект PatientInfoRequest будет использоваться в запросе по трем параметрам: ФИО, СНИЛСу и ПОЛИСу.
            //Нужно убедиться, что объект подходит хоть для одного их таких запросов.

            Dictionary<string, bool> validationLevels = GetValidationLevels();

            if (patient is null) return false;

            //Если Имя и Фамилия пустые
            if (string.IsNullOrWhiteSpace(patient.FirstName) && string.IsNullOrWhiteSpace(patient.LastName)) validationLevels[FIO] = false;

            //Проверка на корректную дату рождения
            if (string.IsNullOrEmpty(patient.BirthDate) || !DateTime.TryParse(patient.BirthDate, out _)) validationLevels[FIO] = false;

            //Если и СНИЛ и ПОЛИС пустые
            if (string.IsNullOrWhiteSpace(patient.SNILS)) validationLevels[SNILS] = false;

            if (string.IsNullOrWhiteSpace(patient.PolisS)  && string.IsNullOrWhiteSpace(patient.PolisN)) validationLevels[POLIS] = false;
            
            //Если хоть 1 из уровней имеет true
            return validationLevels.Values.Any(value => value);
        }

        /// <summary>
        /// Возвращает словарь с уровнями валидации FIO, SNILS, POLIS
        /// <para>level FIO: указывает, что объект подходит для верификации по ФИО</para>
        /// <para>level SNILS: указывает, что объект подходит для верификации по СНИЛСу</para>
        /// <para>level POLIS: указывает, что объект подходит для верификации по ПОЛИСу</para>
        /// При создании, все уровни имею значение true
        /// </summary>
        private static Dictionary<string, bool> GetValidationLevels()
        {
            return new Dictionary<string, bool>() {
                { FIO, true},
                { SNILS, true},
                { POLIS, true}
            };
        }
    }
}
