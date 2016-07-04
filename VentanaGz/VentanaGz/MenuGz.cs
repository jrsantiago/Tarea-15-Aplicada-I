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
using VentanaGz;

namespace VentanaGz
{
    public partial class MenuGz : Form
    {
        public MenuGz()
        {
            InitializeComponent();
        }

        private void newUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newUsuario newUsua = new newUsuario();
            newUsua.Show();
        
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarUser eliUsua = new EliminarUser();
            eliUsua.Show();
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            actualizarUsuario actUsua = new actualizarUsuario();
            actUsua.Show();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaUsuario consulta = new Consultas.ConsultaUsuario();
            consulta.Show();
        }
    }
}
