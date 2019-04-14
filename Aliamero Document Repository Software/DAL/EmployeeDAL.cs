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

namespace Aliamero_Document_Repository_Software.DAL
{
    class EmployeeDAL
    {
        public string connection = ConfigurationManager.ConnectionStrings["document_connection"].ToString();
        //SqlConnection con = new SqlConnection("Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=aliamero;Integrated Security=True;Pooling=False");
        public bool Insert(UserEmployeeBLL uel)
        {
            bool IsSuccess = false;
            SqlConnection con = new SqlConnection(connection);
            string sql = "INSERT INTO [dbo].[Employee]" +
                                       "([EmployeeID]" +
                                       ",[Firstname]" +
                                       ",[Lastname]" +
                                       ",[Designation]" +
                                       ",[Department]" +
                                       ",[Gender]" +
                                       ",[Picture]" +
                                       ",[Cellnumber]" +
                                       ",[EmailID])" +
                                       "VALUES" +
                                       "(@EmployeeID" +
                                       ",@Firstname" +
                                       ",@Lastname" +
                                       ",@Designation" +
                                       ",@Department" +
                                       ",@Gender" +
                                       ",@Picture" +
                                       ",@Cellnumber" +
                                      " ,@EmailID,)";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.Parameters.AddWithValue("@EmployeeID", uel.EmployeeID);
                cmd.Parameters.AddWithValue("@Firstname", uel.Firstname);
                cmd.Parameters.AddWithValue("@Lastname", uel.Lastname);
                cmd.Parameters.AddWithValue("@Designation", uel.Designation);
                cmd.Parameters.AddWithValue("@Department", uel.Designation);
                cmd.Parameters.AddWithValue("@Picture", uel.Picture);
                cmd.Parameters.AddWithValue("@Cellnumber", uel.Cellnumber);
                cmd.Parameters.AddWithValue("@EmailID", uel.Email);
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
                MessageBox.Show(ex.ToString(), "Data Access Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
                con.Dispose();
            }

            return IsSuccess;
        }
        public DataTable Select()
        {
            DataTable dt = null;
            SqlConnection con = new SqlConnection(connection);
            string sql = "SELECT [ID]" +
                ",[EmployeeID] AS [EMPLOYEEID]" +
                ",[Firstname] AS [FIRSTNAME]" +
                ",[Lastname] AS [LASTNAME]" +
                ",[Designation] AS [DESIGNATION]" +
                ",[Department] AS [DEPARTMENT]" +
                ",[Gender] AS [GENDER]" +
                ",[Cellnumber] AS [CELLNUMBER]" +
                ",[EmailID] AS [EMAIL ID]" +
            "FROM[dbo].[Employee]";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Data Access Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
            finally
            {
                con.Close();
            }

            return dt;
        }
        public DataTable Search(string keywords)
        {
            DataTable dt = null;
            SqlConnection con = new SqlConnection(connection);
            string sql = "SELECT [ID]" +
                ",[EmployeeID] AS [EMPLOYEEID]" +
                ",[Firstname] AS [FIRSTNAME]" +
                ",[Lastname] AS [LASTNAME]" +
                ",[Designation] AS [DESIGNATION]" +
               ",[Department] AS [DEPARTMENT]" +
                ",[Gender] AS [GENDER]" +
               ",[Cellnumber] AS [CELLNUMBER]" +
                ",[EmailID] AS [EMAILID]" +
            "FROM[dbo].[Employee]"+
            "WHERE [EmployeeID] LIKE '%"+keywords+"%' OR [Firstname] LIKE '%"+ keywords + "%' OR [Lastname] LIKE '%" + keywords + "%'";

            try
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Data Access Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
               
            }
            finally
            {
                con.Close();
            }
            
            return dt;
        }
    }
}
