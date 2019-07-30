using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLibrary
{
    public static class DataAccess
    {
        public static string GetConnectionString(string name = "DapperDemoDB")
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static List<SystemUserModel> GetAllUsers()
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                var output = cnn.Query<SystemUserModel>("spSystemUser_Get", commandType: CommandType.StoredProcedure).ToList();

                return output;
            }
        }
    }
}
