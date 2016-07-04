using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Datos;
using BusinessLogic;
using Microsoft.Reporting.WinForms;

namespace VentanaGz.Consultas
{
    public partial class ConsultaUsuario : Form
    {
        public ConsultaUsuario()
        {
            InitializeComponent();
        }

        private void ConsultaUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbVentanaGzDataSet.Usuario' table. You can move, or remove it, as needed.
           // this.usuarioTableAdapter.Fill(this.dbVentanaGzDataSet.Usuario);

           // this.reportViewer1.RefreshReport();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            consultaUsuariodataGridView.DataSource = usuarioLogic.GetListaReporte();
        }

        private void Imprimirbutton_Click(object sender, EventArgs e)
        {
            ReportarViewer vie = new ReportarViewer();// RpViewer por defecto viene private en el diseño hay que cambiarlo a publico

            vie.RpViewer.Reset();
            vie.RpViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            vie.RpViewer.LocalReport.ReportPath = @"C:\Users\juniorsantiago\Desktop\Aplicada I\proyect 1.0\VentanaGz\VentanaGz\Reporte\ListarUsuario.rdlc";

            vie.RpViewer.LocalReport.DataSources.Clear();

            vie.RpViewer.LocalReport.DataSources.Add(
                new ReportDataSource("Usuario",
                usuarioLogic.GetListaReporte() ));

            vie.RpViewer.LocalReport.Refresh();

            vie.Show();
        }
    }
}
