using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;

namespace Project_New
{
    internal class DBcon
    {
        //SqlConnection con = new SqlConnection("server = .;Initial Catalog = ADO;uid =sa;pwd=sql;");
        SqlConnection con = new SqlConnection("server = LAPTOP-439QBMFT;Initial Catalog = jpproj;Integrated Security=true;");
        public int InsertProduct(int @pid, string @pname, string @pdesc)
        {

            SqlCommand cmd = new SqlCommand("Insprod", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@pname", pname);
            cmd.Parameters.AddWithValue("@pdesc", pdesc);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;

        }
        public int Updateprodct(int @pid, string @pname, string @pdesc)
        {

            SqlCommand cmd = new SqlCommand("Updprod", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@pname", pname);
            cmd.Parameters.AddWithValue("@pdesc", pdesc);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;

        }
        public int Deleteprodct(int @pid)
        {

            SqlCommand cmd = new SqlCommand("delprod1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@pid", pid);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;
        }
        public DataTable ViewproductBypid(int @pid)
        {
            SqlCommand cmd = new SqlCommand("disprod1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pid", pid);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }

        public DataTable Viewproduct()
        {
            SqlCommand cmd = new SqlCommand("disprod", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        public int InsertModel(int @mid, string @mname, int @pid,string @pname,string @spec ,int @uprice,int @soh)
        {

            SqlCommand cmd = new SqlCommand("InsModel", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@mid", mid);
            cmd.Parameters.AddWithValue("@mname", mname);
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@pname", pname);
            cmd.Parameters.AddWithValue("@spec", spec);
            cmd.Parameters.AddWithValue("@uprice", uprice);
            cmd.Parameters.AddWithValue("@soh", soh);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;

        }
        public int UpdatedModel(int @mid, string @mname, int @pid, string @pname, string @spec, int @uprice, int @soh)
        {

            SqlCommand cmd = new SqlCommand("UpdModel", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@mid", mid);
            cmd.Parameters.AddWithValue("@mname", mname);
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@pname", pname);
            cmd.Parameters.AddWithValue("@spec", spec);
            cmd.Parameters.AddWithValue("@uprice", uprice);
            cmd.Parameters.AddWithValue("@soh", soh);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;

        }
        public DataTable ViewModel()
        {
            SqlCommand cmd = new SqlCommand("disModel", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        public DataTable ViewModelBymid(int @mid)
        {
            SqlCommand cmd = new SqlCommand("disModel1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mid", mid);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        public int DeleteModel(int @mid)
        {

            SqlCommand cmd = new SqlCommand("delModel1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@mid", mid);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;
        }
        public int CHKLogin(string uid, string pwd, string utype)
        {

            SqlCommand cmd = new SqlCommand("chklog", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@uid", uid);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            cmd.Parameters.AddWithValue("@utype", utype);
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            int x = int.Parse(dr[0].ToString());
            con.Close();
            return x;

        }
        public int Insertusers(string @uid, string @pwd, string @utype)
        {

            SqlCommand cmd = new SqlCommand("Insusers", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@uid", uid);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            cmd.Parameters.AddWithValue("@utype", utype);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;

        }
        public DataTable Viewusers()
        {
            SqlCommand cmd = new SqlCommand("disusers", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        public int Updatedusers(string @uid,string @pwd ,string @utype )
        {

            SqlCommand cmd = new SqlCommand("Updusers", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@uid", uid);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            cmd.Parameters.AddWithValue("@utype", utype);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;

        }
        public int DeleteUsers(string @uid)
        {

            SqlCommand cmd = new SqlCommand("delusers1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@uid", uid);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;
        }
        public int userviewmodel(int @mid, string @mname, int @pid, string @pname, string @spec, int @unitprice, int @qty,int totamt)
        {

            SqlCommand cmd = new SqlCommand("InsSales", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@mid", mid);
            cmd.Parameters.AddWithValue("@mname", mname);
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Parameters.AddWithValue("@pname", pname);
            cmd.Parameters.AddWithValue("@spec", spec);
            cmd.Parameters.AddWithValue("@unitprice", unitprice);
            cmd.Parameters.AddWithValue("@qty",qty);
            cmd.Parameters.AddWithValue("@totamt", totamt);
            int x = cmd.ExecuteNonQuery();
            con.Close();
            return x;

        }
        public DataTable DailySalesRPT()
        {
            SqlCommand cmd = new SqlCommand("DaliyRPT", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        public DataTable productwiseRPT()
        {
            SqlCommand cmd = new SqlCommand("dissales", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        public DataTable modelwiseRPT()
        {
            SqlCommand cmd = new SqlCommand("dissales", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
        public DataTable Date_Between_2_Days()
        {
            SqlCommand cmd = new SqlCommand("SalesRpt", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sdate", sdate);
            cmd.Parameters.AddWithValue("@edate", edate);
            con.Open();
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            con.Close();
            return dt;
        }
    } 
}
