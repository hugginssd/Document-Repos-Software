using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Aliamero_Document_Repository_System.BLL;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using Aliamero_Document_Repository_Software.DAL;

namespace Aliamero_Document_Repository_System.DAL
{
    class UserDAL
    {

        //public string connection = ConfigurationManager.ConnectionStrings["document_connection"].ToString();
        // SqlConnection con = new SqlConnection("Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=aliamero;Integrated Security=True;Pooling=False");
        Connection con = new Connection();
        public Boolean Insert(UserBLL ubll)
        {
            bool IsSuccess = false;
            SqlConnection con = new SqlConnection(this.con.connection);
            string sql = "INSERT INTO [dbo].[Users]" +
                                            "([UserId]" +
                                            ",[Firstname]" +
                                           " ,[Lastname]" +
                                            ",[Department]" +
                                            ",[Designation]" +
                                            ",[Username]" +
                                            ",[Password]" +
                                            ",[Role]" +
                                            ",[CreatedBy])" +
                                            " VALUES" +
                                            "( @UserId" +
                                            ", @Firstname" +
                                            ", @Lastname" +
                                            ", @Department" +
                                            ", @Designation" +
                                            ", @Username" +
                                            ", @Password" +
                                            ", @Role" +
                                            ", @CreatedBy)";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.Parameters.AddWithValue("@UserId", ubll.UserID);
                cmd.Parameters.AddWithValue("@Firstname", ubll.Firstname);
                cmd.Parameters.AddWithValue("@Lastname", ubll.Lastname);
                cmd.Parameters.AddWithValue("@Department", ubll.Department);
                cmd.Parameters.AddWithValue("@Designation", ubll.Department);
                cmd.Parameters.AddWithValue("@Username", ubll.Username);
                cmd.Parameters.AddWithValue("@Password", ubll.Password);
                cmd.Parameters.AddWithValue("@Role", ubll.Password);
                cmd.Parameters.AddWithValue("@CreatedBy", ubll.CreatedBy);
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
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(this.con.connection);
            string sql = "SELECT [Id]" +
                              ",[UserId]" +
                              ",[Firstname]" +
                              ",[Lastname]" +
                              ",[Department]" +
                              ",[Username]" +
                              ",[Password]" +
                              ",[Role]" +
                              ",[CreatedBy]" +
                          "FROM[dbo].[Users]";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
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
                con.Close();
            }
            return dt;
        }
        public Boolean Update(UserBLL ubll)
        {
            bool IsSuccess = false;
           SqlConnection con = new SqlConnection(this.con.connection);
            string sql = "UPDATE[dbo].[Users]" +
                                   "SET [Username] = @Username" +
                                      ",[Password] = @Password" +
                                      ",[Role] = @Role" +
                                 "WHERE [UserId] = @UserId";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.Parameters.AddWithValue("@Username", ubll.Username);
                cmd.Parameters.AddWithValue("@Password", ubll.Password);
                cmd.Parameters.AddWithValue("@Role", ubll.Password);
                cmd.Parameters.AddWithValue("@UserId", ubll.UserID);
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
        public Boolean Delete(UserBLL ubll)
        {
            bool IsSuccess = false;
            SqlConnection con = new SqlConnection(this.con.connection);
            string sql = "DELETE FROM [dbo].[Users]" +
                                "WHERE [UserId] = @UserId ";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.Parameters.AddWithValue("@UserId", ubll.UserID);
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
                con.Close();
            }
            return IsSuccess;
        }
        public DataTable Search(string keywords)
        {
            DataTable dt = new DataTable();
            SqlConnection con = new SqlConnection(this.con.connection);
            string sql = "SELECT [Id]" +
                              ",[UserId]" +
                              ",[Firstname]" +
                              ",[Lastname]" +
                              ",[Department]" +
                              ",[Username]" +
                              ",[Password]" +
                              ",[CreatedBy]" +
                              ",[Role]" +
                          "FROM [dbo].[Users]" +
                          "WHERE [UserId] LIKE '%" + keywords + "%' OR [Firstname] LIKE '%" + keywords + "%' OR [Lastname] LIKE '%" + keywords + "%' OR [Username] LIKE '%" + keywords + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
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
                con.Close();
            }
            con.Close();
            return dt;
        }
        public Boolean SignIn(UserBLL ubll)
        {
            bool IsSuccess = false;
            DataTable dt = new DataTable();
            SqlDataReader dr = null;
            SqlConnection con = new SqlConnection(this.con.connection);
            string sql = "SELECT [Id]" +
                              ",[UserId]" +
                              ",[Firstname]" +
                              ",[Lastname]" +
                              ",[Department]" +
                              ",[Username]" +
                              ",[Password]" +
                              ",[Role]" +
                              ",[CreatedBy]" +
                          "FROM [dbo].[Users]" +
                          "WHERE [Username] =@Username AND [Password] =@Password";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.Parameters.AddWithValue("@Username", ubll.Username);
                cmd.Parameters.AddWithValue("@Password", ubll.Password);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
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
                dr.Close();
                con.Close();
            }
            cmd.Dispose();
            dr.Close();
            con.Close();
            return IsSuccess;
        }
    }
}
