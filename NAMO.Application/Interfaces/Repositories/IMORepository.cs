using NAMO.Domain.Entities.dbEntities;

namespace NAMO.Application.Interfaces.Repositories
{
    public interface IMORepository
    {
        /// <summary>
        /// Возвращает список всех МО из БД
        /// </summary>
        /// <exception cref="Exception"></exception>
        public Task<List<MoList>> GetAllMOsAsync();

        /// <summary>
        /// Возвращает список актуальных МО, код которых соответствует коду прикрепления пациента
        /// </summary>
        /// <exception cref="Exception"></exception>
        public Task<List<MoList>> GetAttachmentMOsAsync(string? codeMO);

        /// <summary>
        /// Возвращает список актуальных МО, работающих без прикрепления
        /// </summary>
        /// <exception cref="Exception"></exception>
        public Task<List<MoList>> GetNonAttachmentMOsAsync();

        /// <summary>
        /// Возвращает список актуальных МО, которые обязательно должны попасть в ответ.
        /// </summary>
        /// <exception cref="Exception"></exception>
        public Task<List<MoList>> GetObligatoryMOAsync();
    }
}
