using Aliamero_Document_Repository_System.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Aliamero_Document_Repository_Software.DAL;

namespace Aliamero_Document_Repository_System.DAL
{
    class DesignationDAL
    {
        //public string connection = ConfigurationManager.ConnectionStrings["document_connection"].ToString(); //giving problems on my machine!! Sounds funny?? Magic!! Thats reality!!
        //SqlConnection con = new SqlConnection("Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=aliamero;Integrated Security=True;Pooling=False");
        Connection con = new Connection();
        public bool Insert(DesignationBLL dbll)
        {
            bool IsSuccess = false;
            SqlConnection con = new SqlConnection(this.con.connection);
            string sql = "INSERT INTO [dbo].[Designation]" +
                                           "([Designation]" +
                                           ",[Description])" +
                                           "VALUES" +
                                           "(@Designation" +
                                           ",@Description)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@Designation", dbll.Designation);
            cmd.Parameters.AddWithValue("@Description", dbll.Designation);
            try
            {
                con.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    IsSuccess = true;
                }
                else
                {
                    IsSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Data Access Error");
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return IsSuccess;
        }
        public DataTable Select()
        {
            DataTable dt = null;
            SqlConnection con = new SqlConnection(this.con.connection);
            string sql = "SELECT [ID]" +
                              ",[Designation]" +
                              ",[Description]" +
                         "FROM[dbo].[Designation]";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Data Access Error");
            }
            finally
            {
                dt.Clear();
                cmd.Dispose();
                con.Dispose();
            }
            return dt;
        }
    }
}
