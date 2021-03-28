using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MiniProjetDotNet.user_controls
{
    public partial class ConsultationUC : UserControl
    {
        public ConsultationUC()
        {
            InitializeComponent();
            FillModules();
        }

        private void FillModules()
        {
            using (SqlConnection cnx = ConnectionDB.Cnx())
            {
                try
                {
                    cnx.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT Num_Mod,Nom_Mod FROM Module", cnx);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Module");
                    moduleComboBox.DisplayMember = "Nom_Mod";
                    moduleComboBox.ValueMember = "Num_Mod";
                    moduleComboBox.DataSource = ds.Tables["Module"];
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void moduleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection cnx = ConnectionDB.Cnx())
            {
                string query = "SELECT e.Num_Etu, e.Nom_Etu, e.Prenom_Etu, n.Note FROM Etudiant e,Notes n WHERE e.Num_Etu=n.Num_Etu AND n.Num_Mod=" + moduleComboBox.SelectedValue;
                SqlDataAdapter adapter = new SqlDataAdapter(query, cnx);
                DataSet data = new DataSet();
                try
                {
                    cnx.Open();
                    adapter.Fill(data, "Etudiants");
                    DataTable dataTable = data.Tables["Etudiants"];

                    listeEtudiantDataGridView.DataSource = dataTable;

                    SqlCommand cmd = new SqlCommand("SELECT AVG(Note) AS moyenne FROM Notes WHERE Num_Mod=@numModule", cnx);
                    SqlParameter numModParameter = new SqlParameter();
                    numModParameter.ParameterName = "@numModule";
                    numModParameter.Value = moduleComboBox.SelectedValue;
                    cmd.Parameters.Add(numModParameter);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        moyenneClasseTextBox.Text = reader["moyenne"].ToString();
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
