using Dapper;
using My.Bom.Software.Domain;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My.Bom.Software.Repository
{
    public class DetailsRepository : DapperBase<Detail>
    {
        public List<Detail> GetPossibleDetails(int machineId)
        {
            using (var con = new MySqlConnection(base._connection))
            {
                return con.Query<Detail>(@"SELECT * FROM detail WHERE Id NOT IN (SELECT DetailId FROM detailmachine
                WHERE MachineId = @machineId)", new { machineId }).ToList();
            }
        }

        public override Task<Detail> InsertAsync(Detail t)
        {
            var task = base.InsertAsync(t);

            var pr = new PriceHistoryRepository();
            pr.InsertAsync(new PriceHistory
            {
                Date = DateTime.UtcNow,
                DetailId = t.Id,
                Price = t.Price ?? 0,
                Operation = Operation.Create
            }).Wait();

            return task;
        }

        public override Task UpdateAsync(Detail t)
        {
            var price = GetByIdAsync(t.Id).Result.Price;
            var task = base.UpdateAsync(t);
           

            if (price != t.Price)
            {
                var pr = new PriceHistoryRepository();
                pr.InsertAsync(new PriceHistory
                {
                    Date = DateTime.UtcNow,
                    DetailId = t.Id,
                    Price = t.Price ?? 0,
                    Operation = Operation.Update
                }).Wait();
            }

            return task;
        }
    }
}
