using Dapper;
using My.Bom.Software.Domain;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;

namespace My.Bom.Software.Repository
{
    public class DetailsRepository:DapperBase<Detail>
    {
        public List<Detail> GetPossibleDetails(int machineId)
        {
            using (var con = new MySqlConnection(base._connection))
            {
                return con.Query<Detail>(@"SELECT * FROM detail WHERE Id NOT IN (SELECT DetailId FROM detailmachine
                WHERE MachineId = @machineId)", new { machineId }).ToList();
            }
        }

        

        
    }
}
