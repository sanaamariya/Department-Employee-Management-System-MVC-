using System.Data;
using System.Data.Common;
using Microsoft.Data.SqlClient;

namespace crudapp.Models
{
    public class datalayer
    {
        SqlConnection con;
        void dbconn()
        {
            con = new SqlConnection("Server=localhost,1433;Database=Training;User Id=sa;Password=123PWsql;TrustServerCertificate=True;");
            con.Open();
        }
        public IEnumerable<Dept> GetDepts()
        {
            List<Dept> lstdept = new List<Dept>();
            dbconn();
            SqlCommand cmd = new SqlCommand("getdept", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                Dept dpt = new Dept();
                dpt.dno = Convert.ToInt32(rdr["Deptno"]);
                dpt.dna = rdr["Dname"].ToString();
                dpt.dloc = rdr["loc"].ToString();

                lstdept.Add(dpt);

            }
            con.Close();
            return lstdept;
        }
        public void createdept(Dept dpt)
        {
            dbconn();
            SqlCommand cmd = new SqlCommand("createdept", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@dno", dpt.dno);
            cmd.Parameters.AddWithValue("@dna", dpt.dna);
            cmd.Parameters.AddWithValue("@dloc", dpt.dloc);

            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void updatedept(Dept dpt)
        {
            dbconn();
            SqlCommand cmd = new SqlCommand("updatedept", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dno", dpt.dno);
            cmd.Parameters.AddWithValue("@dna", dpt.dna);
            cmd.Parameters.AddWithValue("@dloc",dpt.dloc);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void DeleteStudent(int? id)
        {
            dbconn();
            SqlCommand cmd = new SqlCommand("deletedept", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@dno", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public Dept GetdeptData(int? id)
        {
            Dept dpt = new Dept();
            dbconn();
            string sqlQuery = "SELECT * FROM dept WHERE Deptno=" + id;
            SqlCommand cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dpt.dno = Convert.ToInt32(rdr["Deptno"]);
                dpt.dna = rdr["Dname"].ToString();
                dpt.dloc = rdr["Loc"].ToString();

            }
            return dpt;
        }
    }
}