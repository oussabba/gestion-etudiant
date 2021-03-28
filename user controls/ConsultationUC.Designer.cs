namespace MiniProjetDotNet.user_controls
{
    partial class ConsultationUC
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
            this.moduleComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.moduleLabel = new Guna.UI.WinForms.GunaLabel();
            this.listeEtudiantDataGridView = new Guna.UI.WinForms.GunaDataGridView();
            this.moyenneLabel = new Guna.UI.WinForms.GunaLabel();
            this.moyenneClasseTextBox = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.listeEtudiantDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // moduleComboBox
            // 
            this.moduleComboBox.BackColor = System.Drawing.Color.Transparent;
            this.moduleComboBox.BaseColor = System.Drawing.Color.White;
            this.moduleComboBox.BorderColor = System.Drawing.Color.Silver;
            this.moduleComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.moduleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.moduleComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.moduleComboBox.Font = new System.Drawing.Font("Montserrat", 10F);
            this.moduleComboBox.ForeColor = System.Drawing.Color.Black;
            this.moduleComboBox.FormattingEnabled = true;
            this.moduleComboBox.Location = new System.Drawing.Point(300, 36);
            this.moduleComboBox.Name = "moduleComboBox";
            this.moduleComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.moduleComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.moduleComboBox.Radius = 5;
            this.moduleComboBox.Size = new System.Drawing.Size(314, 25);
            this.moduleComboBox.TabIndex = 10;
            this.moduleComboBox.SelectedIndexChanged += new System.EventHandler(this.moduleComboBox_SelectedIndexChanged);
            // 
            // moduleLabel
            // 
            this.moduleLabel.AutoSize = true;
            this.moduleLabel.Font = new System.Drawing.Font("Montserrat", 9F);
            this.moduleLabel.ForeColor = System.Drawing.Color.White;
            this.moduleLabel.Location = new System.Drawing.Point(195, 42);
            this.moduleLabel.Name = "moduleLabel";
            this.moduleLabel.Size = new System.Drawing.Size(60, 15);
            this.moduleLabel.TabIndex = 9;
            this.moduleLabel.Text = "Module :";
            // 
            // listeEtudiantDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.listeEtudiantDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.listeEtudiantDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listeEtudiantDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.listeEtudiantDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listeEtudiantDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listeEtudiantDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listeEtudiantDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.listeEtudiantDataGridView.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listeEtudiantDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.listeEtudiantDataGridView.EnableHeadersVisualStyles = false;
            this.listeEtudiantDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listeEtudiantDataGridView.Location = new System.Drawing.Point(58, 104);
            this.listeEtudiantDataGridView.Name = "listeEtudiantDataGridView";
            this.listeEtudiantDataGridView.RowHeadersVisible = false;
            this.listeEtudiantDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listeEtudiantDataGridView.Size = new System.Drawing.Size(678, 217);
            this.listeEtudiantDataGridView.TabIndex = 11;
            this.listeEtudiantDataGridView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.listeEtudiantDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.listeEtudiantDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.listeEtudiantDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.listeEtudiantDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.listeEtudiantDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.listeEtudiantDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.listeEtudiantDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listeEtudiantDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.listeEtudiantDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.listeEtudiantDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.listeEtudiantDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.listeEtudiantDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.listeEtudiantDataGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.listeEtudiantDataGridView.ThemeStyle.ReadOnly = false;
            this.listeEtudiantDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.listeEtudiantDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.listeEtudiantDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.listeEtudiantDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.listeEtudiantDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.listeEtudiantDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.listeEtudiantDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // moyenneLabel
            // 
            this.moyenneLabel.AutoSize = true;
            this.moyenneLabel.Font = new System.Drawing.Font("Montserrat", 9F);
            this.moyenneLabel.ForeColor = System.Drawing.Color.White;
            this.moyenneLabel.Location = new System.Drawing.Point(494, 352);
            this.moyenneLabel.Name = "moyenneLabel";
            this.moyenneLabel.Size = new System.Drawing.Size(128, 15);
            this.moyenneLabel.TabIndex = 12;
            this.moyenneLabel.Text = "Moyenne de classe :";
            // 
            // moyenneClasseTextBox
            // 
            this.moyenneClasseTextBox.BackColor = System.Drawing.Color.Transparent;
            this.moyenneClasseTextBox.BaseColor = System.Drawing.Color.White;
            this.moyenneClasseTextBox.BorderColor = System.Drawing.Color.Silver;
            this.moyenneClasseTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.moyenneClasseTextBox.FocusedBaseColor = System.Drawing.Color.White;
            this.moyenneClasseTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.moyenneClasseTextBox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.moyenneClasseTextBox.Font = new System.Drawing.Font("Montserrat", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moyenneClasseTextBox.Location = new System.Drawing.Point(628, 343);
            this.moyenneClasseTextBox.Name = "moyenneClasseTextBox";
            this.moyenneClasseTextBox.PasswordChar = '\0';
            this.moyenneClasseTextBox.Radius = 15;
            this.moyenneClasseTextBox.SelectedText = "";
            this.moyenneClasseTextBox.Size = new System.Drawing.Size(108, 35);
            this.moyenneClasseTextBox.TabIndex = 13;
            // 
            // ConsultationUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(17)))), ((int)(((byte)(19)))));
            this.Controls.Add(this.moyenneClasseTextBox);
            this.Controls.Add(this.moyenneLabel);
            this.Controls.Add(this.listeEtudiantDataGridView);
            this.Controls.Add(this.moduleComboBox);
            this.Controls.Add(this.moduleLabel);
            this.Name = "ConsultationUC";
            this.Size = new System.Drawing.Size(800, 400);
            ((System.ComponentModel.ISupportInitialize)(this.listeEtudiantDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaComboBox moduleComboBox;
        private Guna.UI.WinForms.GunaLabel moduleLabel;
        private Guna.UI.WinForms.GunaDataGridView listeEtudiantDataGridView;
        private Guna.UI.WinForms.GunaLabel moyenneLabel;
        private Guna.UI.WinForms.GunaTextBox moyenneClasseTextBox;
    }
}
