using Dapper;
using My.Bom.Software.Domain;
using My.Bom.Software.ViewModels;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace My.Bom.Software.Repository
{
    class PriceHistoryRepository : DapperBase<PriceHistory>
    {
        public IEnumerable<PriceHistoryVm> GetAll()
        {
            using (var con = new MySqlConnection(_connection))
            {
                con.Open();
                return con.Query<PriceHistoryVm>(
                     @"SELECT ph.Id,ph.DetailId,ph.Price,ph.Operation,d.PartNumber,ph.Date FROM pricehistory ph
                JOIN detail d ON d.Id = DetailId");
            }
        }
    }
}
