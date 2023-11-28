using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ejercicio_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        SqlConnection conexion = new SqlConnection("Data Source=DESKTOP-5A0MVHS;Initial Catalog=Vehiculos_Ejercicio_7;User ID=Rick_And_Morty;Password=123;");


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            DateTime fechainicio = DateTime.Parse(dtpFecha_Inicial.Value.ToString());
            DateTime fechafin = DateTime.Parse(dtpFecha_Final.Value.Date.ToString());

            Reportes_Ventas_Fechas reporte = new Reportes_Ventas_Fechas();
            reporte.fechainicial = fechainicio;
            reporte.fechafinal = fechafin;

            reporte.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
              
                dataGridView1.ReadOnly = true;

              
                string consulta = "SELECT ID_Venta, Fecha_Venta, Pais, Cliente, Vendedor, Categoria, Modelo, Precio_ventas, Cantidad, Total FROM VW_Ventas_PorFecha_v_2023_2";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);

                
                DataTable dt = new DataTable();
                adaptador.Fill(dt);

              
                dataGridView1.DataSource = dt;

          
                var totals = CalculateTotalAmountAndQuantity(dt);
                decimal totalAmount = totals.Item1; 
                lblTotalInvoices.Text = $"Monto Total: {totalAmount:C}";
                lblTotalInvoices.Text = $"Total Facturas: {dt.Rows.Count}";
                lblTotalQuantity.Text = $"Cantidad Vendidos: {totals.Item2}";

                
                this.CenterToScreen();
            }
            catch (Exception ex)
            {
                
                MessageBox.Show($"Se produjo un error en Form_Load: {ex.Message}\n\nTrace: {ex.StackTrace}");
            }
        }

        private Tuple<decimal, int> CalculateTotalAmountAndQuantity(DataTable dataTable)
        {
            decimal totalAmount = 0;
            int totalQuantity = 0;

            foreach (DataRow row in dataTable.Rows)
            {
                totalAmount += Convert.ToDecimal(row["Total"]);

               
                if (row["Cantidad"] != DBNull.Value)
                {
                    totalQuantity += Convert.ToInt32(row["Cantidad"]);
                }
            }

            return Tuple.Create(totalAmount, totalQuantity);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estás seguro de que deseas salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text;
            DataTable dt = (DataTable)dataGridView1.DataSource;

            if (!string.IsNullOrEmpty(filtro))
            {
                string expresion = string.Format("Cliente LIKE '%{0}%' OR Vendedor LIKE '%{0}%' OR Modelo LIKE '%{0}%'", filtro);
                dt.DefaultView.RowFilter = expresion;
            }
            else
            {
                dt.DefaultView.RowFilter = "";
            }

            UpdateLabels(); 
        }

        private void UpdateLabels()
        {
           
            decimal totalAmount = 0;
            int totalQuantity = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
               
                if (row.Visible && !row.IsNewRow)
                {
                    totalAmount += Convert.ToDecimal(row.Cells["Total"].Value);

                   
                    if (row.Cells["Cantidad"].Value != null)
                    {
                        totalQuantity += Convert.ToInt32(row.Cells["Cantidad"].Value);
                    }
                }
            }
            lblTotalAmount.Text = $"Monto Total: {totalAmount:C}";
            lblTotalInvoices.Text = $"Total Facturas: {dataGridView1.Rows.Cast<DataGridViewRow>().Count(row => row.Visible && !row.IsNewRow)}";
            lblTotalQuantity.Text = $"Cantidad Vendidos: {totalQuantity}";

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           
            txtBuscar.Text = "";
           
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = "";

            
            UpdateLabels();
        }
            
    }
}