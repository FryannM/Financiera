namespace Financiera.Formularios
{
    partial class Interes_B
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
            this.txtTotalPeriodos = new System.Windows.Forms.NumericUpDown();
            this.txtTasaEfectiva = new System.Windows.Forms.NumericUpDown();
            this.txtCapital = new System.Windows.Forms.NumericUpDown();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panelResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPeriodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasaEfectiva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapital)).BeginInit();
            this.SuspendLayout();
            // 
            // panelResultado
            // 
            this.panelResultado.Controls.Add(this.txtResultado);
            this.panelResultado.Controls.Add(this.label4);
            this.panelResultado.Location = new System.Drawing.Point(35, 199);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(471, 56);
            this.panelResultado.TabIndex = 72;
            this.panelResultado.Visible = false;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.Info;
            this.txtResultado.DecimalPlaces = 2;
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(178, 8);
            this.txtResultado.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(267, 29);
            this.txtResultado.TabIndex = 51;
            this.txtResultado.ThousandsSeparator = true;
            this.txtResultado.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 21);
            this.label4.TabIndex = 50;
            this.label4.Text = "Interés = $";
            // 
            // txtTotalPeriodos
            // 
            this.txtTotalPeriodos.DecimalPlaces = 2;
            this.txtTotalPeriodos.Location = new System.Drawing.Point(194, 50);
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
            this.txtTotalPeriodos.TabIndex = 70;
            this.txtTotalPeriodos.ThousandsSeparator = true;
            this.txtTotalPeriodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtTasaEfectiva
            // 
            this.txtTasaEfectiva.DecimalPlaces = 2;
            this.txtTasaEfectiva.Location = new System.Drawing.Point(194, 101);
            this.txtTasaEfectiva.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtTasaEfectiva.Name = "txtTasaEfectiva";
            this.txtTasaEfectiva.Size = new System.Drawing.Size(187, 20);
            this.txtTasaEfectiva.TabIndex = 69;
            this.txtTasaEfectiva.ThousandsSeparator = true;
            this.txtTasaEfectiva.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtCapital
            // 
            this.txtCapital.DecimalPlaces = 2;
            this.txtCapital.Location = new System.Drawing.Point(194, 8);
            this.txtCapital.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtCapital.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(187, 20);
            this.txtCapital.TabIndex = 68;
            this.txtCapital.ThousandsSeparator = true;
            this.txtCapital.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(10, 49);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(174, 21);
            this.lblTiempo.TabIndex = 67;
            this.lblTiempo.Text = "Total de períodos = n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 21);
            this.label1.TabIndex = 66;
            this.label1.Text = "Tasa Efectiva = i%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 65;
            this.label2.Text = "Capital = P";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(419, 133);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(90, 51);
            this.btnCalcular.TabIndex = 71;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Interes_B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.txtTotalPeriodos);
            this.Controls.Add(this.txtTasaEfectiva);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Interes_B";
            this.Size = new System.Drawing.Size(531, 262);
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPeriodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasaEfectiva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapital)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.NumericUpDown txtResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtTotalPeriodos;
        private System.Windows.Forms.NumericUpDown txtTasaEfectiva;
        private System.Windows.Forms.NumericUpDown txtCapital;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
    }
}
