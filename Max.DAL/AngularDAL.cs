using Dapper;
using Max.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max.DAL
{
    public class AngularDAL
    {
        public List<LicensensModel> GetLicensensList()
        {
            using (IDbConnection connection = OpenConnection())
            {
                const string query = "SELECT * FROM Licenses";
                return connection.Query<LicensensModel>(query).ToList();
            }
        }

        private IDbConnection OpenConnection()
        {
           string constr = "Data Source=10.55.160.101;Initial Catalog=vxCustomer_dev;User ID=sa;Password=P@ssw0rd;MultipleActiveResultSets=True";
           SqlConnection conn = new SqlConnection();
           conn.ConnectionString = constr;
           return conn;
        }
    }
}
