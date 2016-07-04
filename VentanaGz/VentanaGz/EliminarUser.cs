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
    public partial class EliminarUser : Form
    {
        public EliminarUser()
        {
            InitializeComponent();
        }

        private void EliminarUserbutton_Click(object sender, EventArgs e)
        {
            usuarioLogic menu = new usuarioLogic();
            string eliminar = EliminarUsertextBox.Text;
            menu.eliminarUsuario(eliminar);
            MessageBox.Show("El usuario se a Eliminado");
            EliminarUsertextBox.Text = "";
        }
    }
}
