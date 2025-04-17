using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace management_R_System.AllUserControls
{
    public partial class US_ADDItems : UserControl
    {
        function fn = new function();
        String query;

        public US_ADDItems()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO items (name, category, price) VALUES ('"+ txtItem.Text+"' , '"+txtCategory.Text+"',"+txtPrice.Text+")";
            fn.setData(query);
            clearAll();
        }
        public void clearAll()
        {
            txtCategory.SelectedIndex = -1;
            txtItem.Clear();
            txtPrice.Clear();
            
        }

        private void US_ADDItems_Load(object sender, EventArgs e)
        {

        }

        private void txtCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
