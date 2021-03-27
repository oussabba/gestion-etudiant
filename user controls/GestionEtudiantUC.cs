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
    public partial class GestionEtudiantUC : UserControl
    {
        public GestionEtudiantUC()
        {
            InitializeComponent();
        }

        private void nouveauBtn_Click(object sender, EventArgs e)
        {
            numEtudiantTextBox.Text = "";
            nomEtudiantTextBox.Text = "";
            prenomEtudiantTextBox.Text = "";
            dateNaissanceDateTimePicker.CustomFormat = " ";
            dateNaissanceDateTimePicker.Format = DateTimePickerFormat.Custom;
        }

        private void rechercherButton_Click(object sender, EventArgs e)
        {
            if(numEtudiantTextBox.Text=="" || !int.TryParse(numEtudiantTextBox.Text, out _))
            {
                MessageBox.Show("Veuillez saisir un numéro valide !");
            }
            else
            {
                using (SqlConnection cnx = ConnectionDB.Cnx())
                {
                    try
                    {
                        cnx.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Etudiant WHERE Num_Etu=@numEtudiant", cnx);
                        SqlParameter numEtudParameter = new SqlParameter();
                        numEtudParameter.ParameterName = "numEtudiant";
                        numEtudParameter.Value = numEtudiantTextBox.Text;
                        cmd.Parameters.Add(numEtudParameter);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            nomEtudiantTextBox.Text = reader["Nom_Etu"].ToString();
                            prenomEtudiantTextBox.Text = reader["Prenom_Etu"].ToString();
                            dateNaissanceDateTimePicker.Value = (DateTime) reader["DateN_Etu"];
                        }
                        else
                        {
                            MessageBox.Show("Aucun étudiant avec le numéro saisi !");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }       
            }
        }

        private void ajouterButton_Click(object sender, EventArgs e)
        {
            if(numEtudiantTextBox.Text=="" || nomEtudiantTextBox.Text=="" || prenomEtudiantTextBox.Text=="" || dateNaissanceDateTimePicker.Value == null)
            {
                MessageBox.Show("Tous les champs sont requis !");
            }
            else
            {
                using (SqlConnection cnx = ConnectionDB.Cnx())
                {
                    try
                    {
                        cnx.Open();
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Etudiant WHERE Num_Etu=@numEtudiant", cnx);
                        SqlParameter numEtudParameter = new SqlParameter();
                        numEtudParameter.ParameterName = "@numEtudiant";
                        numEtudParameter.Value = numEtudiantTextBox.Text;
                        cmd.Parameters.Add(numEtudParameter);
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            MessageBox.Show("Ce numéro d'inscription existe déja !");
                        }
                        else
                        {
                            reader.Close();
                            SqlCommand insertCmd = new SqlCommand("INSERT INTO Etudiant VALUES (@numEtudiant,@nomEtudiant,@prenomEtudiant,@dateNaissance)", cnx);
                            SqlParameter numEtudParameter2 = new SqlParameter();
                            numEtudParameter2.ParameterName = "@numEtudiant";
                            numEtudParameter2.Value = numEtudiantTextBox.Text;
                            SqlParameter nomEtudParameter = new SqlParameter();
                            nomEtudParameter.ParameterName = "@nomEtudiant";
                            nomEtudParameter.Value = nomEtudiantTextBox.Text;
                            SqlParameter prenomEtudParameter = new SqlParameter();
                            prenomEtudParameter.ParameterName = "@prenomEtudiant";
                            prenomEtudParameter.Value = prenomEtudiantTextBox.Text;
                            SqlParameter dateNEtudParameter = new SqlParameter();
                            dateNEtudParameter.ParameterName = "@dateNaissance";
                            dateNEtudParameter.Value = dateNaissanceDateTimePicker.Value;

                            insertCmd.Parameters.Add(numEtudParameter2);
                            insertCmd.Parameters.Add(nomEtudParameter);
                            insertCmd.Parameters.Add(prenomEtudParameter);
                            insertCmd.Parameters.Add(dateNEtudParameter);

                            if (insertCmd.ExecuteNonQuery() != 0)
                            {
                                MessageBox.Show("Etudiant ajouté avec succés");
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }
}
