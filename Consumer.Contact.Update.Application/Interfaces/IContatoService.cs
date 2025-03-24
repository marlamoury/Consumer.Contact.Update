using Consumer.Update.Contact.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumer.Update.Contact.Application.Services
{
    public interface IContatoService
    {
        Task SalvarContatoAsync(Contato contato);
    }
}
