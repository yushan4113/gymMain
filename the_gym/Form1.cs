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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        public void bringBack()
        {
            dashboard1.Hide();
            add_members1.Hide();
            manage_members1.Hide();
            payments1.Hide();
            shedules1.Hide();
        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            bringBack();
            dashboard1.Show();
            dashboard1.BringToFront();
        }
        private void iconButton5_Click(object sender, EventArgs e)
        {
            bringBack();
            add_members1.Show();
            add_members1.BringToFront();
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            bringBack();
            manage_members1.Show();
            manage_members1.BringToFront();
        } 
        private void iconButton4_Click(object sender, EventArgs e)
        {
            bringBack();
            payments1.Show();
            payments1.BringToFront();
        }    
        private void iconButton2_Click(object sender, EventArgs e)
        {
            bringBack();
            shedules1.Show();
            shedules1.BringToFront();
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }




























        private void iconButton1_MouseEnter(object sender, EventArgs e) //button 1 mouse enter
        {
            this.iconButton1.IconColor = System.Drawing.Color.OrangeRed;
        }

        private void iconButton1_MouseLeave(object sender, EventArgs e) //button 1 mouse leave
        {
            this.iconButton1.IconColor = System.Drawing.Color.White;
        }

        private void iconButton3_MouseEnter(object sender, EventArgs e)//button 3 mouse enter
        {
            this.iconButton3.IconColor = System.Drawing.Color.LightSkyBlue;
        }

        private void iconButton3_MouseLeave(object sender, EventArgs e)//button 3 mouse leave
        {
            this.iconButton3.IconColor = System.Drawing.Color.White;
        }

        private void iconButton2_MouseEnter(object sender, EventArgs e)//button 2 mouse enter
        {
            this.iconButton2.IconColor = System.Drawing.Color.Gold;
        }

        private void iconButton2_MouseLeave(object sender, EventArgs e)//button 2 mouse leave
        {
            this.iconButton2.IconColor = System.Drawing.Color.White;
        }

        private void iconButton4_MouseEnter(object sender, EventArgs e)//button 4 mouse enter
        {
            this.iconButton4.IconColor = System.Drawing.Color.DarkViolet;
        }

        private void iconButton4_MouseLeave(object sender, EventArgs e)//button 4 mouse leave
        {
            this.iconButton4.IconColor = System.Drawing.Color.White;
        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }
        dash_process dashPro;
        public string count_mem_lab_s;

        private void Form1_Load(object sender, EventArgs e)
        {
            
            date_lab.Text = DateTime.Now.ToLongDateString();
            time_lab.Text = DateTime.Now.ToShortTimeString();

        }
    }
}
