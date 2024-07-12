using NAMO.Application.Interfaces;
using NAMO.Application.Interfaces.Repositories;

namespace NAMO.Infrastructure.Services
{
    public class SeparatePersonsService : ISeparatePersonsService
    {
        private readonly ISeparatePersonsRepository _separatePersonsRepository;
    
        public SeparatePersonsService(ISeparatePersonsRepository separatePersonsRepository)
        {
            _separatePersonsRepository = separatePersonsRepository;
        }

        public async Task<List<int>?> GetAvailableMoAsync(string? polis)
        {
            List<int>? moIds = new();

            try
            {
                var separatePerson = await _separatePersonsRepository.GetSeparatePersonByPolisAsync(polis);
                if (!string.IsNullOrEmpty(separatePerson?.MoList))
                {
                    moIds = separatePerson?.MoList?.Split(',').Select(x => int.Parse(x)).ToList();
                }
            }
            catch (Exception)
            {
                return moIds;
                throw;
            }

            return moIds;
        }
    }
}
