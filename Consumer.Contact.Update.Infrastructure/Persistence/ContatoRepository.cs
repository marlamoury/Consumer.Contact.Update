
using Dapper;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;
using Consumer.Update.Contact.Domain.Entities;
using Consumer.Update.Contact.Infrastructure.Persistence;

namespace Consumer.Contact.Update.Infrastructure.Persistence
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly string _connectionString;

        public ContatoRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task UpdateContatoAsync(Contato contato)
        {
            // Atualizar a data de atualização antes de salvar
            contato.DataHoraRegistro = DateTime.Now;

            const string query = @"
        UPDATE contatos 
        SET nome = @Nome, telefone = @Telefone, email = @Email, ddd = @Ddd, regiao = @Regiao, DataHoraRegistro = @DataHoraRegistro
        WHERE id = @Id;";

            try
            {
                using var connection = new MySqlConnection(_connectionString);
                await connection.ExecuteAsync(query, contato);
                Console.WriteLine($"Contato atualizado com sucesso: {contato.Nome}");
                //_logger.LogInformation($"Contato atualizado com sucesso: {contato.Nome}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"erro ao atualizar contato");
                //_logger.LogError(ex, "Erro ao atualizar o contato: {Mensagem}", ex.Message);
                throw;
            }
        }
    }
}
