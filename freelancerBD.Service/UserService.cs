using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using freelancerBD.Entities;
using freelancerBD.IService;
using freelancerBD.Infrastructure;
using System.Data.Entity;
using System.Data.SqlClient;

namespace freelancerBD.Service
{
    public class UserService : AdminCommon<User>, IUserService
    {
        public UserService(DbContext context) : base(context)
        {
        }
        
        //public bool Insert(string name,string password,string role)
        //{


        //    Connection cn = new Connection();
        //    cn.connOpen();
        //    using(SqlCommand cmd = new SqlCommand("insert int user(Name,Password,Role) values(@n,@p,@r)",cn.con))
        //    {
        //        cmd.Parameters.AddWithValue("@n", name);
        //        cmd.Parameters.AddWithValue("@p", password);
        //        cmd.Parameters.AddWithValue("@r", role);
        //        try
        //        {
        //            cmd.ExecuteNonQuery();
        //            cn.connClose();
        //            return true;
        //        }
        //        catch
        //        {
        //            cn.connClose();
        //            return false;
        //        }

        //    }

        //    //    SqlConnection con = new SqlConnection();
        //    //        con.ConnectionString = "Data Source=.\\SQLSERVER;Initial Catalog=University;Integrated Security=True;Pooling=False";
        //    //    // server = DESKTOP - LR0QREH\SQLSERVER
        //    //    string query1 = "insert into User(Name,Password,Role) values ("
        //    //+ name + ",'" + password + "'," + role + ")";



        //    //    SqlCommand cmd1 = new SqlCommand(query1, con);
        //    //    con.Open();
        //    //    int a = cmd1.ExecuteNonQuery();
        //    //    if (a== 0)
        //    //    {
        //    //        con.Close();
        //    //        return false;

        //    //    }
        //    //    else
        //    //    {
        //    //        con.Close();
        //    //        return true;

        //    //    }



        //}
    }
}
