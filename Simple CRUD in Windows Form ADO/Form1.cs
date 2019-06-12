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
            /* pour remplir la datagridview*/
           
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
        //insérer dans la BD
        private void btnajouter_Click(object sender, EventArgs e)
        {
           if(d.nbrelignes("NUMCAT","CATEGORIE",int.Parse(txtNUMCAT.Text))>0)
            {
                MessageBox.Show("le numero de catégorie" + txtNUMCAT.Text + "existe déjà");
            }
           else
            { 
                d.cmd.CommandText="INSERT INTO CATEGORIE (NUMCAT,NOMCAT) VALUES ("+int.Parse(txtNUMCAT.Text)+
                    ",'"+txtNOMCAT.Text+"')";
                d.cmd.ExecuteNonQuery();
                d.deconnecter();
                MessageBox.Show("Ajout éffectué avec succes");
            }
           // pour mettre à jour la gridview
            d.remplirGrid("CATEGORIE", dgvCATEGORIE);

        }

        private void btnmodifier_Click(object sender, EventArgs e)
        {
            /* dans la if on va prendre le numcat déjà séléctionné dans la datagridview*/
            if (d.nbrelignes("NUMCAT", "CATEGORIE", int.Parse(dgvCATEGORIE.SelectedRows[0].Cells["NUMCAT"].Value.ToString())) > 0)
            {
                d.cmd.CommandText = "UPDATE CATEGORIE SET NUMCAT= " + int.Parse(txtNUMCAT.Text) + " ,NOMCAT='"
                    + txtNOMCAT.Text + "'WHERE NUMCAT="+ int.Parse(dgvCATEGORIE.SelectedRows[0].Cells["NUMCAT"].Value.ToString());
                    
                d.cmd.ExecuteNonQuery();
                d.deconnecter();
                MessageBox.Show("Modification éffectué avec succes");
            }
            // pour mettre à jour la gridview
            d.remplirGrid("CATEGORIE", dgvCATEGORIE);
        }
    }
}
