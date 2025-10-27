using System;

using System.Collections.Generic;

using System.Data;

using System.Data.OleDb;

using System.IO;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows.Forms;

using System.Windows.Forms.DataVisualization.Charting;



namespace pryCordobaSP4

{

    internal class clsConexionBD

    {
        private string cadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USUARIO\source\repos\pryCordobaSP4\pryCordobaSP4\Base de Datos/ControlCamiones.accdb";

        OleDbConnection conexion;
        OleDbCommand comando;
        OleDbDataReader lector;

        private void CargarChart(Chart chart, string consulta, string ejeY, int maxY, int intervalo, ProgressBar pb)
        {
            try
            {
                chart.Series.Clear();
                Series serie = new Series("Camiones");
                serie.ChartType = SeriesChartType.Column;
                serie.Color = System.Drawing.Color.Teal;
                serie.IsValueShownAsLabel = true;
                chart.Series.Add(serie);

                chart.ChartAreas[0].AxisX.Title = "Camiones";
                chart.ChartAreas[0].AxisY.Title = ejeY;
                chart.ChartAreas[0].AxisY.Maximum = maxY;
                chart.ChartAreas[0].AxisY.Interval = intervalo;

                conexion = new OleDbConnection(cadenaConexion);
                conexion.Open();

                comando = new OleDbCommand(consulta, conexion);
                lector = comando.ExecuteReader();

                int total = 0;
                while (lector.Read()) total++;
                lector.Close();

                comando = new OleDbCommand(consulta, conexion);
                lector = comando.ExecuteReader();

                int contador = 0;
                pb.Visible = true;
                pb.Value = 0;

                while (lector.Read())
                {
                    string camion = lector["Camión"].ToString();
                    double valor = Convert.ToDouble(lector["Total"]);

                    int index = chart.Series[0].Points.AddY(valor);
                    chart.Series[0].Points[index].AxisLabel = camion;

                    contador++;
                    pb.Value = (contador * 100) / total;
                    Application.DoEvents();
                }

                lector.Close();
                conexion.Close();
                pb.Value = 100;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
                pb.Value = 0;
            }
        }

        public void CargarKilometros(Chart chart, ProgressBar pb)
        {
            string consulta = "SELECT Camión, Kilómetros AS Total FROM Camiones";
            CargarChart(chart, consulta, "Kilómetros", 6000, 500, pb);
        }

        public void CargarGastos(Chart chart, ProgressBar pb)
        {
            string consulta = "SELECT Camión, (Litros * Precio) AS Total FROM Camiones";
            CargarChart(chart, consulta, "Gasto en Combustible ($)", 500000, 50000, pb);
        }

        public void CargarKilogramos(Chart chart, ProgressBar pb)
        {
            string consulta = "SELECT Camión, kg AS Total FROM Camiones";
            CargarChart(chart, consulta, "Kilogramos", 80000, 5000, pb);
        }

        public void CargarViaticos(Chart chart, ProgressBar pb)
        {
            string consulta = "SELECT Camión, ((Litros * Precio) + Viáticos) AS Total FROM  Camiones";
            CargarChart(chart, consulta, "Gastos Totales ($)", 500000, 50000, pb);
        }
    }

}