namespace MiniProjetDotNet.user_controls
{
    partial class GestionNotesUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.numInscLabel = new Guna.UI.WinForms.GunaLabel();
            this.numInscriptionComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.fullNameLabel = new Guna.UI.WinForms.GunaLabel();
            this.nomEtudiantTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.noteTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.moduleComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.modifierButton = new Guna.UI.WinForms.GunaButton();
            this.enregistrerNoteButton = new Guna.UI.WinForms.GunaButton();
            this.nouveauBtn = new Guna.UI.WinForms.GunaButton();
            this.apercuButton = new Guna.UI.WinForms.GunaButton();
            this.gunaVSeparator1 = new Guna.UI.WinForms.GunaVSeparator();
            this.notesEtudiantDataGridView = new Guna.UI.WinForms.GunaDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.notesEtudiantDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // numInscLabel
            // 
            this.numInscLabel.AutoSize = true;
            this.numInscLabel.Font = new System.Drawing.Font("Montserrat", 9F);
            this.numInscLabel.ForeColor = System.Drawing.Color.White;
            this.numInscLabel.Location = new System.Drawing.Point(90, 26);
            this.numInscLabel.Name = "numInscLabel";
            this.numInscLabel.Size = new System.Drawing.Size(142, 15);
            this.numInscLabel.TabIndex = 3;
            this.numInscLabel.Text = "Numéro d\'inscription :";
            // 
            // numInscriptionComboBox
            // 
            this.numInscriptionComboBox.BackColor = System.Drawing.Color.Transparent;
            this.numInscriptionComboBox.BaseColor = System.Drawing.Color.White;
            this.numInscriptionComboBox.BorderColor = System.Drawing.Color.Silver;
            this.numInscriptionComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.numInscriptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numInscriptionComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.numInscriptionComboBox.Font = new System.Drawing.Font("Montserrat", 9F);
            this.numInscriptionComboBox.ForeColor = System.Drawing.Color.Black;
            this.numInscriptionComboBox.FormattingEnabled = true;
            this.numInscriptionComboBox.Location = new System.Drawing.Point(239, 22);
            this.numInscriptionComboBox.Name = "numInscriptionComboBox";
            this.numInscriptionComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.numInscriptionComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.numInscriptionComboBox.Radius = 5;
            this.numInscriptionComboBox.Size = new System.Drawing.Size(249, 23);
            this.numInscriptionComboBox.TabIndex = 4;
            this.numInscriptionComboBox.SelectedIndexChanged += new System.EventHandler(this.numInscriptionComboBox_SelectedIndexChanged);
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Montserrat", 9F);
            this.fullNameLabel.ForeColor = System.Drawing.Color.White;
            this.fullNameLabel.Location = new System.Drawing.Point(90, 81);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(110, 15);
            this.fullNameLabel.TabIndex = 5;
            this.fullNameLabel.Text = "Nom et Prénom :";
            // 
            // nomEtudiantTextBox
            // 
            this.nomEtudiantTextBox.BackColor = System.Drawing.Color.Transparent;
            this.nomEtudiantTextBox.BaseColor = System.Drawing.Color.White;
            this.nomEtudiantTextBox.BorderColor = System.Drawing.Color.Silver;
            this.nomEtudiantTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nomEtudiantTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.nomEtudiantTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.nomEtudiantTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.nomEtudiantTextBox.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomEtudiantTextBox.Location = new System.Drawing.Point(239, 72);
            this.nomEtudiantTextBox.Name = "nomEtudiantTextBox";
            this.nomEtudiantTextBox.PasswordChar = '\0';
            this.nomEtudiantTextBox.Radius = 15;
            this.nomEtudiantTextBox.SelectedText = "";
            this.nomEtudiantTextBox.Size = new System.Drawing.Size(249, 35);
            this.nomEtudiantTextBox.TabIndex = 6;
            // 
            // noteTextBox
            // 
            this.noteTextBox.BackColor = System.Drawing.Color.Transparent;
            this.noteTextBox.BaseColor = System.Drawing.Color.White;
            this.noteTextBox.BorderColor = System.Drawing.Color.Silver;
            this.noteTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.noteTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.noteTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.noteTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.noteTextBox.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteTextBox.Location = new System.Drawing.Point(239, 229);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.PasswordChar = '\0';
            this.noteTextBox.Radius = 15;
            this.noteTextBox.SelectedText = "";
            this.noteTextBox.Size = new System.Drawing.Size(249, 35);
            this.noteTextBox.TabIndex = 10;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Montserrat", 9F);
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(90, 236);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(44, 15);
            this.gunaLabel1.TabIndex = 9;
            this.gunaLabel1.Text = "Note :";
            // 
            // moduleComboBox
            // 
            this.moduleComboBox.BackColor = System.Drawing.Color.Transparent;
            this.moduleComboBox.BaseColor = System.Drawing.Color.White;
            this.moduleComboBox.BorderColor = System.Drawing.Color.Silver;
            this.moduleComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.moduleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.moduleComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.moduleComboBox.Font = new System.Drawing.Font("Montserrat", 9F);
            this.moduleComboBox.ForeColor = System.Drawing.Color.Black;
            this.moduleComboBox.FormattingEnabled = true;
            this.moduleComboBox.Location = new System.Drawing.Point(239, 177);
            this.moduleComboBox.Name = "moduleComboBox";
            this.moduleComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.moduleComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.moduleComboBox.Radius = 5;
            this.moduleComboBox.Size = new System.Drawing.Size(249, 23);
            this.moduleComboBox.TabIndex = 8;
            this.moduleComboBox.SelectedIndexChanged += new System.EventHandler(this.moduleComboBox_SelectedIndexChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Montserrat", 9F);
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(90, 181);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(60, 15);
            this.gunaLabel2.TabIndex = 7;
            this.gunaLabel2.Text = "Module :";
            // 
            // modifierButton
            // 
            this.modifierButton.AnimationHoverSpeed = 0.07F;
            this.modifierButton.AnimationSpeed = 0.03F;
            this.modifierButton.BackColor = System.Drawing.Color.Transparent;
            this.modifierButton.BaseColor = System.Drawing.Color.White;
            this.modifierButton.BorderColor = System.Drawing.Color.Black;
            this.modifierButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.modifierButton.FocusedColor = System.Drawing.Color.Empty;
            this.modifierButton.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifierButton.ForeColor = System.Drawing.Color.Black;
            this.modifierButton.Image = null;
            this.modifierButton.ImageSize = new System.Drawing.Size(20, 20);
            this.modifierButton.Location = new System.Drawing.Point(565, 152);
            this.modifierButton.Name = "modifierButton";
            this.modifierButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.modifierButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.modifierButton.OnHoverForeColor = System.Drawing.Color.White;
            this.modifierButton.OnHoverImage = null;
            this.modifierButton.OnPressedColor = System.Drawing.Color.Black;
            this.modifierButton.Radius = 15;
            this.modifierButton.Size = new System.Drawing.Size(127, 35);
            this.modifierButton.TabIndex = 18;
            this.modifierButton.Text = "Modifier note";
            this.modifierButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.modifierButton.Click += new System.EventHandler(this.modifierButton_Click);
            // 
            // enregistrerNoteButton
            // 
            this.enregistrerNoteButton.AnimationHoverSpeed = 0.07F;
            this.enregistrerNoteButton.AnimationSpeed = 0.03F;
            this.enregistrerNoteButton.BackColor = System.Drawing.Color.Transparent;
            this.enregistrerNoteButton.BaseColor = System.Drawing.Color.White;
            this.enregistrerNoteButton.BorderColor = System.Drawing.Color.Black;
            this.enregistrerNoteButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.enregistrerNoteButton.FocusedColor = System.Drawing.Color.Empty;
            this.enregistrerNoteButton.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrerNoteButton.ForeColor = System.Drawing.Color.Black;
            this.enregistrerNoteButton.Image = null;
            this.enregistrerNoteButton.ImageSize = new System.Drawing.Size(20, 20);
            this.enregistrerNoteButton.Location = new System.Drawing.Point(565, 111);
            this.enregistrerNoteButton.Name = "enregistrerNoteButton";
            this.enregistrerNoteButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.enregistrerNoteButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.enregistrerNoteButton.OnHoverForeColor = System.Drawing.Color.White;
            this.enregistrerNoteButton.OnHoverImage = null;
            this.enregistrerNoteButton.OnPressedColor = System.Drawing.Color.Black;
            this.enregistrerNoteButton.Radius = 15;
            this.enregistrerNoteButton.Size = new System.Drawing.Size(127, 35);
            this.enregistrerNoteButton.TabIndex = 17;
            this.enregistrerNoteButton.Text = "Enregister note";
            this.enregistrerNoteButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.enregistrerNoteButton.Click += new System.EventHandler(this.enregistrerNoteButton_Click);
            // 
            // nouveauBtn
            // 
            this.nouveauBtn.AnimationHoverSpeed = 0.07F;
            this.nouveauBtn.AnimationSpeed = 0.03F;
            this.nouveauBtn.BackColor = System.Drawing.Color.Transparent;
            this.nouveauBtn.BaseColor = System.Drawing.Color.White;
            this.nouveauBtn.BorderColor = System.Drawing.Color.Black;
            this.nouveauBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.nouveauBtn.FocusedColor = System.Drawing.Color.Empty;
            this.nouveauBtn.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouveauBtn.ForeColor = System.Drawing.Color.Black;
            this.nouveauBtn.Image = null;
            this.nouveauBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.nouveauBtn.Location = new System.Drawing.Point(565, 70);
            this.nouveauBtn.Name = "nouveauBtn";
            this.nouveauBtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.nouveauBtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.nouveauBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.nouveauBtn.OnHoverImage = null;
            this.nouveauBtn.OnPressedColor = System.Drawing.Color.Black;
            this.nouveauBtn.Radius = 15;
            this.nouveauBtn.Size = new System.Drawing.Size(127, 35);
            this.nouveauBtn.TabIndex = 16;
            this.nouveauBtn.Text = "Nouveau";
            this.nouveauBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nouveauBtn.Click += new System.EventHandler(this.nouveauBtn_Click);
            // 
            // apercuButton
            // 
            this.apercuButton.AnimationHoverSpeed = 0.07F;
            this.apercuButton.AnimationSpeed = 0.03F;
            this.apercuButton.BackColor = System.Drawing.Color.Transparent;
            this.apercuButton.BaseColor = System.Drawing.Color.White;
            this.apercuButton.BorderColor = System.Drawing.Color.Black;
            this.apercuButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.apercuButton.FocusedColor = System.Drawing.Color.Empty;
            this.apercuButton.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apercuButton.ForeColor = System.Drawing.Color.Black;
            this.apercuButton.Image = null;
            this.apercuButton.ImageSize = new System.Drawing.Size(20, 20);
            this.apercuButton.Location = new System.Drawing.Point(565, 193);
            this.apercuButton.Name = "apercuButton";
            this.apercuButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.apercuButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.apercuButton.OnHoverForeColor = System.Drawing.Color.White;
            this.apercuButton.OnHoverImage = null;
            this.apercuButton.OnPressedColor = System.Drawing.Color.Black;
            this.apercuButton.Radius = 15;
            this.apercuButton.Size = new System.Drawing.Size(127, 35);
            this.apercuButton.TabIndex = 19;
            this.apercuButton.Text = "Aperçu";
            this.apercuButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.apercuButton.Click += new System.EventHandler(this.apercuButton_Click);
            // 
            // gunaVSeparator1
            // 
            this.gunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gunaVSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaVSeparator1.Location = new System.Drawing.Point(494, 42);
            this.gunaVSeparator1.Name = "gunaVSeparator1";
            this.gunaVSeparator1.Size = new System.Drawing.Size(10, 209);
            this.gunaVSeparator1.TabIndex = 20;
            // 
            // notesEtudiantDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.notesEtudiantDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.notesEtudiantDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.notesEtudiantDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.notesEtudiantDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notesEtudiantDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.notesEtudiantDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.notesEtudiantDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.notesEtudiantDataGridView.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.notesEtudiantDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.notesEtudiantDataGridView.EnableHeadersVisualStyles = false;
            this.notesEtudiantDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.notesEtudiantDataGridView.Location = new System.Drawing.Point(64, 291);
            this.notesEtudiantDataGridView.Name = "notesEtudiantDataGridView";
            this.notesEtudiantDataGridView.RowHeadersVisible = false;
            this.notesEtudiantDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.notesEtudiantDataGridView.Size = new System.Drawing.Size(668, 106);
            this.notesEtudiantDataGridView.TabIndex = 21;
            this.notesEtudiantDataGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.notesEtudiantDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.notesEtudiantDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.notesEtudiantDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.notesEtudiantDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.notesEtudiantDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.notesEtudiantDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.notesEtudiantDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.notesEtudiantDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.notesEtudiantDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.notesEtudiantDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.notesEtudiantDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.notesEtudiantDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.notesEtudiantDataGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.notesEtudiantDataGridView.ThemeStyle.ReadOnly = false;
            this.notesEtudiantDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.notesEtudiantDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.notesEtudiantDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.notesEtudiantDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.notesEtudiantDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.notesEtudiantDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.notesEtudiantDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // GestionNotesUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(19)))));
            this.Controls.Add(this.notesEtudiantDataGridView);
            this.Controls.Add(this.gunaVSeparator1);
            this.Controls.Add(this.apercuButton);
            this.Controls.Add(this.modifierButton);
            this.Controls.Add(this.enregistrerNoteButton);
            this.Controls.Add(this.nouveauBtn);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.moduleComboBox);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.nomEtudiantTextBox);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.numInscriptionComboBox);
            this.Controls.Add(this.numInscLabel);
            this.Name = "GestionNotesUC";
            this.Size = new System.Drawing.Size(800, 400);
            ((System.ComponentModel.ISupportInitialize)(this.notesEtudiantDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel numInscLabel;
        private Guna.UI.WinForms.GunaComboBox numInscriptionComboBox;
        private Guna.UI.WinForms.GunaLabel fullNameLabel;
        private Guna.UI.WinForms.GunaTextBox nomEtudiantTextBox;
        private Guna.UI.WinForms.GunaTextBox noteTextBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox moduleComboBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaButton modifierButton;
        private Guna.UI.WinForms.GunaButton enregistrerNoteButton;
        private Guna.UI.WinForms.GunaButton nouveauBtn;
        private Guna.UI.WinForms.GunaButton apercuButton;
        private Guna.UI.WinForms.GunaVSeparator gunaVSeparator1;
        private Guna.UI.WinForms.GunaDataGridView notesEtudiantDataGridView;
    }
}
