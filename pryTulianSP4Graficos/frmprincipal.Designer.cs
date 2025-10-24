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
            this.chartEstadisticas.Location = new System.Drawing.Point(53, 40);
            this.chartEstadisticas.Name = "chartEstadisticas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartEstadisticas.Series.Add(series1);
            this.chartEstadisticas.Size = new System.Drawing.Size(664, 300);
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
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}