using Consumer.Update.Contact.Domain.Entities;
using System.Threading.Tasks;

namespace Consumer.Update.Contact.Infrastructure.Persistence
{
    public interface IContatoRepository
    {
        Task UpdateContatoAsync(Contato contato);
    }
}
