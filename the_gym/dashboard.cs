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
    public partial class dashboard : UserControl
    {
       

        public dashboard()
        {
            InitializeComponent();

          

        }
        dash_process dashPro;

        private void iconButton1_Click(object sender, EventArgs e)
        {
            load();
        }

        public void load()
        {

            dashPro = new dash_process();
            dashPro.countMem();
            count_mem_lab.Text = dashPro.countMem_val;
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            load();
        }
    }
}
