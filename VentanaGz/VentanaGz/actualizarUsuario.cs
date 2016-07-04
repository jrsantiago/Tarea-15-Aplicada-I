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
using Datos;

namespace VentanaGz
{
    public partial class actualizarUsuario : Form
    {
        string contra;
        public actualizarUsuario()
        {
            InitializeComponent();
        }
        DbVentanaGzEntities dbVentana = new DbVentanaGzEntities();
        usuarioLogic log = new usuarioLogic();
        private void BuscarContraseñabutton_Click(object sender, EventArgs e)
        {

            
            contra= BuscarContratextBox.Text;
            log.listarDatosActualizar(contra);

            if(log.sexo=="M")
            {
                MasculinoActualizarcheckBoxcheckBox.Checked = true;
            }
            else if(log.sexo=="F")
            {
                FemeninoActualizarcheckBox.Checked = true;
            }
            nombreActualizartextBox.Text=log.nombre;
            apellidoActualizartextBox.Text = log.apellido;
            userNameActualizartextBox.Text = log.userName;
            contrasenaActualizartextBox.Text = log.contrasena;

            BuscarContratextBox.Text = "";

        }

        private void Actualizarbutton_Click(object sender, EventArgs e)
        {
            Usuario usuario = (from u in dbVentana.Usuario
                               where u.contrasena == contra
                               select u).FirstOrDefault();
            try
            {
                usuario.nombre = nombreActualizartextBox.Text;
                usuario.apellido = apellidoActualizartextBox.Text;
                usuario.userName = userNameActualizartextBox.Text;
                //usuario.contrasena = contrasenaActualizartextBox.Text;
                if(MasculinoActualizarcheckBoxcheckBox.Checked)
                {
                    usuario.sexo = "M";
                }else
                    if(FemeninoActualizarcheckBox.Checked)
                {
                    usuario.sexo = "F";
                }
                string otraContra = repetirContrasenActualizartextBox.Text;
            }
            catch (NullReferenceException) { MessageBox.Show("Uno de los Campo esta Vacio.!!"); }

            if(contrasenaActualizartextBox.Text!=repetirContrasenActualizartextBox.Text)
            {
                contrasenaActualizartextBox.Text = "";
                repetirContrasenActualizartextBox.Text = "";
                MessageBox.Show("Contrasenas no Coinciden..");
            }
            if (nombreActualizartextBox.Text != "" && apellidoActualizartextBox.Text != "" && userNameActualizartextBox.Text != "" && contrasenaActualizartextBox.Text != "")
                dbVentana.SaveChanges();
            MessageBox.Show("Los datos se an Actualizado");

            nombreActualizartextBox.Text = "";
            apellidoActualizartextBox.Text = "";
            userNameActualizartextBox.Text = "";
           // contrasenaActualizartextBox.Text = "";
            MasculinoActualizarcheckBoxcheckBox.Checked = false;
            FemeninoActualizarcheckBox.Checked = false;
            
        }
    }
}
