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
    class dash_process
    {
        public string db_con = "Data Source=DESKTOP-GGKVOVU;Initial Catalog = the_gym_2; Integrated Security = True";
        public string  countMem_val;
        //public string val_id;
        DataSet ds = new DataSet();

        public void countMem()
        {
            
            string query = "SELECT*FROM regis_tb";
           
            
            SqlDataAdapter da = new SqlDataAdapter(query, db_con);
            da.Fill(ds);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);

            count();

        }
        public void count()
        {
            countMem_val = ds.Tables[0].Rows.Count.ToString();
        }
    }
}
