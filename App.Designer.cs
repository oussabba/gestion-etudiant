namespace MiniProjetDotNet
{
    partial class App
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.appTitleLabel = new Guna.UI.WinForms.GunaLabel();
            this.closeBtn = new Guna.UI.WinForms.GunaButton();
            this.gestionEtudiantBtn = new Guna.UI.WinForms.GunaButton();
            this.gestionNoteBtn = new Guna.UI.WinForms.GunaButton();
            this.consultationBtn = new Guna.UI.WinForms.GunaButton();
            this.closeAppBtn = new Guna.UI.WinForms.GunaButton();
            this.gestEtudActivated = new Guna.UI.WinForms.GunaSeparator();
            this.gestNotesActivated = new Guna.UI.WinForms.GunaSeparator();
            this.consultationActivated = new Guna.UI.WinForms.GunaSeparator();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gestionNotesUC1 = new MiniProjetDotNet.user_controls.GestionNotesUC();
            this.homePageUC1 = new MiniProjetDotNet.user_controls.HomePageUC();
            this.gestionEtudiantUC1 = new MiniProjetDotNet.user_controls.GestionEtudiantUC();
            this.consultationUC1 = new MiniProjetDotNet.user_controls.ConsultationUC();
            this.SuspendLayout();
            // 
            // appTitleLabel
            // 
            this.appTitleLabel.AutoSize = true;
            this.appTitleLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appTitleLabel.ForeColor = System.Drawing.Color.White;
            this.appTitleLabel.Location = new System.Drawing.Point(6, 7);
            this.appTitleLabel.Name = "appTitleLabel";
            this.appTitleLabel.Size = new System.Drawing.Size(265, 19);
            this.appTitleLabel.TabIndex = 0;
            this.appTitleLabel.Text = "Gestion des notes des étudiants";
            // 
            // closeBtn
            // 
            this.closeBtn.AnimationHoverSpeed = 0.07F;
            this.closeBtn.AnimationSpeed = 0.03F;
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.BaseColor = System.Drawing.Color.Red;
            this.closeBtn.BorderColor = System.Drawing.Color.Black;
            this.closeBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.closeBtn.FocusedColor = System.Drawing.Color.Empty;
            this.closeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Image = null;
            this.closeBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.closeBtn.Location = new System.Drawing.Point(943, 4);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.closeBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.closeBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.closeBtn.OnHoverImage = null;
            this.closeBtn.OnPressedColor = System.Drawing.Color.Black;
            this.closeBtn.Radius = 5;
            this.closeBtn.Size = new System.Drawing.Size(30, 26);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "X";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // gestionEtudiantBtn
            // 
            this.gestionEtudiantBtn.AnimationHoverSpeed = 0.07F;
            this.gestionEtudiantBtn.AnimationSpeed = 0.03F;
            this.gestionEtudiantBtn.BackColor = System.Drawing.Color.Transparent;
            this.gestionEtudiantBtn.BaseColor = System.Drawing.Color.White;
            this.gestionEtudiantBtn.BorderColor = System.Drawing.Color.Black;
            this.gestionEtudiantBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gestionEtudiantBtn.FocusedColor = System.Drawing.Color.Empty;
            this.gestionEtudiantBtn.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionEtudiantBtn.ForeColor = System.Drawing.Color.Black;
            this.gestionEtudiantBtn.Image = null;
            this.gestionEtudiantBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.gestionEtudiantBtn.Location = new System.Drawing.Point(148, 53);
            this.gestionEtudiantBtn.Name = "gestionEtudiantBtn";
            this.gestionEtudiantBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gestionEtudiantBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gestionEtudiantBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.gestionEtudiantBtn.OnHoverImage = null;
            this.gestionEtudiantBtn.OnPressedColor = System.Drawing.Color.Black;
            this.gestionEtudiantBtn.Radius = 15;
            this.gestionEtudiantBtn.Size = new System.Drawing.Size(150, 39);
            this.gestionEtudiantBtn.TabIndex = 2;
            this.gestionEtudiantBtn.Text = "Gestion des étudiants";
            this.gestionEtudiantBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gestionEtudiantBtn.Click += new System.EventHandler(this.gestionEtudiantBtn_Click);
            // 
            // gestionNoteBtn
            // 
            this.gestionNoteBtn.AnimationHoverSpeed = 0.07F;
            this.gestionNoteBtn.AnimationSpeed = 0.03F;
            this.gestionNoteBtn.BackColor = System.Drawing.Color.Transparent;
            this.gestionNoteBtn.BaseColor = System.Drawing.Color.White;
            this.gestionNoteBtn.BorderColor = System.Drawing.Color.Black;
            this.gestionNoteBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gestionNoteBtn.FocusedColor = System.Drawing.Color.Empty;
            this.gestionNoteBtn.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionNoteBtn.ForeColor = System.Drawing.Color.Black;
            this.gestionNoteBtn.Image = null;
            this.gestionNoteBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.gestionNoteBtn.Location = new System.Drawing.Point(316, 53);
            this.gestionNoteBtn.Name = "gestionNoteBtn";
            this.gestionNoteBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gestionNoteBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gestionNoteBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.gestionNoteBtn.OnHoverImage = null;
            this.gestionNoteBtn.OnPressedColor = System.Drawing.Color.Black;
            this.gestionNoteBtn.Radius = 15;
            this.gestionNoteBtn.Size = new System.Drawing.Size(150, 39);
            this.gestionNoteBtn.TabIndex = 3;
            this.gestionNoteBtn.Text = "Gestion des notes";
            this.gestionNoteBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gestionNoteBtn.Click += new System.EventHandler(this.gestionNoteBtn_Click);
            // 
            // consultationBtn
            // 
            this.consultationBtn.AnimationHoverSpeed = 0.07F;
            this.consultationBtn.AnimationSpeed = 0.03F;
            this.consultationBtn.BackColor = System.Drawing.Color.Transparent;
            this.consultationBtn.BaseColor = System.Drawing.Color.White;
            this.consultationBtn.BorderColor = System.Drawing.Color.Black;
            this.consultationBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.consultationBtn.FocusedColor = System.Drawing.Color.Empty;
            this.consultationBtn.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultationBtn.ForeColor = System.Drawing.Color.Black;
            this.consultationBtn.Image = null;
            this.consultationBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.consultationBtn.Location = new System.Drawing.Point(487, 53);
            this.consultationBtn.Name = "consultationBtn";
            this.consultationBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.consultationBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.consultationBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.consultationBtn.OnHoverImage = null;
            this.consultationBtn.OnPressedColor = System.Drawing.Color.Black;
            this.consultationBtn.Radius = 15;
            this.consultationBtn.Size = new System.Drawing.Size(150, 39);
            this.consultationBtn.TabIndex = 4;
            this.consultationBtn.Text = "Consultation";
            this.consultationBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.consultationBtn.Click += new System.EventHandler(this.consultationBtn_Click);
            // 
            // closeAppBtn
            // 
            this.closeAppBtn.AnimationHoverSpeed = 0.07F;
            this.closeAppBtn.AnimationSpeed = 0.03F;
            this.closeAppBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeAppBtn.BaseColor = System.Drawing.Color.Red;
            this.closeAppBtn.BorderColor = System.Drawing.Color.Black;
            this.closeAppBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.closeAppBtn.FocusedColor = System.Drawing.Color.Empty;
            this.closeAppBtn.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeAppBtn.ForeColor = System.Drawing.Color.White;
            this.closeAppBtn.Image = null;
            this.closeAppBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.closeAppBtn.Location = new System.Drawing.Point(656, 53);
            this.closeAppBtn.Name = "closeAppBtn";
            this.closeAppBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.closeAppBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.closeAppBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.closeAppBtn.OnHoverImage = null;
            this.closeAppBtn.OnPressedColor = System.Drawing.Color.Black;
            this.closeAppBtn.Radius = 15;
            this.closeAppBtn.Size = new System.Drawing.Size(150, 39);
            this.closeAppBtn.TabIndex = 5;
            this.closeAppBtn.Text = "Quitter";
            this.closeAppBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.closeAppBtn.Click += new System.EventHandler(this.closeAppBtn_Click);
            // 
            // gestEtudActivated
            // 
            this.gestEtudActivated.LineColor = System.Drawing.Color.White;
            this.gestEtudActivated.Location = new System.Drawing.Point(171, 96);
            this.gestEtudActivated.Name = "gestEtudActivated";
            this.gestEtudActivated.Size = new System.Drawing.Size(106, 10);
            this.gestEtudActivated.TabIndex = 8;
            this.gestEtudActivated.Thickness = 4;
            // 
            // gestNotesActivated
            // 
            this.gestNotesActivated.LineColor = System.Drawing.Color.White;
            this.gestNotesActivated.Location = new System.Drawing.Point(340, 96);
            this.gestNotesActivated.Name = "gestNotesActivated";
            this.gestNotesActivated.Size = new System.Drawing.Size(106, 10);
            this.gestNotesActivated.TabIndex = 9;
            this.gestNotesActivated.Thickness = 4;
            // 
            // consultationActivated
            // 
            this.consultationActivated.LineColor = System.Drawing.Color.White;
            this.consultationActivated.Location = new System.Drawing.Point(512, 96);
            this.consultationActivated.Name = "consultationActivated";
            this.consultationActivated.Size = new System.Drawing.Size(106, 10);
            this.consultationActivated.TabIndex = 10;
            this.consultationActivated.Thickness = 4;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Montserrat", 8F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(9, 565);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(261, 14);
            this.gunaLabel1.TabIndex = 11;
            this.gunaLabel1.Text = "Oussama BABILE - ENSA Agadir - D130002307";
            // 
            // gestionNotesUC1
            // 
            this.gestionNotesUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(19)))));
            this.gestionNotesUC1.Location = new System.Drawing.Point(85, 122);
            this.gestionNotesUC1.Name = "gestionNotesUC1";
            this.gestionNotesUC1.Size = new System.Drawing.Size(800, 400);
            this.gestionNotesUC1.TabIndex = 12;
            // 
            // homePageUC1
            // 
            this.homePageUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(19)))));
            this.homePageUC1.Location = new System.Drawing.Point(85, 122);
            this.homePageUC1.Name = "homePageUC1";
            this.homePageUC1.Size = new System.Drawing.Size(800, 400);
            this.homePageUC1.TabIndex = 7;
            // 
            // gestionEtudiantUC1
            // 
            this.gestionEtudiantUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(19)))));
            this.gestionEtudiantUC1.Location = new System.Drawing.Point(85, 122);
            this.gestionEtudiantUC1.Name = "gestionEtudiantUC1";
            this.gestionEtudiantUC1.Size = new System.Drawing.Size(800, 400);
            this.gestionEtudiantUC1.TabIndex = 6;
            // 
            // consultationUC1
            // 
            this.consultationUC1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(19)))));
            this.consultationUC1.Location = new System.Drawing.Point(85, 122);
            this.consultationUC1.Name = "consultationUC1";
            this.consultationUC1.Size = new System.Drawing.Size(800, 400);
            this.consultationUC1.TabIndex = 13;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(977, 585);
            this.Controls.Add(this.consultationUC1);
            this.Controls.Add(this.gestionNotesUC1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.consultationActivated);
            this.Controls.Add(this.gestNotesActivated);
            this.Controls.Add(this.gestEtudActivated);
            this.Controls.Add(this.homePageUC1);
            this.Controls.Add(this.gestionEtudiantUC1);
            this.Controls.Add(this.closeAppBtn);
            this.Controls.Add(this.consultationBtn);
            this.Controls.Add(this.gestionNoteBtn);
            this.Controls.Add(this.gestionEtudiantBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.appTitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App";
            this.Load += new System.EventHandler(this.App_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel appTitleLabel;
        private Guna.UI.WinForms.GunaButton closeBtn;
        private Guna.UI.WinForms.GunaButton gestionEtudiantBtn;
        private Guna.UI.WinForms.GunaButton gestionNoteBtn;
        private Guna.UI.WinForms.GunaButton consultationBtn;
        private Guna.UI.WinForms.GunaButton closeAppBtn;
        private user_controls.GestionEtudiantUC gestionEtudiantUC1;
        private user_controls.HomePageUC homePageUC1;
        private Guna.UI.WinForms.GunaSeparator gestEtudActivated;
        private Guna.UI.WinForms.GunaSeparator gestNotesActivated;
        private Guna.UI.WinForms.GunaSeparator consultationActivated;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private user_controls.GestionNotesUC gestionNotesUC1;
        private user_controls.ConsultationUC consultationUC1;
    }
}

