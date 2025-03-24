using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumer.Update.Contact.Application.DTOs
{
    public static class ContatoDtoExtensions
    {
        public static Consumer.Update.Contact.Domain.Entities.Contato ToEntity(this ContatoDto dto)
        {
            return new Consumer.Update.Contact.Domain.Entities.Contato
            {
                Id = dto.Id,
                Nome = dto.Nome,
                Telefone = dto.Telefone,
                Email = dto.Email,
                Ddd = dto.Ddd,
                Regiao = dto.Regiao,
                DataHoraRegistro = dto.DataHoraRegistro
            };
        }
    }
}
