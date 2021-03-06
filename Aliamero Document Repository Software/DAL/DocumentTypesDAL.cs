﻿using Aliamero_Document_Repository_System.BLL;
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
    class DocumentTypesDAL
    {
        // public string connection = ConfigurationManager.ConnectionStrings["document_connection"].ToString();
        //SqlConnection con = new SqlConnection("Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=aliamero;Integrated Security=True;Pooling=False");
Connection con = new Connection();
        public bool Insert(DocumentTypesBLL dbll)
        {
            bool IsSuccess = false;
            SqlConnection con = new SqlConnection(this.con.connection);
            string sql = "INSERT INTO [dbo].[DocumentTypes]" +
                                               "([DocumentType]" +
                                               ",[SubmittedByEmployee])" +
                                         "VALUES" +
                                               "(@DocumentType" +
                                               ",@SubmittedByEmployee)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@DocumentType", dbll.DocumentType);
            cmd.Parameters.AddWithValue("@SubmittedByEmployee", dbll.SubmittedByEmployee);
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
                              ",[DocumentType]" +
                              ",[SubmittedByEmployee]" +
                          "FROM[dbo].[DocumentTypes]";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt= new DataTable();
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
