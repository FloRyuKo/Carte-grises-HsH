using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Concessionnaires
{
    // Classe IHM
    public partial class Form1 : Form
    {
        // Types de recherche : par nom ou par ville
        public enum CategorieRecherche { NOM, VILLE };

        // Constructeur
        public Form1()
        {
            InitializeComponent();
        }

        // Lors du démarrage
        private void Form1_Load(object sender, EventArgs e)
        {
            // Par défaut la combo affiche "Ville"
            cboCriteresChamp.Items.Add("Nom");
            cboCriteresChamp.Items.Add("Ville");
            cboCriteresChamp.SelectedIndex = 1;
        }

        // Clic sur ENVOYER
        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
           
        }
    }

    // Classe METIER
    public class Concessionnaire
    {
        // Attributs et Propriétés correspondantes
        private string id;
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        private string nom;
        public string Nom
        {
            get { return this.nom; }
        }

        private string prenom;
        public string Prenom
        {
            get { return this.prenom; }
        }

        private string adresse;
        public string Adresse
        {
            get { return this.adresse; }
        }

        private string cp;
        public string CodePostal
        {
            get { return this.cp; }
        }

        private string ville;
        public string Ville
        {
            get { return this.ville; }
        }

        //--------------------
        // Constructeur
        //--------------------
        public Concessionnaire(string id, string nom, string prenom, string adresse, string cp, string ville)
        {
            this.id = id; this.nom = nom; this.prenom = prenom; this.adresse = adresse; this.cp = cp; this.ville = ville;
        }
    }
}
