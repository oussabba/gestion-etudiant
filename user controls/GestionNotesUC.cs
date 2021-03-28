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
    public partial class GestionNotesUC : UserControl
    {
        public GestionNotesUC()
        {
            InitializeComponent();
            FillNumInscription();
            FillModule();
        }

        private void FillNumInscription()
        {
            using (SqlConnection cnx = ConnectionDB.Cnx())
            {
                try
                {
                    cnx.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT Num_Etu FROM Etudiant", cnx);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Etudiant");
                    numInscriptionComboBox.DisplayMember = "Num_Etu";
                    numInscriptionComboBox.ValueMember = "Num_Etu";
                    numInscriptionComboBox.DataSource = ds.Tables["Etudiant"];
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
        private void FillModule()
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

        private void numInscriptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection cnx = ConnectionDB.Cnx())
            {
                try
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Nom_Etu,Prenom_Etu FROM Etudiant WHERE Num_Etu=@numEtudiant", cnx);
                    SqlParameter numEtudParameter = new SqlParameter();
                    numEtudParameter.ParameterName = "numEtudiant";
                    numEtudParameter.Value = numInscriptionComboBox.SelectedValue;
                    cmd.Parameters.Add(numEtudParameter);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        nomEtudiantTextBox.Text = reader["Nom_Etu"].ToString() + " " + reader["Prenom_Etu"].ToString();
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

        private void moduleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection cnx = ConnectionDB.Cnx())
            {
                try
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("SELECT Note FROM Notes WHERE Num_Etu=@numEtudiant AND Num_Mod=@numModule", cnx);
                    SqlParameter numEtudParameter = new SqlParameter();
                    numEtudParameter.ParameterName = "numEtudiant";
                    numEtudParameter.Value = numInscriptionComboBox.SelectedValue;
                    cmd.Parameters.Add(numEtudParameter);
                    SqlParameter numModParameter = new SqlParameter();
                    numModParameter.ParameterName = "numModule";
                    numModParameter.Value = moduleComboBox.SelectedValue;
                    cmd.Parameters.Add(numModParameter);
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        noteTextBox.Text = reader["Note"].ToString();
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

        private void nouveauBtn_Click(object sender, EventArgs e)
        {
            numInscriptionComboBox.SelectedValue = 1;
            moduleComboBox.SelectedValue = 1;
            nomEtudiantTextBox.Text = "";
            noteTextBox.Text = "";

        }

        private void enregistrerNoteButton_Click(object sender, EventArgs e)
        {
            if (noteTextBox.Text == "")
            {
                MessageBox.Show("Veillez saisir une note !");
            }
            else
            {
                using (SqlConnection cnx = ConnectionDB.Cnx())
                {
                    try
                    {
                        cnx.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Notes WHERE Num_Etu=@numEtudiant AND Num_Mod=@numModule", cnx);
                        SqlParameter numEtudParameter = new SqlParameter();
                        numEtudParameter.ParameterName = "@numEtudiant";
                        numEtudParameter.Value = numInscriptionComboBox.SelectedValue;
                        cmd.Parameters.Add(numEtudParameter);
                        SqlParameter numModParameter = new SqlParameter();
                        numModParameter.ParameterName = "@numModule";
                        numModParameter.Value = moduleComboBox.SelectedValue;
                        cmd.Parameters.Add(numModParameter);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            if (reader["Note"] != null)
                            {
                                MessageBox.Show("La note est déja saisie");
                            }
                        }
                        else
                        {
                            reader.Close();
                            SqlCommand insertCmd = new SqlCommand("INSERT INTO Notes VALUES (@numEtudiant,@numModule,@note)", cnx);
                            SqlParameter numEtudParameter2 = new SqlParameter();
                            numEtudParameter2.ParameterName = "@numEtudiant";
                            numEtudParameter2.Value = numInscriptionComboBox.SelectedValue;
                            numModParameter.ParameterName = "@numModule";
                            numModParameter.Value = moduleComboBox.SelectedValue;
                            SqlParameter noteParameter = new SqlParameter();
                            noteParameter.ParameterName = "@note";
                            noteParameter.Value = noteTextBox.Text;

                            insertCmd.Parameters.Add(numEtudParameter2);
                            insertCmd.Parameters.Add(numModParameter);
                            insertCmd.Parameters.Add(noteParameter);

                            if (insertCmd.ExecuteNonQuery() != 0)
                            {
                                MessageBox.Show("Note ajoutée avec succés");
                            }
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

        private void modifierButton_Click(object sender, EventArgs e)
        {
            if (noteTextBox.Text == "")
            {
                MessageBox.Show("Veillez saisir une note !");
            }
            else
            {
                using (SqlConnection cnx = ConnectionDB.Cnx())
                {
                    try
                    {
                        cnx.Open();
                        SqlCommand updateCmd = new SqlCommand("UPDATE Notes SET Note=@note WHERE Num_Etu=@numEtudiant AND Num_Mod=@numModule", cnx);
                        SqlParameter numEtudParameter2 = new SqlParameter();
                        numEtudParameter2.ParameterName = "@numEtudiant";
                        numEtudParameter2.Value = numInscriptionComboBox.SelectedValue;
                        SqlParameter numModParameter = new SqlParameter();
                        numModParameter.ParameterName = "@numModule";
                        numModParameter.Value = moduleComboBox.SelectedValue;
                        SqlParameter noteParameter = new SqlParameter();
                        noteParameter.ParameterName = "@note";
                        noteParameter.Value = noteTextBox.Text;

                        updateCmd.Parameters.Add(numEtudParameter2);
                        updateCmd.Parameters.Add(numModParameter);
                        updateCmd.Parameters.Add(noteParameter);

                        if (updateCmd.ExecuteNonQuery() != 0)
                        {
                            MessageBox.Show("Note mise à jour avec succés");
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

        private void apercuButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnx = ConnectionDB.Cnx())
            {
                String query = "SELECT n.Num_Mod, m.Nom_Mod, n.Note FROM Module m,Notes n WHERE m.Num_Mod=n.Num_Mod AND n.Num_Etu=" + numInscriptionComboBox.SelectedValue;
                SqlDataAdapter adapter = new SqlDataAdapter(query, cnx);
                DataSet data = new DataSet();
                try
                {
                    cnx.Open();
                    adapter.Fill(data, "Notes");
                    DataTable dataTable = data.Tables["Notes"];

                    notesEtudiantDataGridView.DataSource = dataTable;
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
