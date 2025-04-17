using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace management_R_System.AllUserControls
{
    public partial class US_PlaceOrder : UserControl
    {
        function fn = new function();
        String query;
        int total = 0;
        int amount;

        public US_PlaceOrder()
        {
            InitializeComponent();
            printDocument.PrintPage += new PrintPageEventHandler(printDocument_PrintPage);  // Lier l'événement PrintPage
        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            String category = comboCategory.Text;
            query = "SELECT name FROM items WHERE category = '" + category + "'";
            showItemList(query);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            String category = comboCategory.Text;
            query = "SELECT name FROM items WHERE category = '" + category + "' AND name LIKE '" + txtSearch.Text + "%'";
            showItemList(query);
        }

        private void showItemList(String query)
        {
            listBox1.Items.Clear();
            DataSet ds = fn.getData(query);
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                listBox1.Items.Add(row[0].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuantite.ResetText();
            txtTotal.Clear();
            String text = listBox1.GetItemText(listBox1.SelectedItem);
            txtItemNam.Text = text;
            query = "SELECT price FROM items WHERE name = '" + text + "'";
            DataSet ds = fn.getData(query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
        }

        private void txtQuantite_ValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPrice.Text))
            {
                Int64 quan = Int64.Parse(txtQuantite.Value.ToString());
                Int64 price = Int64.Parse(txtPrice.Text);
                txtTotal.Text = (quan * price).ToString();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtItemNam.Text) &&
                !string.IsNullOrWhiteSpace(txtPrice.Text) &&
                txtQuantite.Value > 0 &&
                !string.IsNullOrWhiteSpace(txtTotal.Text))
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = txtItemNam.Text;
                dataGridView1.Rows[n].Cells[1].Value = txtPrice.Text;
                dataGridView1.Rows[n].Cells[2].Value = txtQuantite.Value;
                dataGridView1.Rows[n].Cells[3].Value = txtTotal.Text;

                total += int.Parse(txtTotal.Text);
                txtTotalAmount.Text = total + " DH";
            }
            else
            {
                MessageBox.Show("La quantité minimale doit être de 1 et tous les champs doivent être remplis.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtItemNam.Clear();
            txtPrice.Clear();
            txtTotal.Clear();
            txtQuantite.Value = 0;

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedRowIndex = dataGridView1.SelectedRows[0].Index;
                    int rowAmount = int.Parse(dataGridView1.Rows[selectedRowIndex].Cells[3].Value.ToString());
                    total -= rowAmount;
                    txtTotalAmount.Text = total + " DH";
                    dataGridView1.Rows.RemoveAt(selectedRowIndex);
                }
            }
            catch
            {
                MessageBox.Show("Veuillez sélectionner une ligne à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }

        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font printFont = new Font("Arial", 12);
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            float lineHeight = printFont.GetHeight(e.Graphics);
            float yPosition = topMargin;

            // Imprimer l'en-tête
            e.Graphics.DrawString("Reçu", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, leftMargin, yPosition);
            yPosition += lineHeight * 2;

            e.Graphics.DrawString("Article", printFont, Brushes.Black, leftMargin, yPosition);
            e.Graphics.DrawString("Quantité", printFont, Brushes.Black, leftMargin + 200, yPosition);
            e.Graphics.DrawString("Prix", printFont, Brushes.Black, leftMargin + 400, yPosition);
            yPosition += lineHeight;

            e.Graphics.DrawString(new string('-', 80), printFont, Brushes.Black, leftMargin, yPosition);
            yPosition += lineHeight;

            // Imprimer les articles du DataGridView
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                string item = row.Cells[0].Value?.ToString() ?? string.Empty;
                string quantity = row.Cells[2].Value?.ToString() ?? string.Empty;
                string price = row.Cells[1].Value?.ToString() ?? string.Empty;

                e.Graphics.DrawString(item, printFont, Brushes.Black, leftMargin, yPosition);
                e.Graphics.DrawString(quantity, printFont, Brushes.Black, leftMargin + 200, yPosition);
                e.Graphics.DrawString(price, printFont, Brushes.Black, leftMargin + 400, yPosition);
                yPosition += lineHeight;
            }

            e.Graphics.DrawString(new string('-', 80), printFont, Brushes.Black, leftMargin, yPosition);
            yPosition += lineHeight;

            // Imprimer le total
            e.Graphics.DrawString("Total: " + total.ToString("C"), new Font("Arial", 14, FontStyle.Bold), Brushes.Black, leftMargin + 400, yPosition);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void US_PlaceOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
