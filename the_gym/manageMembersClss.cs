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

    class manageMembersClss
    {
        public string val_name;
        public string val_con;
        public string val_nic;
        public string val_address;
        public string val_gender;
        public string val_id;
        public string val_date;
        public string val_id2;
        public string val_name2;

        public string db_con = "Data Source=DESKTOP-GGKVOVU;Initial Catalog = the_gym_2; Integrated Security = True";

        public void manageMem(string idd)
        {
            //int id_int = int.Parse(idd);
            if (idd != "")
            {
                SqlConnection con = new SqlConnection(db_con);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string reg_query = "SELECT*FROM regis_tb WHERE id  ='" + int.Parse(idd) + "' ";
                    SqlCommand cmd = new SqlCommand(reg_query, con);

                    //cmd.Parameters.AddWithValue("'" + id_int + "'", int.Parse(idd));
                    SqlDataReader data_r = cmd.ExecuteReader();
                    while (data_r.Read())
                    {
                        val_name = data_r.GetValue(0).ToString();
                        val_con = data_r.GetValue(1).ToString();
                        val_nic = data_r.GetValue(2).ToString();
                        val_address = data_r.GetValue(3).ToString();
                        val_gender = data_r.GetValue(4).ToString();
                        val_id= data_r.GetValue(5).ToString();
                        val_date = data_r.GetValue(6).ToString();


                    }
                    con.Close();
                }
            }

            //SqlDataAdapter adepter = new SqlDataAdapter();

        }
        public void fill_combo()
        {


        }

    }
}
