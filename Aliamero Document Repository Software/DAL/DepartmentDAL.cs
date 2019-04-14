using Aliamero_Document_Repository_System.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aliamero_Document_Repository_Software.DAL
{
    class DepartmentDAL
    {
        public string connection = ConfigurationManager.ConnectionStrings["document_connection"].ToString();
        //SqlConnection con = new SqlConnection("Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=aliamero;Integrated Security=True;Pooling=False");
        public bool Insert(DepartmentBLL dbll)
        {
            bool IsSuccess = false;
            SqlConnection con = new SqlConnection(connection);
            string sql = "INSERT INTO [dbo].[Department]" +
                                               "([Department]" +
                                               ",[Description])" +
                                               "VALUES" +
                                               "(@Department" +
                                               ",@Description)";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.Parameters.AddWithValue("@Department", dbll.Department);
                cmd.Parameters.AddWithValue("@Description", dbll.Description);
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
            SqlConnection con = new SqlConnection(connection);
            string sql = "SELECT[ID]" +
                          ",[Department]" +
                          ",[Description]" +
                          "FROM[dbo].[Department]";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Data Access Error");
            }
            finally
            {
                cmd.Dispose();
                dt.Clear();
                con.Close();
            }

            return dt;
        }
    }
}
