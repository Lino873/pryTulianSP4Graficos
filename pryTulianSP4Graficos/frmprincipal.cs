using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.OleDb;

namespace pryTulianSP4Graficos
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {
            ConexionClase conexion = new ConexionClase();
            conexion.ConectarBaseAcces(lblestadoonexion);
            GraficoKilometraje grafico = new GraficoKilometraje();
            grafico.CargarGrafico(chartEstadisticas);

        }


    }
}
