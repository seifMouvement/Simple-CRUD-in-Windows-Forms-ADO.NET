using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_CRUD_in_Windows_Form_ADO
{
    class manipulations
    {
        /*une méthode pour vider tous les champs dans un panel */ 
        public void ViderForme(Panel p)
        {/*on va faire le tour dans le panel et à chaque fois on va tomber sur un textbox on 
            va le vider */
            foreach(Control ctl in p.Controls)
            {
                if(ctl.GetType()==typeof(TextBox))
                {
                    ctl.Text = "";
                }
            }
        }
    }
}
