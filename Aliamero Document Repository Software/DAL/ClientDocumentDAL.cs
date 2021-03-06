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
    class ClientDocumentDAL
    {
        //public string connection = ConfigurationManager.ConnectionStrings["document_connection"].ToString();
        //SqlConnection con = new SqlConnection("Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=aliamero;Integrated Security=True;Pooling=False");
        Connection con = new Connection();
        public bool Insert(ClientDocumentBLL cbll)
        {
            bool IsSuccess = false;
            SqlConnection con = new SqlConnection(this.con.connection);
                  string sql = "INSERT INTO [dbo].[ClientDocuments]" +
                                               "([ClientName]" +
                                               ",[DocumentType]" +
                                               ",[DocumentNumber]" +
                                               ",[DocumentName]" +
                                               ",[SubmittedDate]" +
                                               ",[Discription]" +
                                               ",[DocumentPath])" +
                                         "VALUES" +
                                              " (@ClientName" +
                                              " ,@DocumentType" +
                                              " ,@DocumentNumber" +
                                              " ,@DocumentName" +
                                              " ,@SubmittedDate" +
                                              " ,@Discription" +
                                              " ,@DocumentPath)";

            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.Parameters.AddWithValue("@ClientName", cbll.ClientName);
                cmd.Parameters.AddWithValue("@DocumentType", cbll.DocumentType);
                cmd.Parameters.AddWithValue("@DocumentNumber", cbll.DocumentNumber);
                cmd.Parameters.AddWithValue("@DocumentName", cbll.DocumentName);
                cmd.Parameters.AddWithValue("@SubmittedDate", cbll.SubmittDate);
                cmd.Parameters.AddWithValue("@Discription", cbll.Description);
                cmd.Parameters.AddWithValue("@DocumentPath", cbll.DocumentPath);
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
                                  ",[ClientName] AS [CLIENT NAME]" +
                                  ",[DocumentType] AS [DOCUMENT TYPE]" +
                                  ",[DocumentNumber] AS [DOCUMENT NUMBER]" +
                                  ",[DocumentName] AS [DOCUMENT NAME]" +
                                  ",[SubmittedDate] AS [SUBMITTED DATE]" +
                                  ",[Discription] AS [DESCRIPTION]" +
                                  ",[DocumentPath] AS [DOCUMENT PATH]" +
                              "FROM[dbo].[ClientDocuments]";
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
