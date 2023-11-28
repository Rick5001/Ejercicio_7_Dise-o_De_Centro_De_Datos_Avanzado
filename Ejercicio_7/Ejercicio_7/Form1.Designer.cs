
namespace Ejercicio_7
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FechaInicial = new System.Windows.Forms.Label();
            this.FechaFinal = new System.Windows.Forms.Label();
            this.dtpFecha_Inicial = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha_Final = new System.Windows.Forms.DateTimePicker();
            this.btnVer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalInvoices = new System.Windows.Forms.Label();
            this.lblTotalQuantity = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaInicial
            // 
            this.FechaInicial.AutoSize = true;
            this.FechaInicial.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaInicial.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FechaInicial.Location = new System.Drawing.Point(805, 39);
            this.FechaInicial.Name = "FechaInicial";
            this.FechaInicial.Size = new System.Drawing.Size(130, 22);
            this.FechaInicial.TabIndex = 0;
            this.FechaInicial.Text = "FECHA INICIAL";
            // 
            // FechaFinal
            // 
            this.FechaFinal.AutoSize = true;
            this.FechaFinal.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FechaFinal.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.FechaFinal.Location = new System.Drawing.Point(1065, 39);
            this.FechaFinal.Name = "FechaFinal";
            this.FechaFinal.Size = new System.Drawing.Size(118, 22);
            this.FechaFinal.TabIndex = 1;
            this.FechaFinal.Text = "FECHA FINAL";
            // 
            // dtpFecha_Inicial
            // 
            this.dtpFecha_Inicial.Location = new System.Drawing.Point(780, 83);
            this.dtpFecha_Inicial.Name = "dtpFecha_Inicial";
            this.dtpFecha_Inicial.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha_Inicial.TabIndex = 2;
            // 
            // dtpFecha_Final
            // 
            this.dtpFecha_Final.Location = new System.Drawing.Point(1021, 83);
            this.dtpFecha_Final.Name = "dtpFecha_Final";
            this.dtpFecha_Final.Size = new System.Drawing.Size(200, 20);
            this.dtpFecha_Final.TabIndex = 3;
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.Lime;
            this.btnVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnVer.Location = new System.Drawing.Point(882, 250);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(162, 57);
            this.btnVer.TabIndex = 4;
            this.btnVer.Text = "Generar Reporte";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(1094, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 57);
            this.button2.TabIndex = 5;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ejercicio_7.Properties.Resources._cb29f686_2eef_467c_a019_d5a802f6824a__1_;
            this.pictureBox1.Location = new System.Drawing.Point(45, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(706, 211);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Yellow;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLimpiar.Location = new System.Drawing.Point(658, 250);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(162, 57);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "💾 Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Aqua;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBuscar.Location = new System.Drawing.Point(441, 250);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(162, 57);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "🔎 Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(45, 250);
            this.txtBuscar.Multiline = true;
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(337, 57);
            this.txtBuscar.TabIndex = 9;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Magenta;
            this.lblTotalAmount.Location = new System.Drawing.Point(87, 324);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(57, 22);
            this.lblTotalAmount.TabIndex = 10;
            this.lblTotalAmount.Text = "Total:";
            this.lblTotalAmount.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTotalInvoices
            // 
            this.lblTotalInvoices.AutoSize = true;
            this.lblTotalInvoices.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalInvoices.ForeColor = System.Drawing.Color.Magenta;
            this.lblTotalInvoices.Location = new System.Drawing.Point(323, 324);
            this.lblTotalInvoices.Name = "lblTotalInvoices";
            this.lblTotalInvoices.Size = new System.Drawing.Size(82, 22);
            this.lblTotalInvoices.TabIndex = 11;
            this.lblTotalInvoices.Text = "Facturas:";
            // 
            // lblTotalQuantity
            // 
            this.lblTotalQuantity.AutoSize = true;
            this.lblTotalQuantity.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalQuantity.ForeColor = System.Drawing.Color.Magenta;
            this.lblTotalQuantity.Location = new System.Drawing.Point(627, 324);
            this.lblTotalQuantity.Name = "lblTotalQuantity";
            this.lblTotalQuantity.Size = new System.Drawing.Size(193, 22);
            this.lblTotalQuantity.TabIndex = 12;
            this.lblTotalQuantity.Text = "Cantidad de vehiculos:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 360);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1202, 297);
            this.dataGridView1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1272, 669);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTotalQuantity);
            this.Controls.Add(this.lblTotalInvoices);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.dtpFecha_Final);
            this.Controls.Add(this.dtpFecha_Inicial);
            this.Controls.Add(this.FechaFinal);
            this.Controls.Add(this.FechaInicial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Reporte de mi tienda RRM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FechaInicial;
        private System.Windows.Forms.Label FechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFecha_Inicial;
        private System.Windows.Forms.DateTimePicker dtpFecha_Final;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalInvoices;
        private System.Windows.Forms.Label lblTotalQuantity;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

