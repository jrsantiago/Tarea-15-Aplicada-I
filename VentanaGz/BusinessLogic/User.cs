using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;
using System.Windows.Forms;



namespace BusinessLogic
{
    public class UserLoging 

    {     
       public string usname;
       public string password;

       public  string nombre;
       public  string contra;
    
        public UserLoging()
        {

            usname = "";
            password ="";
           this.nombre = "";
           this.contra = "";
        }
        
        public void Loging (string no,string con)
        {
         
          
                using (DbVentanaGzEntities dbUsuario = new DbVentanaGzEntities())
                {
                   nombre = dbUsuario.Usuario.FirstOrDefault(x => x.userName == no).userName.ToString();
                   contra = dbUsuario.Usuario.FirstOrDefault(x => x.contrasena == con).contrasena.ToString();
                }
         
        }
    }
}