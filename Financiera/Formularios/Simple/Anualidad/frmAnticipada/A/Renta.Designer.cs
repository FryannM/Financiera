namespace Financiera.Formularios.Simple.Anualidad.frmAnticipada.A
{
    partial class Renta
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelResultado = new System.Windows.Forms.Panel();
            this.txtResultado = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTasaPeriodica = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtTotalPeriodos = new System.Windows.Forms.NumericUpDown();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.panelResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasaPeriodica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPeriodos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelResultado
            // 
            this.panelResultado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelResultado.Controls.Add(this.txtResultado);
            this.panelResultado.Controls.Add(this.label4);
            this.panelResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelResultado.Location = new System.Drawing.Point(0, 165);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(531, 56);
            this.panelResultado.TabIndex = 139;
            this.panelResultado.Visible = false;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.Info;
            this.txtResultado.DecimalPlaces = 2;
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(250, 11);
            this.txtResultado.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtResultado.Minimum = new decimal(new int[] {
            -1,
            -1,
            -1,
            -2147483648});
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(227, 35);
            this.txtResultado.TabIndex = 51;
            this.txtResultado.ThousandsSeparator = true;
            this.txtResultado.Value = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 40);
            this.label4.TabIndex = 50;
            this.label4.Text = "Renta = $";
            // 
            // txtTasaPeriodica
            // 
            this.txtTasaPeriodica.DecimalPlaces = 2;
            this.txtTasaPeriodica.Location = new System.Drawing.Point(257, 39);
            this.txtTasaPeriodica.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtTasaPeriodica.Name = "txtTasaPeriodica";
            this.txtTasaPeriodica.Size = new System.Drawing.Size(187, 20);
            this.txtTasaPeriodica.TabIndex = 145;
            this.txtTasaPeriodica.ThousandsSeparator = true;
            this.txtTasaPeriodica.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(85, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 21);
            this.label6.TabIndex = 144;
            this.label6.Text = "Tasa Periódica = i%";
            // 
            // txtMonto
            // 
            this.txtMonto.DecimalPlaces = 2;
            this.txtMonto.Location = new System.Drawing.Point(258, 2);
            this.txtMonto.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtMonto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(187, 20);
            this.txtMonto.TabIndex = 143;
            this.txtMonto.ThousandsSeparator = true;
            this.txtMonto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 142;
            this.label3.Text = "Monto = S";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(425, 115);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(90, 51);
            this.btnCalcular.TabIndex = 138;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtTotalPeriodos
            // 
            this.txtTotalPeriodos.DecimalPlaces = 2;
            this.txtTotalPeriodos.Location = new System.Drawing.Point(256, 75);
            this.txtTotalPeriodos.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.txtTotalPeriodos.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtTotalPeriodos.Name = "txtTotalPeriodos";
            this.txtTotalPeriodos.Size = new System.Drawing.Size(167, 20);
            this.txtTotalPeriodos.TabIndex = 155;
            this.txtTotalPeriodos.ThousandsSeparator = true;
            this.txtTotalPeriodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(72, 74);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(174, 21);
            this.lblTiempo.TabIndex = 154;
            this.lblTiempo.Text = "Total de períodos = n";
            // 
            // Renta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtTotalPeriodos);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.txtTasaPeriodica);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Renta";
            this.Size = new System.Drawing.Size(531, 221);
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasaPeriodica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPeriodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.NumericUpDown txtResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtTasaPeriodica;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown txtMonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.NumericUpDown txtTotalPeriodos;
        private System.Windows.Forms.Label lblTiempo;
    }
}
