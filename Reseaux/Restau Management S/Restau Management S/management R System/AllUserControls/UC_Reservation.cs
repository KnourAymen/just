using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace management_R_System.AllUserControls
{
    public partial class UC_Reservation : UserControl
    {
        function fn = new function();
        String query;

        public UC_Reservation()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            query = "select * from Reservation";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void UC_Reservation_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string nom = txtNom.Text;
                int nombrePersonne = int.Parse(txtNombrePersonne.Text);
                DateTime dateReservation = dateTimePickerDate.Value;
                TimeSpan heureReservation = dateTimePickerHeure.Value.TimeOfDay;
                string tableReservation = comboBoxTable.SelectedItem.ToString();

                string query = $"INSERT INTO Reservation (Nom, NombrePersonne, DateReservation, HeureReservation, TableReservation) " +
                               $"VALUES ('{nom}', {nombrePersonne}, '{dateReservation:yyyy-MM-dd}', '{heureReservation}', '{tableReservation}')";
                fn.setData(query);
                loadData(); // Actualiser le DataGridView après l'ajout
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de l'ajout de la réservation : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtNombrePersonne.Clear();
            txtNom.Clear();
            txtIdReservation.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idReservation = int.Parse(txtIdReservation.Text);
                string nom = txtNom.Text;
                int nombrePersonne = int.Parse(txtNombrePersonne.Text);
                DateTime dateReservation = dateTimePickerDate.Value;
                TimeSpan heureReservation = dateTimePickerHeure.Value.TimeOfDay;
                string tableReservation = comboBoxTable.SelectedItem.ToString();

                string query = $"UPDATE Reservation SET Nom = '{nom}', NombrePersonne = {nombrePersonne}, " +
                               $"DateReservation = '{dateReservation:yyyy-MM-dd}', HeureReservation = '{heureReservation}', " +
                               $"TableReservation = '{tableReservation}' WHERE IdReservation = {idReservation}";
                fn.setData(query);
                loadData(); // Actualiser le DataGridView après la modification
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la modification de la réservation : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtNombrePersonne.Clear();
            txtNom.Clear();
            txtIdReservation.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int idReservation = int.Parse(txtIdReservation.Text);

                string query = $"DELETE FROM Reservation WHERE IdReservation = {idReservation}";
                fn.setData(query);
                loadData(); // Actualiser le DataGridView après la suppression
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la suppression de la réservation : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtNombrePersonne.Clear();
            txtNom.Clear();
            txtIdReservation.Clear();
        }
        int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    txtIdReservation.Text = row.Cells["IdReservation"].Value.ToString();
                    txtNom.Text = row.Cells["Nom"].Value.ToString();
                    txtNombrePersonne.Text = row.Cells["NombrePersonne"].Value.ToString();
                    dateTimePickerDate.Value = Convert.ToDateTime(row.Cells["DateReservation"].Value);
                    dateTimePickerHeure.Value = DateTime.Today.Add((TimeSpan)row.Cells["HeureReservation"].Value);
                    comboBoxTable.SelectedItem = row.Cells["TableReservation"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors de la sélection de la réservation : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    }
    




