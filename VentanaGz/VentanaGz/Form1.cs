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
using Entidades;

namespace VentanaGz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
           UserLoging usuario = new UserLoging();

        private void Logingbutton_Click(object sender, EventArgs e)
        {
           

            string nombre = nombreLogingTexBox.Text;
            string contrasena = contrasenaLogingtextBox.Text;

           try
          {
              usuario.Loging(nombre, contrasena);
          }
          catch (NullReferenceException) { MessageBox.Show("La contraseña o Nombre de Usuario Son Incorrectos.!!!"); }

          if(nombre == usuario.nombre && contrasena==usuario.contra && nombre!="" && contrasena !="")
           {
                MenuGz menu = new MenuGz();
                this.Visible = false;
                menu.Show();
            }
        

        }
    }
}
