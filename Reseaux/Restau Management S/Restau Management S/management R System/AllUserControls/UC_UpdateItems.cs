using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace management_R_System.AllUserControls
{
    public partial class UC_UpdateItems : UserControl
    {

        function fn = new function();
        String query;
        public UC_UpdateItems()
        {
            InitializeComponent();
        }

        private void UC_UpdateItems_Load(object sender, EventArgs e)
        {

            loadData();
        }
        public void loadData()
        {
            query = "select * from items";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void txtSearshItem_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like '" + txtSearshItem.Text + "%'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }
        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            String category = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            String name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());

            comboCategory.Text = category;
            txtName.Text = name;
            txtPrice.Text = price.ToString();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            query = "update items set name ='" + txtName.Text + "',category = '" + comboCategory.Text + "', price = " + txtPrice.Text + " where id =" + id + "";
            fn.setData(query);
            loadData();

            txtName.Clear();
            txtPrice.Clear();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}