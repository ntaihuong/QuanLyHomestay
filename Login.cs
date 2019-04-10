using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomestayApp
{
    public static class Login
    {
        private static QuanLyHomestayEntities db = new QuanLyHomestayEntities();
        public static bool testLogin(string tk, string mk)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-T99N63L\\SQLEXPRESS2012;Initial Catalog=QuanLyHomestay;Integrated Security=True"); 
           try
            {
                conn.Open();
                string sql = "select * from TAIKHOAN where TaiKhoan= '"+tk+"' and MatKhau= '"+mk+"'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if(dta.Read() == true)
                {
                    return true;
                }
            }
            catch
            {
                
            }
            return false;
        }
        
    }
}
