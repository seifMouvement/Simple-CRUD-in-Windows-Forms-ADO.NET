using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
