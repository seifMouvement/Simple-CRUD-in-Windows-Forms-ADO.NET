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
            d.connecter();
          
           d.cmd.Connection = d.con;
            d.cmd.CommandText = "SELECT * FROM CATEGORIE";
            /*mettre le flux dans un datatable( datatable trouve dans une dataset) et dire à
             * notre datagridview ton datasource ca sera la datatable
             */
            d.da.SelectCommand = d.cmd;
            /*on imagine une BD à l'intérieure il y a une dataset et à l'intérieure il y 
             * un data table*/
            d.da.Fill(d.ds, "DTCATEGORIE");
            /* la datatable DTCATEGORIE va remplir la datagridview */
            dgvCATEGORIE.DataSource = d.ds.Tables["DTCATEGORIE"];
            d.deconnecter();
        }
    }
}
