using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAMO.Application.DTOs.Response;
using NAMO.Domain.Entities;

namespace NAMO.Application.Interfaces
{
    public interface IPatiVerService
    {
        /// <summary>
        /// Метод возвращает информацию о пользователе, используя всю информацию в запросе.
        /// Просто последовательно выполняет запрос по ФИО, СНИЛС, ПОЛИС. Возвращает первый успешный результат.
        /// </summary>
        /// <returns>
        /// <para>null, если пациент не найден или нет прикрепления</para>
        /// </returns>
        public PersonResponseDTO? GetPersonResponseDTOByAllData(PatientInfoRequest patient);

        /// <summary>
        /// Метод возвращает информацию о пользователе, используя данные ФИО
        /// </summary>
        /// <returns>
        /// <para>Объект DTO, если пациент найден</para>
        /// <para>null, если пациент не найден или нет прикрепления</para>
        /// </returns>
        public PersonResponseDTO? GetPersonResponseDTOByFIO(PatientInfoRequest patient);

        /// <summary>
        /// Метод возвращает информацию о пользователе, используя данные СНИЛС
        /// </summary>
        /// <returns>
        /// <para>Объект DTO, если пациент найден</para>
        /// <para>null, если пациент не найден или нет прикрепления</para>
        /// </returns>
        public PersonResponseDTO? GetPersonResponseDTOBySNILS(PatientInfoRequest patient);

        /// <summary>
        /// Метод возвращает информацию о пользователе, используя данные ПОЛИС
        /// </summary>
        /// <returns>
        /// <para>Объект DTO, если пациент найден</para>
        /// <para>null, если пациент не найден или нет прикрепления</para>
        /// </returns>
        public PersonResponseDTO? GetPersonResponseDTOByPOLIS(PatientInfoRequest patient);
    }
}
