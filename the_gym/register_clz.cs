using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;

namespace the_gym
{ 
    class register_clz
    { public string db_con = "Data Source=DESKTOP-GGKVOVU;Initial Catalog = the_gym_2; Integrated Security = True";

        public void  getRegDetails(string name,string cont,string nic, string addrs, string grnder,string date)
        {
            SqlConnection con = new SqlConnection(db_con);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string reg_query = "INSERT INTO regis_tb (name_c,con_no_c,nic,address_c,gender,date) VALUES ('"+name+"','"+cont+"','"+nic+"','"+addrs+"','"+grnder+ "','" + date + "')";
                SqlCommand cmd = new SqlCommand(reg_query,con);
                cmd.ExecuteNonQuery();

            }
            con.Close();
        }


        public string id_r;

        public void countID()
        {    

            SqlDataAdapter sda = new SqlDataAdapter("SELECT ISNULL(MAX(CAST(id AS int)),0)+1 FROM regis_tb", db_con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            id_r = dt.Rows[0][0].ToString();

        }
    }
}
