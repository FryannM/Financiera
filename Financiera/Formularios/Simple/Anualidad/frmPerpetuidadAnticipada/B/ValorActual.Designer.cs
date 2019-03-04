namespace Financiera.Formularios.Simple.Anualidad.frmPerpetuidadAnticipada.B
{
    partial class ValorActual
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtTasaPeriodica = new System.Windows.Forms.NumericUpDown();
            this.txtRenta = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrimerPago = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panelResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasaPeriodica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrimerPago)).BeginInit();
            this.SuspendLayout();
            // 
            // panelResultado
            // 
            this.panelResultado.Controls.Add(this.txtResultado);
            this.panelResultado.Controls.Add(this.label4);
            this.panelResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelResultado.Location = new System.Drawing.Point(0, 150);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(531, 56);
            this.panelResultado.TabIndex = 93;
            this.panelResultado.Visible = false;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.Info;
            this.txtResultado.DecimalPlaces = 2;
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(251, 9);
            this.txtResultado.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(267, 35);
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
            this.label4.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(2, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 40);
            this.label4.TabIndex = 50;
            this.label4.Text = "Valor Actual = $";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(425, 93);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(90, 51);
            this.btnCalcular.TabIndex = 92;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtTasaPeriodica
            // 
            this.txtTasaPeriodica.DecimalPlaces = 2;
            this.txtTasaPeriodica.Location = new System.Drawing.Point(233, 49);
            this.txtTasaPeriodica.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtTasaPeriodica.Name = "txtTasaPeriodica";
            this.txtTasaPeriodica.Size = new System.Drawing.Size(187, 20);
            this.txtTasaPeriodica.TabIndex = 91;
            this.txtTasaPeriodica.ThousandsSeparator = true;
            this.txtTasaPeriodica.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtRenta
            // 
            this.txtRenta.DecimalPlaces = 2;
            this.txtRenta.Location = new System.Drawing.Point(233, 3);
            this.txtRenta.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtRenta.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtRenta.Name = "txtRenta";
            this.txtRenta.Size = new System.Drawing.Size(187, 20);
            this.txtRenta.TabIndex = 90;
            this.txtRenta.ThousandsSeparator = true;
            this.txtRenta.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 21);
            this.label1.TabIndex = 89;
            this.label1.Text = "Tasa Periódica = i%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 88;
            this.label2.Text = "Renta = R";
            // 
            // txtPrimerPago
            // 
            this.txtPrimerPago.DecimalPlaces = 2;
            this.txtPrimerPago.Location = new System.Drawing.Point(231, 94);
            this.txtPrimerPago.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtPrimerPago.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtPrimerPago.Name = "txtPrimerPago";
            this.txtPrimerPago.Size = new System.Drawing.Size(187, 20);
            this.txtPrimerPago.TabIndex = 95;
            this.txtPrimerPago.ThousandsSeparator = true;
            this.txtPrimerPago.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(104, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 21);
            this.label3.TabIndex = 94;
            this.label3.Text = "1er Pago = Q";
            // 
            // ValorActual_B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtPrimerPago);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTasaPeriodica);
            this.Controls.Add(this.txtRenta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ValorActual_B";
            this.Size = new System.Drawing.Size(531, 206);
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasaPeriodica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrimerPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.NumericUpDown txtResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.NumericUpDown txtTasaPeriodica;
        private System.Windows.Forms.NumericUpDown txtRenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtPrimerPago;
        private System.Windows.Forms.Label label3;
    }
}
