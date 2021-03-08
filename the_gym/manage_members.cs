using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace the_gym
{
    public partial class manage_members : UserControl

    {
        public manage_members()
        {
            InitializeComponent();
        }
        public string db_con = "Data Source=DESKTOP-GGKVOVU;Initial Catalog = the_gym_2; Integrated Security = True";
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.name_text.ReadOnly = false;
            this.con_no_text.ReadOnly = false;
            this.nic_text.ReadOnly = false;
            this.address_text.ReadOnly = false;

            this.name_text.ForeColor = System.Drawing.Color.Gold;
            this.con_no_text.ForeColor = System.Drawing.Color.Gold;
            this.nic_text.ForeColor = System.Drawing.Color.Gold;
            this.address_text.ForeColor = System.Drawing.Color.Gold;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear(); 
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            if (search_t.Text == "Search")
            {
                search_t.Text = "";
            }
        }

        private void search_t_MouseLeave(object sender, EventArgs e)
        {
            if (search_t.Text == "")
            {
                search_t.Text = "Search";
            }
   
        }

        private void con_no_text_TextChanged(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            name_text.Text = "";
            con_no_text.Text = "";
            nic_text.Text = "";
            address_text.Text = "";
            gender_lab.Text = "";
            id_lab.Text = "0000";
            date_text.Text = "";

        }
        manageMembersClss managemem = new manageMembersClss();
        public string id_s;

        private void search_t_TextChanged(object sender, EventArgs e)
        {
            if (search_t.Text != "" && search_t.Text != "Search")
            {
                id_s = search_t.Text;

                managemem.manageMem(id_s);

                name_text.Text = managemem.val_name;
                con_no_text.Text = managemem.val_con;
                nic_text.Text = managemem.val_nic;
                address_text.Text = managemem.val_address;
                gender_lab.Text = managemem.val_gender;
                id_lab.Text = managemem.val_id;
                date_text.Text = managemem.val_date;


            }
            else
            {
                clear();
            }




        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (search_t.Text != "" && search_t.Text != "Search")
            {
                managemem.manageMem(search_t.Text);

                name_text.Text = managemem.val_name;
                con_no_text.Text = managemem.val_con;
                nic_text.Text = managemem.val_nic;
                address_text.Text = managemem.val_address;
                gender_lab.Text = managemem.val_gender;

            }
            else
            {
                clear();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_t.Text = "Search";

            managemem.manageMem(comboBox1.Text);

                name_text.Text = managemem.val_name;
                con_no_text.Text = managemem.val_con;
                nic_text.Text = managemem.val_nic;
                address_text.Text = managemem.val_address;
                gender_lab.Text = managemem.val_gender;
                id_lab.Text = managemem.val_id;
                date_text.Text = managemem.val_date;


            

        }

        private void manage_members_Load(object sender, EventArgs e)
        {
            combo();
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            combo();
            search_t.Text = "Search";
        }


            public void combo()
            {
                comboBox1.Items.Clear();


                SqlConnection con = new SqlConnection(db_con);
                con.Open();
                if (con.State == System.Data.ConnectionState.Open)
                {
                    string reg_query = "SELECT*FROM regis_tb";
                    SqlCommand cmd = new SqlCommand(reg_query, con);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        comboBox1.Items.Add(dr["id"].ToString());
                      
                    }

                    con.Close();


                }
            }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            this.name_text.ReadOnly = true;
            this.con_no_text.ReadOnly = true;
            this.nic_text.ReadOnly = true;
            this.address_text.ReadOnly = true;

            this.name_text.ForeColor = System.Drawing.Color.White;
            this.con_no_text.ForeColor = System.Drawing.Color.White;
            this.nic_text.ForeColor = System.Drawing.Color.White;
            this.address_text.ForeColor = System.Drawing.Color.White;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


