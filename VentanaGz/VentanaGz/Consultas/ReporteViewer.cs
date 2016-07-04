using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentanaGz.Consultas
{
    public partial class ReportarViewer : Form
    {
        public ReportarViewer()
        {
            InitializeComponent();
        }

        private void ReporteViewer_Load(object sender, EventArgs e)
        {

            this.RpViewer.RefreshReport();
        }
    }
}
