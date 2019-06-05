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
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            /*la base de donnée est configuré sur Microsoft SQL serveur
             BDD est le nom de la BD
             T4300 est le nom de serveur
             integrated security=true parceque on est connecté avec le compte windows*/
            con.ConnectionString = "initial catalog=BDD;data source=T4300; integrated security=true";
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM CATEGORIE";
            /*mettre le flux dans un datatable( datatable trouve dans une dataset) et dire à
             * notre datagridview ton datasource ca sera la datatable
             */

            /*data table est systéme de fichier XML et la BD est un systéme de donnée relationnel.
             pour transformer un flux SQL en data table on doit utiliser un adaptateur
             DataAdapter*/

            SqlDataAdapter da = new SqlDataAdapter();
            /*on va utiliser le mode déconnecter dans on doit utiliser l'objet Dataset,
             la dataset est indpendante de la source de donnée c'est pour cela qu'elle ne 
             commence pas par SQL*/
            DataSet ds = new DataSet();

            da.SelectCommand = cmd;
            /*on imaginer une BD à l'intérieure il y a une dataset et à l'intérieure il y 
             * un data table*/
            da.Fill(ds, "DTCATEGORIE");
            /* la datatable DTCATEGORIE va remplir la datagridview */
            dgvCATEGORIE.DataSource = ds.Tables["DTCATEGORIE"];
        }
    }
}
