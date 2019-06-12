using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_CRUD_in_Windows_Form_ADO
{
    class Donnees
        {
           public  SqlConnection con = new SqlConnection();
            public SqlCommand cmd = new SqlCommand();
            /*data table est systéme de fichier XML et la BD est un systéme de donnée relationnel.
                pour transformer un flux SQL en data table on doit utiliser un adaptateur
                DataAdapter*/

            public SqlDataAdapter da = new SqlDataAdapter();
            /*on va utiliser le mode déconnecter daonc on doit utiliser l'objet Dataset,
             la dataset est indpendante de la source de donnée c'est pour cela qu'elle ne 
             commence pas par SQL*/
            public DataSet ds = new DataSet();

            public void connecter ()
            {
                 /*on doit tester si la connexion est fermée car s'elle est ouverte et on va 
                   essayer de l'ouvrir encore cela va nous générer une exception*/
                if(con.State==ConnectionState.Closed)
                {  
                    /*la base de donnée est configuré sur Microsoft SQL serveur
                     BDD est le nom de la BD
                     T4300 est le nom de serveur
                     integrated security=true parceque on est connecté avec le compte windows*/
                    con.ConnectionString = "initial catalog=BDD;data source=T4300; integrated security=true";
                    con.Open();
                }
            }


        public void deconnecter()
        {/*si la connexion est ouverte on la ferme */
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        /*optimisation du code pour qu'il fonctionne avec n'importe quel table et 
         n'importe quelle gridview*/
        public void remplirGrid(string table , DataGridView dg)
        {
            connecter(); 
            cmd.Connection = con;
            cmd.CommandText = "SELECT * FROM "+table;
            /*mettre le flux dans un datatable( datatable trouve dans une dataset) et dire à
             * notre datagridview ton datasource ca sera la datatable
             */
            da.SelectCommand = cmd;
            /*on va tester si la datatable existe on la nettoie si non on la creer
             pour éviter d'avoir des doublons au moment de la modification */
             if(ds.Tables["DTCATEGORIE"]!=null)
            { 
            ds.Tables["DTCATEGORIE"].Clear();
            }
            /*on imagine une BD à l'intérieure il y a une dataset et à l'intérieure il y 
             * un data table*/
            da.Fill(ds, "DT"+table);
            /* la datatable DTCATEGORIE va remplir la datagridview */
            dg.DataSource = ds.Tables["DTCATEGORIE"];
            deconnecter();
        }
        /*une methode qui rentre le nombre d'existance d'un enregistrement dans la BD,
         on va l'utiliser dans l'ajout, supression et modification*/
        public int nbrelignes(string champ, string table, int valeur)
        {
            
            connecter();
            cmd.Connection = con;
            /*on va gérer les doublons, il va lancer une requet SELECT qui compte le nombre de ligne
             ayant le numéro de categorie est egale à la valeur saisie dans le champ numéro.
             si le nombre obtenur par la requet SQL est superieur à 0 il ne vas pas faire l'insertion
             car il existe deja un enregistrement avec dans la BD avec ce numéro de categorie*/
            
            cmd.CommandText = "SELECT COUNT (*) FROM " + table + " WHERE " + champ + " = " + valeur;
            int cpt = int.Parse(cmd.ExecuteScalar().ToString());
            return cpt;
            
        }
    }
}
