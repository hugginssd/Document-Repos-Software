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

namespace Aliamero_Document_Repository_System.DAL
{
    class EmployeeDocumentDAL
    {
        public string connection = ConfigurationManager.ConnectionStrings["document_connection"].ToString();
        //SqlConnection con = new SqlConnection("Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=aliamero;Integrated Security=True;Pooling=False");
        public bool Insert(EmployeeDocumentBLL ebll)
        {
            bool IsSuccess = false;
            SqlConnection con = new SqlConnection(connection);
            string sql = "INSERT INTO [dbo].[EmployeeDocuments]" +
                                                   "([EmployeeID]" +
                                                   ",[DocumentType]" +
                                                   ",[DocumentNumber]" +
                                                   ",[DocumentPath]" +
                                                   ",[SubmittedDate]" +
                                                   ",[Original]" +
                                                   ",[Expiry]" +
                                                   ",[ExpiryDate])" +
                                            "VALUES" +
                                                   "(@EmployeeID" +
                                                   ",@DocumentType" +
                                                   ",@DocumentNumber" +
                                                   ",@DocumentPath" +
                                                   ",@SubmittedDate" +
                                                   ",@Original" +
                                                   ",@Expiry" +
                                                   ",@ExpiryDate)";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@EmployeeID", ebll.EmployeeID);
            cmd.Parameters.AddWithValue("@DocumentType", ebll.DocumentType);
            cmd.Parameters.AddWithValue("@DocumentNumber", ebll.DocumentNumber);
            cmd.Parameters.AddWithValue("@DocumentPath", ebll.DocumentPath);
            cmd.Parameters.AddWithValue("@SubmittedDate", ebll.SubmittedDate);
            cmd.Parameters.AddWithValue("@Original", ebll.OriginalDuplicate);
            cmd.Parameters.AddWithValue("@Expiry", ebll.ExpiryNo);
            cmd.Parameters.AddWithValue("@ExpiryDate", ebll.ExpiryDate);
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
        public DataTable SelectDepartments()
        {
            DataTable dt = null;
           SqlConnection con = new SqlConnection(connection);
            string sql = "SELECT [ID]" +
                          ",[Department]" +
                          ",[Description]" +
                      "FROM[aliamero].[dbo].[Department]";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
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
                cmd.Dispose();
                con.Close();
            }
            return dt;
        }
        public DataTable SelectEmployee(string department)
        {
            DataTable dt = null;
            SqlConnection con = new SqlConnection(connection);
            string sql = "SELECT[ID]" +
                                 " ,[EmployeeID]" +
                                  ",[Firstname]" +
                                  ",[Lastname]" +
                                  ",[Designation]" +
                                  ",[Department]" +
                                  ",[Gender]" +
                                  ",[Picture]" +
                                  ",[Cellnumber]" +
                                  ",[EmailID]" +
                                  "FROM [dbo].[Employee]" +
                                  "WHERE [Department] =" + department;
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
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
                cmd.Dispose();
                con.Close();
            }
            return dt;
        }
        public DataTable SelectDocumentTypes()
        {
            DataTable dt = null;
            SqlConnection con = new SqlConnection(connection);
            string sql = "SELECT [ID]" +
                          ",[DocumentType]" +
                          ",[Description]" +
                      "FROM[dbo].[DocumentTypes]";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
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
                cmd.Dispose();
                con.Close();
            }
            return dt;
        }
        public DataTable SelectEmployeeDetails(string id)
        {
            DataTable dt = null;
            SqlConnection con = new SqlConnection(connection);
            string sql = "SELECT TOP 1000 [aliamero].[dbo].[Employee].[ID]" +
                                                              ",[EmployeeID]" +
                                                              ",[Firstname]" +
                                                              ",[Lastname]" +
                                                              ",[Gender]" +
                                                              ",[Picture]" +
                                                              ",[Cellnumber]" +
                                                              ",[EmailID]" +
                                                              ",[aliamero].[dbo].[Designation].[Designation] AS DESIG" +
                                                              ",[aliamero].[dbo].[Department].[Department] AS DPT" +
                                                          "FROM[aliamero].[dbo].[Employee]" +
                                                                "INNER JOIN[aliamero].[dbo].[Designation]" +
                                                                "ON[aliamero].[dbo].[Employee].[Designation] = [aliamero].[dbo].[Designation].[ID]" +
                                                                "INNER JOIN[aliamero].[dbo].[Department]" +
                                                                "ON[aliamero].[dbo].[Employee].[Department] = [aliamero].[dbo].[Department].[ID]" +
                                                                "WHERE[aliamero].[dbo].[Employee].[ID]=" + id;

            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
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
                cmd.Dispose();
                con.Close();
            }
            return dt;
        }
    }
}
