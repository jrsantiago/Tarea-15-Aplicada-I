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
    public class usuarioLogic
    {
      public  string nombre;
      public  string apellido;
      public  string userName;
      public   string sexo;
      public  string contrasena;

        public usuarioLogic()
        {
            sexo = "";
            nombre = "";
            apellido = "";
            userName = "";
            contrasena = "";
        }
        DbVentanaGzEntities dbVentana = new DbVentanaGzEntities();
        public void crearUsuario(string Cnombre,string Capellido,string Csexo,string CuserName,string Ccontrasena,string reperContrasena)
        {

            if (Csexo=="M" )
            {
                Csexo = "M";
            }
            else if (Csexo=="F")
            {
                Csexo = "F";
            }

            Usuario cUsuario = new Usuario()
            {
                nombre = Cnombre,
                apellido = Capellido,
                sexo = Csexo,
                userName = CuserName,
                contrasena = Ccontrasena

            };
           
            if(reperContrasena!=Ccontrasena)
            {
                MessageBox.Show("Las contraseñas no coinciden..");
            }
            else
            {
                try
                {
                    dbVentana.Usuario.Add(cUsuario);
                    dbVentana.SaveChanges();
                    MessageBox.Show("Guardado Exitoso");

                }  catch (Exception) { }//Acordar....SaveChanges
            }
        }
        public void eliminarUsuario(string contrasena)
        {
            try
            {
                Usuario user = (from u in dbVentana.Usuario
                                where u.contrasena == contrasena
                                select u).FirstOrDefault();
                dbVentana.Usuario.Remove(user);
                dbVentana.SaveChanges();
            }
            catch (Exception) { MessageBox.Show("La contrasena es Incorrecta."); }
        }
       
        public void listarDatosActualizar(string contra)
        {
            using (DbVentanaGzEntities dbven = new DbVentanaGzEntities())
            {
                 sexo = dbven.Usuario.FirstOrDefault(x => x.contrasena == contra).sexo.ToString();
                 nombre = dbven.Usuario.FirstOrDefault(x => x.contrasena == contra).nombre.ToString();
                 apellido = dbven.Usuario.FirstOrDefault(x => x.contrasena == contra).apellido.ToString();
                 userName = dbven.Usuario.FirstOrDefault(x => x.contrasena == contra).userName.ToString();
                 contrasena = dbven.Usuario.FirstOrDefault(x => x.contrasena == contra).contrasena.ToString();
                
            }

        }

        public static List<Usuario> GetListaReporte()
        {
            List<Usuario> lista = new List<Usuario>();
            var db = new DbVentanaGzEntities();

            lista = db.Usuario.ToList();
            return lista;
        }

        
    }
}
