using BackEndFinal.Model;
using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndFinal.Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly MySQLConfiguration _connectionString;

        public ClienteRepository(MySQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connectionString.ConexionString);
        }
        public async Task<bool> DeleteCliente(Cliente cliente)
        {
            var db = dbConnection();

            var sql = @"DELETE 
                        FROM Cliente 
                        WHERE idCliente = @idCliente";

            var result = await db.ExecuteAsync(sql, new { id = cliente.idCliente });

            return result > 0;
        }

        public async Task<IEnumerable<Cliente>> GetAllClientes()
        {
            var db = dbConnection();
            var sql = @"SELECT *" +
                "FROM Cliente ";

            return await db.QueryAsync<Cliente>(sql, new { });
        }

        public async Task<Cliente> GetDetails(int idCliente)
        {
            var db = dbConnection();
            var sql = @"SELECT *
                        FROM ALUMNO
                        WHERE ID = @id";

            return await db.QueryFirstOrDefaultAsync<Cliente>(sql, new { Id = idCliente });
        }

        public async Task<bool> InsertCliente(Cliente cliente)
        {
            var db = dbConnection();
            var sql = @"INSERT INTO Cliente (idCliente, idPersona)" +
                "VALUES (@idCliente, @idPersona)";

            var result = await db.ExecuteAsync(sql, new { cliente.idCliente, cliente.idPersona });

            return result > 0;
        }

        public async Task<bool> UpdateCliente(Cliente cliente)
        {
            var db = dbConnection();
            var sql = @" UPDATE Cliente 
                SET idCliente = @idCliente, 
                    idPersona = @idPersona" +
                "WHERE idCliente = @idCliente ";

            var result = await db.ExecuteAsync(sql, new { cliente.idCliente, cliente.idPersona });

            return result > 0;
        }
    }
}
