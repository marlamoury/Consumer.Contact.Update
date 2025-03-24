using Consumer.Update.Contact.Domain.Entities;
using Consumer.Update.Contact.Infrastructure.Persistence;
using System.Threading.Tasks;

namespace Consumer.Update.Contact.Application.Services
{
    public class ContatoService : IContatoService
    {
        private readonly IContatoRepository _contatoRepository;

        public ContatoService(IContatoRepository contatoRepository)
        {
            _contatoRepository = contatoRepository;
        }

        public async Task SalvarContatoAsync(Contato contato)
        {
            await _contatoRepository.UpdateContatoAsync(contato);
        }
    }
}
