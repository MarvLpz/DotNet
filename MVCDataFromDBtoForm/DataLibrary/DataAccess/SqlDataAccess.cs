using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Required imports
//had to install system.data.client using rightclick to datalibrary project then nugget install
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration; // for accessing the string connection configuration in web.config
//you can use control dot to install red lined packages like ConfigurationManager if it's missing
// you need to add Dapper in the References
namespace DataLibrary.DataAccess
{
    public class SqlDataAccess
    {
        public static string GetConnectionString(string connectionName = "MVCDemoDB") {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        //return type T which is a generic collection.
        //sql argument is a sql cmd statement like select
        public static List<T> LoadData<T>(string sql){
            //IDbConnection is from System.Data
            //the using statement ensures the correct use of IAsyncDisposable objects.
            using (IDbConnection cnn = new SqlConnection(GetConnectionString())) {
                return cnn.Query<T>(sql).ToList();
            }
        }
        //sql argument is a sql cmd statement like select
        public static int SaveData<T>(string sql, T data) {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString())) {
                return cnn.Execute(sql,data);
            }
        }
    }
}
