using NAMO.Domain.Entities.dbEntities;

namespace NAMO.Application.Interfaces.Repositories
{
    public interface ISeparatePersonsRepository
    {
        /// <summary>
        /// Возвращает первый элемент <see cref="SeparatePerson"/>, соответствующий указанному <paramref name="polis" />
        /// </summary>
        /// <remarks>
        ///     <para>
        ///         Предназначен для отдельной обработки запроса по персонам, принадлежащим к отдельной группе лиц.
        ///     </para>
        /// </remarks>
        /// <exception cref="Exception"></exception>
        /// <returns>Объект <see cref="SeparatePerson"/>, либо null, если не найден
        /// </returns>
        public Task<SeparatePerson?> GetSeparatePersonByPolisAsync(string? polis);
    }
}
