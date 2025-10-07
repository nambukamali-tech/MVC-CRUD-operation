using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace MVCcrudoperation.Models
{
    public class LoginData
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EHPCDIL\SQLEXPRESS02;Initial Catalog=nambu;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public int id { get; set; }
        public string username { get; set; }

        public string save(LoginData d)
        {
            if(string.IsNullOrEmpty(d.username))
            {
                return "Username Required";
            }
            try
            {
                string safeUser = d.username.Replace("'", "''");
                con.Open();
                cmd = new SqlCommand("insert into login values(" + d.id + ",'" + safeUser + "')", con);
                cmd.ExecuteNonQuery();
                con.Close();
                return "Login success";
            }
            catch(Exception ex)
            {
                con.Close();
                return "Error:" + ex.Message;
            }
        }
    }
}