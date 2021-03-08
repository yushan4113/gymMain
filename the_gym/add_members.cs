using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace the_gym
{
    public partial class add_members : UserControl
    {
        public add_members()
        {
            InitializeComponent();
        }
        register_clz reg_clz = new register_clz();



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            select_one.Visible = false;
        }




        private void name_t_MouseEnter(object sender, EventArgs e)
        {
            
            if (name_t.Text == "Name") 
            {
              name_t.Text="";
              label8.Show();

            }
            else
            {
                label8.Show();
            }
            succ_lab.Visible = false;
        }

        private void name_t_MouseLeave(object sender, EventArgs e)
        {
            if (name_t.Text == "")
            {
                name_t.Text = "Name";
                label8.Hide();
            }
            else { label8.Show(); }
            
        }

        private void contact_no_MouseEnter(object sender, EventArgs e)
        {
            if (contact_no.Text == "Contact No")
            {
                contact_no.Text = "";
                label7.Show();

            }
            else
            {
                label7.Show();
            }
            succ_lab.Visible = false;
        }

        private void contact_no_MouseLeave(object sender, EventArgs e)
        {
            if (contact_no.Text == "")
            {
                contact_no.Text = "Contact No";
                label7.Hide();
            }
            else { label7.Show(); }
        }

        private void nic_t_MouseEnter(object sender, EventArgs e)
        {
            if (nic_t.Text == "NIC")
            {
                nic_t.Text = "";
                label5.Show();

            }
            else
            {
                label5.Show();
            }
            succ_lab.Visible = false;
        }

        private void nic_t_MouseLeave(object sender, EventArgs e)
        {
            if (nic_t.Text == "")
            {
                nic_t.Text = "NIC";
                label5.Hide();
            }
            else { label5.Show(); }
        }

        private void address_t_MouseEnter(object sender, EventArgs e)
        {
            if (address_t.Text == "Address")
            {
                address_t.Text = "";
                label6.Show();

            }
            else
            {
                label6.Show();
            }
            succ_lab.Visible = false;
        }

        private void address_t_MouseLeave(object sender, EventArgs e)
        {
            if (address_t.Text == "")
            {
                address_t.Text = "Address";
                label6.Hide();
            }
            else { label6.Show(); }
        }
        public void clear()
        {
            //name_t.Text = "";
            //contact_no.Text = "";
            //nic_t.Text = "";
            //address_t.Text = "";

            name_t.Text = "Name";
            contact_no.Text = "Contact No";
            nic_t.Text = "NIC";
            address_t.Text = "Address";

            label8.Hide();
            label6.Hide();
            label7.Hide();
            label5.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            clear();



        }
        public string gender_chk;
        public string date;

        private void button1_Click(object sender, EventArgs e) // member registration process  done  on here 
        {
            if (male_chk.Checked&& female_chk.Checked || !male_chk.Checked && !female_chk.Checked)
            {
                select_one.Visible = true;

            }
            else
            {
                select_one.Visible = false;

                if (male_chk.Checked)
                {
                    gender_chk = "Male";
                    
                }
                if (female_chk.Checked)
                {
                    gender_chk = "Female";
                   
                }
                date= DateTime.Now.ToLongDateString();
                reg_clz.getRegDetails(name_t.Text, contact_no.Text, nic_t.Text, address_t.Text, gender_chk,date);
                count_id_from_ad_mem();
                clear();
                count_id_from_ad_mem();
                succ_lab.Visible = true;
            }
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            count_id_from_ad_mem();
            //date_lab.Text = DateTime.Now.ToLongDateString();
        }

        public void count_id_from_ad_mem()
        {
            reg_clz.countID();
            label9.Text= reg_clz.id_r;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void female_chk_CheckedChanged(object sender, EventArgs e)
        {
            select_one.Visible = false;
        }

        private void add_members_Load(object sender, EventArgs e)
        {
            count_id_from_ad_mem();
        }
    }
}
