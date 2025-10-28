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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryCordobaSP4
{
    public partial class frmInicio : Form
    {
        clsConexionBD claseConexion = new clsConexionBD();
        public frmInicio()
        {
            InitializeComponent();
        }

        private SeriesChartType ObtenerTipoGrafico()
        {
           switch (cmbTipoGrafico.SelectedItem.ToString())
           {
              case "Gráfico de línea":
                  return SeriesChartType.Line;
              case "Gráfico de barra":
                  return SeriesChartType.Bar;
              case "Gráfico circular":
                  return SeriesChartType.Pie;
              default:
                  return SeriesChartType.Column;
           }
        }
        private void btnKilometros_Click(object sender, EventArgs e)
        {
            claseConexion.CargarKilometros(chtCamiones, progressBar1, ObtenerTipoGrafico());
        }

        private void btnGastos_Click(object sender, EventArgs e)
        {
            claseConexion.CargarGastos(chtCamiones, progressBar1, ObtenerTipoGrafico());
        }

        private void btnKilogramos_Click(object sender, EventArgs e)
        {
            claseConexion.CargarKilogramos(chtCamiones, progressBar1, ObtenerTipoGrafico());
        }

        private void btnViaticos_Click(object sender, EventArgs e)
        {
            claseConexion.CargarViaticos(chtCamiones, progressBar1, ObtenerTipoGrafico());
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            progressBar1.Visible = false;

            cmbTipoGrafico.Items.Add("Gráfico de columna");
            cmbTipoGrafico.Items.Add("Gráfico de línea");
            cmbTipoGrafico.Items.Add("Gráfico de barra");
            cmbTipoGrafico.Items.Add("Gráfico circular");
            cmbTipoGrafico.SelectedIndex = 0;
        }
    }
}
