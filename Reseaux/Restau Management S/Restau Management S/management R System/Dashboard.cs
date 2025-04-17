using management_R_System.AllUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace management_R_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
          Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uS_ADDItems1.Visible = true;
            uS_ADDItems1.BringToFront();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            uS_PlaceOrder1.Visible = true;
            uS_PlaceOrder1.BringToFront();
        }

        private void uS_ADDItems1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uS_ADDItems1.Visible=false;
            uS_PlaceOrder1.Visible=false;
            uC_UpdateItems1.Visible=false;
            uC_UpdateItems1.Visible = false;
            uC_RemoveItem1.Visible = false;
            uC_Reservation1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uC_UpdateItems1.Visible=true;
            uC_UpdateItems1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            uC_RemoveItem1.Visible=true;  
            uC_RemoveItem1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            uC_Reservation1.Visible = true;
            uC_Reservation1.BringToFront();
        }

        private void uC_Reservation1_Load(object sender, EventArgs e)
        {

        }
    }
}
