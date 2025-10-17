using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Windows.Forms.DataVisualization.Charting;


namespace pryTulianSP4Graficos
{
    internal class ConexionClase
    {

        OleDbConnection miconexion;
        public string mensaje = "";

        
        public void ConectarBaseAcces(System.Windows.Forms.ToolStripLabel lblmensaje )
        {
            try
            {

                miconexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\BaseDatos\\controltransporte.accdb");
                miconexion.Open();

                lblmensaje.Text = "Conexiòn acces exitosa";
                lblmensaje.BackColor = System.Drawing.Color.LightGreen;
            }

            catch (Exception error)
            {
                lblmensaje.Text =error.Message;
                lblmensaje.BackColor = System.Drawing.Color.DarkRed;
            }
        }
        public void CargarGrafico(Chart chart)
        {
            string consulta = "SELECT Camion, SUM(Kilometraje) AS TotalKm FROM Viajes GROUP BY Camion";
            OleDbCommand comando = new OleDbCommand(consulta, miconexion);
            miconexion.Open();
            OleDbDataReader lector = comando.ExecuteReader();
            chartEstadisticas.Series.Clear();

            while (lector.Read())
            {
                string camion = lector["Camion"].ToString();
                double km = Convert.ToDouble(lector["TotalKm"]);

                Series serie = new Series(camion);
                serie.Points.AddXY(camion, km);
                serie.ChartType = SeriesChartType.Column;
                serie.IsValueShownAsLabel = true;

                chartEstadisticas.Series.Add(serie);
            }

            miconexion.Close();


        }


    }
   
}
