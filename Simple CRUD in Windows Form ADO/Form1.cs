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

        private void Form1_Load(object sender, EventArgs e)
        {
            Donnees d = new Donnees();
           
            d.remplirGrid("CATEGORIE", dgvCATEGORIE);
          
          
        }

        private void btrModifier_Click(object sender, EventArgs e)
        {
            /*pour que lorsqu'on clique sur le bouton modifier du premier onglet
              il bascule automatiquemnt sur le deuxiéme onglet*/
            tbcCategorie.SelectedTab = tbgMiseAjour;

            /*il va remplir les champs du deuxiéme onglet avec la ligne séléctionné du premier
              onglet*/
            txtNUMCAT.Text = dgvCATEGORIE.SelectedRows[0].Cells[0].Value.ToString();
            txtNOMCAT.Text = dgvCATEGORIE.SelectedRows[0].Cells[1].Value.ToString();

        }
    }
}
