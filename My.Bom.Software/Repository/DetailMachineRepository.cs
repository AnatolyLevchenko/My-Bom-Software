using Dapper;
using My.Bom.Software.Domain;
using My.Bom.Software.Helpers;
using My.Bom.Software.ViewModels;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Linq;

namespace My.Bom.Software.Repository
{
    public class DetailMachineRepository
    {
        private readonly string connection;

        public DetailMachineRepository()
        {
            connection = Extensions.GetConnection();
        }

        public bool AlreadyContainsMapping(DetailMachine dm)
        {
            using (var con = new MySqlConnection(connection))
            {
                return con.Query<int>("select 1 from detailmachine where MachineId=@m AND DetailId=@d", new { m = dm.MachineId, d = dm.DetailId }).Any();
            }
        }

        public void Insert(DetailMachine dm)
        {
            using (var con = new MySqlConnection(connection))
            {
                con.Execute("INSERT INTO detailmachine (MachineId,DetailId,Qty) VALUES(@m,@d,@q)", new { m = dm.MachineId, d = dm.DetailId, q = dm.Qty });
            }
        }

        public IEnumerable FilterByMachine(int machineId)
        {
            using (var con = new MySqlConnection(connection))
            {
                return con.Query<MachineDetailsVm>(@"SELECT Qty,m.Name as 'Machine',d.PartNumber as 'Detail',d.Price,MachineId,DetailId,d.Remark,d.Material FROM detailmachine
                                                        JOIN detail d on d.Id = DetailId
                                                        JOIN machine m on m.Id = MachineId
                                                   WHERE MachineId=@machineId", new { machineId });
            }
        }

        public void SetQuantity(MachineDetailsVm row)
        {
            using (var con=new MySqlConnection(connection))
            {
                con.Execute("UPDATE detailmachine SET Qty=@q WHERE MachineId=@m AND DetailId=@d",
                    new {q = row.Qty, m = row.MachineId, d = row.DetailId});
            }
        }


        public int Delete(MachineDetailsVm model)
        {
            using (var con = new MySqlConnection(connection))
            {
                return con.Execute("DELETE FROM detailmachine WHERE machineId=@MachineId AND detailId=@DetailId", new { model.MachineId, model.DetailId });
            }
        }
    }
}
