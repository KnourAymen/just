using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace management_R_System.AllUserControls
{
    public partial class UC_RemoveItem : UserControl
    {
        function fn = new function();
        String query;
        int id = -1; // Initialize id with an invalid value

        public UC_RemoveItem()
        {
            InitializeComponent();
        }

        static SqlConnection cnx = new SqlConnection("Server = DESKTOP-D68MPPO ; Database = resto; Integrated Security=true");
        public SqlCommand cmd = new SqlCommand("", cnx);
        public SqlDataReader Dr;
        public DataTable dt = new DataTable();

        // Method to check if the item exists
        public int exist()
        {
            int x;
            cmd.CommandText = "Select count(id) from items where id=@id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", TextBox1.Text);
            cmd.Connection = cnx;
            cnx.Open();
            x = (int)cmd.ExecuteScalar();
            cnx.Close();
            return x;
        }

        // Method to delete the item
        public bool Supprimer()
        {
            if (exist() != 0)
            {
                cmd.CommandText = "delete from items where id=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", TextBox1.Text);
                cmd.Connection = cnx;
                cnx.Open();
                cmd.ExecuteNonQuery();
                cnx.Close();
                LoadDataGrid(); // Refresh the data grid view after deletion
                return true;
            }
            else
            {
                return false;
            }
        }

        // Method to load data into the data grid view
        private void LoadDataGrid()
        {
            dt.Clear();
            cmd.CommandText = "select * from items";
            cmd.Connection = cnx;
            cnx.Open();
            Dr = cmd.ExecuteReader();
            dt.Load(Dr);
            dataGridView1.DataSource = dt;
            cnx.Close();
        }

        private void UC_RemoveItem_Load(object sender, EventArgs e)
        {
            LoadDataGrid();
        }

        private void txtSearshItem_TextChanged(object sender, EventArgs e)
        {
            query = "SELECT * FROM items WHERE name LIKE @name";
            DataSet ds = fn.getDataWithParameter(query, new SqlParameter("@name", txtSearshItem.Text + "%"));
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;

            if (txtSearshItem.Text == "")
            {
                MessageBox.Show("Un champ vide ");
            }
            else if (int.TryParse(TextBox1.Text, out id) == false)
            {
                MessageBox.Show("Un champ invalide");
            }
            else
            {
                if (Supprimer() == true)
                {
                    MessageBox.Show("Supprimé avec succès");
                }
                else
                {
                    MessageBox.Show("Élément à supprimer n'existe pas");
                }
                TextBox1.Clear();
                txtSearshItem.Clear();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadDataGrid(); // Refresh the data grid view
        }

        // The function class for executing parameterized queries
        public class function
        {
            // Method to execute a parameterized query and return a DataSet
            public DataSet getDataWithParameter(string query, SqlParameter parameter)
            {
                using (SqlConnection conn = new SqlConnection("Server = DESKTOP-D68MPPO ; Database = resto; Integrated Security=true"))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add(parameter);
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        return ds;
                    }
                }
            }
            int id  ;
            private object dataGridView1;
            private object TextBox1;

          

            // Method to execute a parameterized non-query
            public void setDataWithParameter(string query, SqlParameter parameter)
            {
                using (SqlConnection conn = new SqlConnection("Server = DESKTOP-D68MPPO ; Database = resto; Integrated Security=true"))
                {
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add(parameter);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void txtSearshItem_TextChanged_1(object sender, EventArgs e)
        {
            query = "SELECT * FROM items WHERE name LIKE @name";
            DataSet ds = fn.getDataWithParameter(query, new SqlParameter("@name", txtSearshItem.Text + "%"));
            dataGridView1.DataSource = ds.Tables[0];
        }
     
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            TextBox1.Text = id.ToString();
        }
    }
}
