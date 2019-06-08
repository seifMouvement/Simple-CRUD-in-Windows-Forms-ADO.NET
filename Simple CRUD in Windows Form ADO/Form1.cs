using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Simple_CRUD_in_Windows_Form_ADO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Donnees d = new Donnees();
        manipulations m = new manipulations();
        private void Form1_Load(object sender, EventArgs e)
        {
            
           
            d.remplirGrid("CATEGORIE", dgvCATEGORIE);
          
          
        }

        private void btrModifier_Click(object sender, EventArgs e)
        {
            /*pour que lorsqu'on clique sur le bouton modifier du premier onglet
              il bascule automatiquemnt sur le deuxiéme onglet*/
            tbcCategorie.SelectedTab = tbgMiseAjour;

            /*il va remplir les champs du deuxiéme onglet avec la ligne séléctionné du premier
              onglet*/
            /*  txtNUMCAT.Text = dgvCATEGORIE.SelectedRows[0].Cells[0].Value.ToString();
              txtNOMCAT.Text = dgvCATEGORIE.SelectedRows[0].Cells[1].Value.ToString();*/
            // on peut utiliser les noms des champs tels qu'ils sont dans la BD

            txtNUMCAT.Text = dgvCATEGORIE.SelectedRows[0].Cells["NUMCAT"].Value.ToString();
            txtNOMCAT.Text = dgvCATEGORIE.SelectedRows[0].Cells["NOMCAT"].Value.ToString(); 
        }

        private void btrNouveau_Click(object sender, EventArgs e)
        {
            tbcCategorie.SelectedTab = tbgMiseAjour;
            m.ViderForme(panel1);
        }

        private void btnnouveau_Click(object sender, EventArgs e)
        {
            m.ViderForme(panel1);
        }

        private void btnajouter_Click(object sender, EventArgs e)
        {
            /* insérer dans la BD*/
            d.connecter();
            d.cmd.Connection = d.con;
            /*on ba gérer les doublons, il va lancer une requet SELECT qui compte le nombre de ligne
             ayant le numéro de categorie est egale à la valeur saisie dans le champ numéro.
             si le nombre obtenur par la requet SQL est superieur à 0 il ne vas pas faire l'insertion
             car il existe deja un enregistrement avec dans la BD avec ce numéro de categorie*/
            d.cmd.CommandText = "SELECT COUNT (*) FROM CATEGORIE WHERE NUMCAT="+ int.Parse(txtNUMCAT.Text);
            int cpt= int.Parse(d.cmd.ExecuteScalar().ToString());
            if(cpt>0)
            {
                MessageBox.Show("Le numéro de catégorie"+txtNUMCAT.Text+"existe déjà");
            }
            else
            { 
                d.cmd.CommandText="INSERT INTO CATEGORIE (NUMCAT,NOMCAT) VALUES ("+int.Parse(txtNUMCAT.Text)+
                    ",'"+txtNOMCAT.Text+"')";
                d.cmd.ExecuteNonQuery();
                d.deconnecter();
                MessageBox.Show("Ajout éffectué avec succes");

            }
        }
    }
}
