namespace Financiera.Formularios
{
    partial class Capital_A
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
            this.txtInteres = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.panelResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInteres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelResultado
            // 
            this.panelResultado.Controls.Add(this.txtResultado);
            this.panelResultado.Controls.Add(this.label4);
            this.panelResultado.Location = new System.Drawing.Point(41, 141);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(471, 56);
            this.panelResultado.TabIndex = 82;
            this.panelResultado.Visible = false;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.Info;
            this.txtResultado.DecimalPlaces = 2;
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(184, 8);
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
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 23);
            this.label4.TabIndex = 50;
            this.label4.Text = "Capital = $";
            // 
            // txtInteres
            // 
            this.txtInteres.DecimalPlaces = 2;
            this.txtInteres.Location = new System.Drawing.Point(205, 53);
            this.txtInteres.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtInteres.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(187, 20);
            this.txtInteres.TabIndex = 77;
            this.txtInteres.ThousandsSeparator = true;
            this.txtInteres.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 74;
            this.label2.Text = "Interes = I";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(422, 84);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(90, 51);
            this.btnCalcular.TabIndex = 80;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.DecimalPlaces = 2;
            this.txtMonto.Location = new System.Drawing.Point(205, 10);
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
            this.txtMonto.TabIndex = 84;
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
            this.label3.Location = new System.Drawing.Point(105, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 83;
            this.label3.Text = "Monto = S";
            // 
            // Capital_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.txtInteres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Capital_A";
            this.Size = new System.Drawing.Size(531, 198);
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInteres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.NumericUpDown txtResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtInteres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.NumericUpDown txtMonto;
        private System.Windows.Forms.Label label3;
    }
}
