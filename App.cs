using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProjetDotNet
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            homePageUC1.Show();
            homePageUC1.BringToFront();
            gestionEtudiantUC1.Hide();
            gestNotesActivated.Hide();
            gestEtudActivated.Hide();
            consultationActivated.Hide();
        }

        private void App_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gestionEtudiantBtn_Click(object sender, EventArgs e)
        {
            gestionEtudiantUC1.Show();
            gestionEtudiantUC1.BringToFront();
            homePageUC1.Hide();
            gestionNotesUC1.Hide();
            consultationUC1.Hide();
            gestNotesActivated.Hide();
            gestEtudActivated.Show();
            consultationActivated.Hide();
        }

        private void gestionNoteBtn_Click(object sender, EventArgs e)
        {
            gestionNotesUC1.Show();
            gestionNotesUC1.BringToFront();
            gestionEtudiantUC1.Hide();
            homePageUC1.Hide();
            consultationUC1.Hide();
            gestNotesActivated.Show();
            gestEtudActivated.Hide();
            consultationActivated.Hide();
        }

        private void consultationBtn_Click(object sender, EventArgs e)
        {
            consultationUC1.Show();
            consultationUC1.BringToFront();
            gestionNotesUC1.Hide();
            gestionEtudiantUC1.Hide();
            homePageUC1.Hide();
            gestNotesActivated.Hide();
            gestEtudActivated.Hide();
            consultationActivated.Show();
        }

        private void closeAppBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
