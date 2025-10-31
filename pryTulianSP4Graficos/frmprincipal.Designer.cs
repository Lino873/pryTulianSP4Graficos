namespace pryTulianSP4Graficos
{
    partial class frmprincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmprincipal));
            this.chartEstadisticas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.statusStripPrincipal = new System.Windows.Forms.StatusStrip();
            this.lblestadoonexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.btncamion = new System.Windows.Forms.Button();
            this.btngastos = new System.Windows.Forms.Button();
            this.btnkilogramos = new System.Windows.Forms.Button();
            this.btnviaticos = new System.Windows.Forms.Button();
            this.cbotipografico = new System.Windows.Forms.ComboBox();
            this.lbltipografico = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartEstadisticas)).BeginInit();
            this.statusStripPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartEstadisticas
            // 
            chartArea1.Name = "ChartArea1";
            this.chartEstadisticas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartEstadisticas.Legends.Add(legend1);
            this.chartEstadisticas.Location = new System.Drawing.Point(112, 59);
            this.chartEstadisticas.Name = "chartEstadisticas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartEstadisticas.Series.Add(series1);
            this.chartEstadisticas.Size = new System.Drawing.Size(676, 318);
            this.chartEstadisticas.TabIndex = 0;
            this.chartEstadisticas.Text = "chart1";
            // 
            // statusStripPrincipal
            // 
            this.statusStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblestadoonexion});
            this.statusStripPrincipal.Location = new System.Drawing.Point(0, 428);
            this.statusStripPrincipal.Name = "statusStripPrincipal";
            this.statusStripPrincipal.Size = new System.Drawing.Size(800, 22);
            this.statusStripPrincipal.TabIndex = 1;
            this.statusStripPrincipal.Text = "statusStrip1";
            // 
            // lblestadoonexion
            // 
            this.lblestadoonexion.Name = "lblestadoonexion";
            this.lblestadoonexion.Size = new System.Drawing.Size(118, 17);
            this.lblestadoonexion.Text = "toolStripStatusLabel1";
            // 
            // btncamion
            // 
            this.btncamion.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btncamion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncamion.Location = new System.Drawing.Point(0, 89);
            this.btncamion.Name = "btncamion";
            this.btncamion.Size = new System.Drawing.Size(106, 49);
            this.btncamion.TabIndex = 2;
            this.btncamion.Text = "Km Recorido por camión";
            this.btncamion.UseVisualStyleBackColor = false;
            this.btncamion.Click += new System.EventHandler(this.btncamion_Click);
            // 
            // btngastos
            // 
            this.btngastos.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btngastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngastos.Location = new System.Drawing.Point(0, 169);
            this.btngastos.Name = "btngastos";
            this.btngastos.Size = new System.Drawing.Size(106, 49);
            this.btngastos.TabIndex = 3;
            this.btngastos.Text = "Gastos por camiòn";
            this.btngastos.UseVisualStyleBackColor = false;
            this.btngastos.Click += new System.EventHandler(this.btngastos_Click);
            // 
            // btnkilogramos
            // 
            this.btnkilogramos.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnkilogramos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkilogramos.Location = new System.Drawing.Point(0, 251);
            this.btnkilogramos.Name = "btnkilogramos";
            this.btnkilogramos.Size = new System.Drawing.Size(106, 49);
            this.btnkilogramos.TabIndex = 4;
            this.btnkilogramos.Text = "Kilogramos por camiòn";
            this.btnkilogramos.UseVisualStyleBackColor = false;
            this.btnkilogramos.Click += new System.EventHandler(this.btnkilogramos_Click);
            // 
            // btnviaticos
            // 
            this.btnviaticos.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnviaticos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnviaticos.Location = new System.Drawing.Point(0, 328);
            this.btnviaticos.Name = "btnviaticos";
            this.btnviaticos.Size = new System.Drawing.Size(106, 49);
            this.btnviaticos.TabIndex = 5;
            this.btnviaticos.Text = "Gastos/Viaticos por camiòn";
            this.btnviaticos.UseVisualStyleBackColor = false;
            this.btnviaticos.Click += new System.EventHandler(this.btnviaticos_Click);
            // 
            // cbotipografico
            // 
            this.cbotipografico.FormattingEnabled = true;
            this.cbotipografico.Items.AddRange(new object[] {
            "Gráfico de columna",
            "Gráfico de línea",
            "Gráfico de barra"});
            this.cbotipografico.Location = new System.Drawing.Point(0, 59);
            this.cbotipografico.Name = "cbotipografico";
            this.cbotipografico.Size = new System.Drawing.Size(106, 21);
            this.cbotipografico.TabIndex = 6;
            // 
            // lbltipografico
            // 
            this.lbltipografico.AutoSize = true;
            this.lbltipografico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltipografico.Location = new System.Drawing.Point(-3, 43);
            this.lbltipografico.Name = "lbltipografico";
            this.lbltipografico.Size = new System.Drawing.Size(81, 13);
            this.lbltipografico.TabIndex = 7;
            this.lbltipografico.Text = "Tipo de gràfico:";
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbltipografico);
            this.Controls.Add(this.cbotipografico);
            this.Controls.Add(this.btnviaticos);
            this.Controls.Add(this.btnkilogramos);
            this.Controls.Add(this.btngastos);
            this.Controls.Add(this.btncamion);
            this.Controls.Add(this.statusStripPrincipal);
            this.Controls.Add(this.chartEstadisticas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmprincipal";
            this.Text = "Control Transporte";
            this.Load += new System.EventHandler(this.frmprincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartEstadisticas)).EndInit();
            this.statusStripPrincipal.ResumeLayout(false);
            this.statusStripPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartEstadisticas;
        private System.Windows.Forms.StatusStrip statusStripPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel lblestadoonexion;
        private System.Windows.Forms.Button btncamion;
        private System.Windows.Forms.Button btngastos;
        private System.Windows.Forms.Button btnkilogramos;
        private System.Windows.Forms.Button btnviaticos;
        private System.Windows.Forms.ComboBox cbotipografico;
        private System.Windows.Forms.Label lbltipografico;
    }
}