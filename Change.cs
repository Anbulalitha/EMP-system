using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace EMP_system
{
    class Change
    {
        public static SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Anbulalitha\EMPLOYEE MANAGEMENT SYSTEM\EMP system\EMP system\Db.mdf;Integrated Security=True");

    }
}
