using BackEndFinal.Model;
using Dapper;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndFinal.Data.Repositories
{
    public class DetallesRepository : IDetallesRepository
    {

        private readonly MySQLConfiguration _connectionString;

        public DetallesRepository(MySQLConfiguration connectionString)
        {
            _connectionString = connectionString;
        }

        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connectionString.ConexionString);
        }
        public async Task<bool> DeleteDetalles(Detalles detalles)
        {
            var db = dbConnection();

            var sql = @"DELETE 
                        FROM Detalles 
                        WHERE idDetalles = @idDetalles"
            ;

            var result = await db.ExecuteAsync(sql, new { id = detalles.idDetalles });

            return result > 0;
        }

        public async Task<IEnumerable<Detalles>> GetAllDetalles()
        {
            var db = dbConnection();
            var sql = @"SELECT *" +
                "FROM Detalles";

            return await db.QueryAsync<Detalles>(sql, new { });
        }

        public async Task<Detalles> GetDetails(int idDetalles)
        {
            var db = dbConnection();
            var sql = @"SELECT *
                        FROM Detalles
                        WHERE idDetalles = @idDetalles";

            return await db.QueryFirstOrDefaultAsync<Detalles>(sql, new { Id = idDetalles });
        }

        public async Task<bool> InsertDetalles(Detalles detalles)
        {
            var db = dbConnection();
            var sql = @"INSERT INTO Detalles (estado, modelo, color)" +
                "VALUES (@estado, @modelo, @color)";

            var result = await db.ExecuteAsync(sql, new { detalles.estado, detalles.modelo, detalles.color });

            return result > 0;
        }

        public async Task<bool> UpdateDetalles(Detalles detalles)
        {
            var db = dbConnection();
            var sql = @" UPDATE Detalles 
                SET estado = @estado, 
                    modelo = @modelo,
                    color = @color" +
                "WHERE idDetalles = @idDetalles ";

            var result = await db.ExecuteAsync(sql, new { detalles.estado, detalles.modelo, detalles.color });

            return result > 0;
        }
    }
}
