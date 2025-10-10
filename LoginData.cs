using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace MVCcrudoperation.Models
{
    //Create operation
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
                cmd = new SqlCommand("insert into login values(" + d.id + ",'" + safeUser + "')", con);//Create Operation
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
        //Update operation
        public string update(LoginData d)
   {
    if (string.IsNullOrEmpty(d.username))
    {
        return "Username Required";
    }
    try
    {
        string safeUser = d.username.Replace("'", "''");//Replace the Column Username to safeUser for 'Handle the Parameter error'
        con.Open();
        cmd = new SqlCommand("update login set username = '"+safeUser+"' where id = "+ d.id +"", con);//Update Operation
        cmd.ExecuteNonQuery();
        con.Close();
        return "Update success";
    }
    catch (Exception ex)
    {
        con.Close();
        return "Error:" + ex.Message;
    }
}
        //Delete operation
         public string delete(LoginData d)
 {   
     try
     {
         
         con.Open();
         cmd = new SqlCommand("delete from login  where id = " + d.id + "", con);
         cmd.ExecuteNonQuery();
         con.Close();
         return "Delete success";
     }
     catch (Exception ex)
     {
         con.Close();
         return "Error:" + ex.Message;
     }
 }
    }
}

