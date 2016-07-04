using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;

namespace VentanaGz
{
    public partial class newUsuario : Form
    {
        public newUsuario()
        {
            InitializeComponent();
        }
        usuarioLogic menu = new usuarioLogic();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NewUsuariobutton_Click(object sender, EventArgs e)
        {
            string nombre = nombreNewUsuariotextBox.Text;
            string apellido = apellidoNuevoUsuatextBox.Text;
            string sexo = "";
            if(mascucheckBox.Checked)
            {
                sexo = "M";
            }
            else if(femeninocheckBox.Checked)
            {
                sexo = "F";
            }
            string userName = UserNameNuevoUsuariotextBox.Text;
            string contrasena = contrasenaNuevaUsuariotextBox.Text;
            string repetirContr = RepetirContrasetextBox.Text;

            usuarioLogic log = new usuarioLogic();
            log.crearUsuario(nombre,apellido,sexo,userName,contrasena,repetirContr);
            

            menu.crearUsuario(nombre,apellido,sexo,userName,contrasena,repetirContr);
           nombreNewUsuariotextBox.Text="";
            apellidoNuevoUsuatextBox.Text = "";
            RepetirContrasetextBox.Text = "";
            contrasenaNuevaUsuariotextBox.Text = "";
            UserNameNuevoUsuariotextBox.Text = "";
            mascucheckBox.Checked=false;
            femeninocheckBox.Checked=false;
            
        }

        private void newUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
