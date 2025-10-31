namespace pryCordobaSP4
{
    partial class frmInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViaticos = new System.Windows.Forms.Button();
            this.btnKilogramos = new System.Windows.Forms.Button();
            this.btnGastos = new System.Windows.Forms.Button();
            this.btnKilometros = new System.Windows.Forms.Button();
            this.chtCamiones = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblTipoGrafico = new System.Windows.Forms.Label();
            this.cmbTipoGrafico = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtCamiones)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.btnViaticos);
            this.panel1.Controls.Add(this.btnKilogramos);
            this.panel1.Controls.Add(this.btnGastos);
            this.panel1.Controls.Add(this.btnKilometros);
            this.panel1.Location = new System.Drawing.Point(28, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 433);
            this.panel1.TabIndex = 0;
            // 
            // btnViaticos
            // 
            this.btnViaticos.BackColor = System.Drawing.Color.Teal;
            this.btnViaticos.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViaticos.Location = new System.Drawing.Point(22, 319);
            this.btnViaticos.Name = "btnViaticos";
            this.btnViaticos.Size = new System.Drawing.Size(185, 61);
            this.btnViaticos.TabIndex = 4;
            this.btnViaticos.Text = "Gastos/Viaticos por Camión";
            this.btnViaticos.UseVisualStyleBackColor = false;
            this.btnViaticos.Click += new System.EventHandler(this.btnViaticos_Click);
            // 
            // btnKilogramos
            // 
            this.btnKilogramos.BackColor = System.Drawing.Color.Teal;
            this.btnKilogramos.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKilogramos.Location = new System.Drawing.Point(22, 226);
            this.btnKilogramos.Name = "btnKilogramos";
            this.btnKilogramos.Size = new System.Drawing.Size(185, 61);
            this.btnKilogramos.TabIndex = 3;
            this.btnKilogramos.Text = "Kilogramos por Camión";
            this.btnKilogramos.UseVisualStyleBackColor = false;
            this.btnKilogramos.Click += new System.EventHandler(this.btnKilogramos_Click);
            // 
            // btnGastos
            // 
            this.btnGastos.BackColor = System.Drawing.Color.Teal;
            this.btnGastos.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGastos.Location = new System.Drawing.Point(22, 137);
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Size = new System.Drawing.Size(185, 61);
            this.btnGastos.TabIndex = 2;
            this.btnGastos.Text = "Gastos por Camión";
            this.btnGastos.UseVisualStyleBackColor = false;
            this.btnGastos.Click += new System.EventHandler(this.btnGastos_Click);
            // 
            // btnKilometros
            // 
            this.btnKilometros.BackColor = System.Drawing.Color.Teal;
            this.btnKilometros.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKilometros.Location = new System.Drawing.Point(22, 49);
            this.btnKilometros.Name = "btnKilometros";
            this.btnKilometros.Size = new System.Drawing.Size(185, 61);
            this.btnKilometros.TabIndex = 1;
            this.btnKilometros.Text = "Kilometros por Camión";
            this.btnKilometros.UseVisualStyleBackColor = false;
            this.btnKilometros.Click += new System.EventHandler(this.btnKilometros_Click);
            // 
            // chtCamiones
            // 
            chartArea1.Name = "ChartArea1";
            this.chtCamiones.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtCamiones.Legends.Add(legend1);
            this.chtCamiones.Location = new System.Drawing.Point(398, 140);
            this.chtCamiones.Name = "chtCamiones";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtCamiones.Series.Add(series1);
            this.chtCamiones.Size = new System.Drawing.Size(677, 468);
            this.chtCamiones.TabIndex = 1;
            this.chtCamiones.Text = "chart1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(113, 17);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(908, 38);
            this.progressBar1.TabIndex = 2;
            // 
            // lblTipoGrafico
            // 
            this.lblTipoGrafico.AutoSize = true;
            this.lblTipoGrafico.Location = new System.Drawing.Point(12, 78);
            this.lblTipoGrafico.Name = "lblTipoGrafico";
            this.lblTipoGrafico.Size = new System.Drawing.Size(127, 21);
            this.lblTipoGrafico.TabIndex = 3;
            this.lblTipoGrafico.Text = "Tipo de Gráfico:";
            // 
            // cmbTipoGrafico
            // 
            this.cmbTipoGrafico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoGrafico.FormattingEnabled = true;
            this.cmbTipoGrafico.Location = new System.Drawing.Point(174, 78);
            this.cmbTipoGrafico.Name = "cmbTipoGrafico";
            this.cmbTipoGrafico.Size = new System.Drawing.Size(282, 29);
            this.cmbTipoGrafico.TabIndex = 4;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1114, 638);
            this.Controls.Add(this.cmbTipoGrafico);
            this.Controls.Add(this.lblTipoGrafico);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chtCamiones);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmInicio";
            this.Text = "Estadística de Consumo/Kilogramos/Gastos Por Camión";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtCamiones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKilometros;
        private System.Windows.Forms.Button btnViaticos;
        private System.Windows.Forms.Button btnKilogramos;
        private System.Windows.Forms.Button btnGastos;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtCamiones;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblTipoGrafico;
        private System.Windows.Forms.ComboBox cmbTipoGrafico;
    }
}