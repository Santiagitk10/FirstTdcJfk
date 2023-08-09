using Dapper;
using FirstTdcJfk.Application.Interfaces;
using FirstTdcJfk.Domain.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTdcJfk.Infrastructure.Repositories
{
    public class TdcRepository : ITdcRepository
    {
        private readonly IConfiguration configuration;

        public TdcRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public async Task<int> AddAsync(Tdc entity)
        {
            var sql = "Insert into Tdcs (CardNumber,Category,Franchise,GoodThru,ClientName,CutoffDate,PaymentDate,Limit,Spent,Rate,Status) VALUES (@CardNumber,@Category,@Franchise,@GoodThru,@ClientName,@CutoffDate,@PaymentDate,@Limit,@Spent,@Rate,@Status)";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, entity);
                return result;
            }
        }

        public async Task<int> DeleteAsync(int id)
        {
            var sql = "DELETE FROM Tdcs WHERE Id = @Id";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, new { Id = id });
                return result;
            }
        }

        public async Task<IEnumerable<Tdc>> GetAllAsync()
        {
            var sql = "SELECT * FROM Tdcs";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Tdc>(sql);
                return result.ToList();
            }
        }

        public async Task<Tdc> GetByIdAsync(int id)
        {
            var sql = "SELECT * FROM Tdcs WHERE Id = @Id";
            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QuerySingleOrDefaultAsync<Tdc>(sql, new { Id = id });
                return result;
            }
        }

        public async Task<int> UpdateAsync(Tdc entity)
        {
            var sql = "UPDATE Tdcs SET CardNumber = @CardNumber,Category = @Category,Franchise = @Franchise,GoodThru = @GoodThru,ClientName = @ClientName,CutoffDate = @CutoffDate,PaymentDate = @PaymentDate,Limit = @Limit,Spent = @Spent, Rate = @Rate,Status = @Status  WHERE Id = @Id";

            using (var connection = new SqlConnection(configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.ExecuteAsync(sql, entity);
                return result;
            }
        }
    }
}