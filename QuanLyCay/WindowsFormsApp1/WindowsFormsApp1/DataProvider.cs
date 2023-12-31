﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DataProvider
    {
        private string connectionString = "Data Source=DESKTOP-HBMUEHM\\SQLEXPRESS;Initial Catalog=QuanLyCay;Integrated Security=True";

        public DataTable execQuery(string query)
        {
            DataTable data = new DataTable();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(data);

                con.Close();
            }
            return data;
        }

        public int execNonQuery(string query)
        {
            int data = 0;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open() ;

                SqlCommand cmd = new SqlCommand(query, con);

                data = cmd.ExecuteNonQuery();
                con.Close() ;
            }
            return data;
        }

        public object execScalar(string query)
        {
            object data = 0;
            using ( SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open() ;

                SqlCommand cmd = new SqlCommand(query, con);

                data = cmd.ExecuteScalar();

                con.Close() ;
            }
            return data;
        }
    }
}
