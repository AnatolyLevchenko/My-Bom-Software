using Dapper;
using My.Bom.Software.Domain;
using My.Bom.Software.Settings;
using MySql.Data.MySqlClient;
using System.Linq;

namespace My.Bom.Software.Repository
{
    public class DetailMachineRepository
    {
        private readonly string connection;

        public DetailMachineRepository()
        {
            connection  = MainSettings.ReadSettings().ConnectionString;
        }

        public bool AlreadyContainsMapping(DetailMachine dm)
        {
            using (var con=new MySqlConnection(connection))
            {
                return con.Query<int>("select 1 from detailmachine where MachineId=@m AND DetailId=@d",new{m=dm.MachineId,d=dm.DetailId}).Any();
            }
        }

        public void Insert(DetailMachine dm)
        {
            using (var con=new MySqlConnection(connection))
            {
                con.Execute("INSERT INTO detailmachine (MachineId,DetailId,Qty) VALUES(@m,@d,@q)", new {m=dm.MachineId,d=dm.DetailId,q=dm.Qty });
            }
        }
    }
}
