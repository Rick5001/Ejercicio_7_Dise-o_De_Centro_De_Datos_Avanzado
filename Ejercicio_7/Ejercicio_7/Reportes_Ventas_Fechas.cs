using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace Ejercicio_7
{
    public partial class Reportes_Ventas_Fechas : Form
    {
        public DateTime fechainicial;
        public DateTime fechafinal;
  
        public Reportes_Ventas_Fechas()
        {
            InitializeComponent();
        }

        private void Reportes_Ventas_Fechas_Load(object sender, EventArgs e)
        {
            ReportDocument objReporte = new Reporte_Ventas();   
            objReporte.SetParameterValue(0, fechainicial);
            objReporte.SetParameterValue(1, fechafinal);
            crystalReportViewer1.ReportSource = objReporte;
        }
    }
}
