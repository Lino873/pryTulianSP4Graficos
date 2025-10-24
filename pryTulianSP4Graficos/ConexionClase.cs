using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;


namespace pryTulianSP4Graficos
{
    internal class ConexionClase
    {

        OleDbConnection miconexion;
        OleDbCommand comando;


        public void ConectarBaseAcces(ToolStripLabel lblmensaje )
        {
            try
            {

                miconexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\BaseDatos\\control_transporte.accdb");
                

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
            Series ser = new Series("KM recorridos por cada camión");
            ser.ChartType = SeriesChartType.Column;



            try
            {
                miconexion.Open();

                
                string consulta = "SELECT Camión, Kilómetros FROM transporte";
                comando = new OleDbCommand(consulta, miconexion);

                OleDbDataReader reader = comando.ExecuteReader();
                Color[] colores =
                    {
                Color.Red, Color.Orange, Color.Green, Color.Blue,
                Color.Purple, Color.Cyan, Color.Magenta, Color.Gold,
                Color.Brown, Color.DarkSlateGray
               };
                int i = 0;
                while (reader.Read())
                {
                    
                    string camion = reader["Camión"].ToString();
                    decimal km = Convert.ToDecimal(reader["Kilómetros"]);

                    int puntoIndex = ser.Points.AddXY(camion, km);


                    ser.Points[puntoIndex].Color = colores[i % colores.Length];
                    i++;
                }

                chart.Series.Add(ser);

                
                chart.ChartAreas[0].AxisX.Interval = 1;
                chart.ChartAreas[0].AxisX.Title = "Camiones";
                chart.ChartAreas[0].AxisY.Title = "Kilómetros recorridos";
                chart.ChartAreas[0].AxisY.Minimum = 0;
                chart.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
                chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }



        }


    }
   
}
