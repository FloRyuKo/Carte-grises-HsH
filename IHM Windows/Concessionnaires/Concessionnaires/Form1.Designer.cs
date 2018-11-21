namespace Concessionnaires
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.txtCriteresSaisie = new System.Windows.Forms.TextBox();
            this.cboCriteresChamp = new System.Windows.Forms.ComboBox();
            this.lvListeConcessionnaires = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.Location = new System.Drawing.Point(642, 17);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(75, 23);
            this.btnEnvoyer.TabIndex = 22;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = true;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click);
            // 
            // txtCriteresSaisie
            // 
            this.txtCriteresSaisie.Location = new System.Drawing.Point(340, 17);
            this.txtCriteresSaisie.Name = "txtCriteresSaisie";
            this.txtCriteresSaisie.Size = new System.Drawing.Size(285, 20);
            this.txtCriteresSaisie.TabIndex = 21;
            // 
            // cboCriteresChamp
            // 
            this.cboCriteresChamp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriteresChamp.FormattingEnabled = true;
            this.cboCriteresChamp.Location = new System.Drawing.Point(149, 16);
            this.cboCriteresChamp.Name = "cboCriteresChamp";
            this.cboCriteresChamp.Size = new System.Drawing.Size(142, 21);
            this.cboCriteresChamp.TabIndex = 20;
            // 
            // lvListeConcessionnaires
            // 
            this.lvListeConcessionnaires.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvListeConcessionnaires.FullRowSelect = true;
            this.lvListeConcessionnaires.GridLines = true;
            this.lvListeConcessionnaires.Location = new System.Drawing.Point(12, 56);
            this.lvListeConcessionnaires.MultiSelect = false;
            this.lvListeConcessionnaires.Name = "lvListeConcessionnaires";
            this.lvListeConcessionnaires.Size = new System.Drawing.Size(709, 435);
            this.lvListeConcessionnaires.TabIndex = 19;
            this.lvListeConcessionnaires.UseCompatibleStateImageBehavior = false;
            this.lvListeConcessionnaires.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 43;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nom";
            this.columnHeader2.Width = 118;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Prénom";
            this.columnHeader3.Width = 118;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Adresse";
            this.columnHeader4.Width = 199;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Code postal";
            this.columnHeader5.Width = 71;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ville";
            this.columnHeader6.Width = 148;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Critères de sélection :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 505);
            this.Controls.Add(this.btnEnvoyer);
            this.Controls.Add(this.txtCriteresSaisie);
            this.Controls.Add(this.cboCriteresChamp);
            this.Controls.Add(this.lvListeConcessionnaires);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Liste de concessionnaires";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.TextBox txtCriteresSaisie;
        private System.Windows.Forms.ComboBox cboCriteresChamp;
        private System.Windows.Forms.ListView lvListeConcessionnaires;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label6;
    }
}

