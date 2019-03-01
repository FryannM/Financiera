namespace Financiera.Formularios
{
    partial class TasaEfectiva_A
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.panelResultado = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTasaNominal = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.panelTasaNominal = new System.Windows.Forms.FlowLayoutPanel();
            this.cbPeriodos = new System.Windows.Forms.ComboBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasaNominal)).BeginInit();
            this.panelTasaNominal.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(417, 89);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(90, 51);
            this.btnCalcular.TabIndex = 93;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // panelResultado
            // 
            this.panelResultado.AutoSize = true;
            this.panelResultado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelResultado.Controls.Add(this.label4);
            this.panelResultado.Controls.Add(this.txtResultado);
            this.panelResultado.Controls.Add(this.label1);
            this.panelResultado.Location = new System.Drawing.Point(74, 159);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(385, 41);
            this.panelResultado.TabIndex = 106;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 36);
            this.label4.TabIndex = 52;
            this.label4.Text = "Tasa Efectiva = i";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.Info;
            this.txtResultado.DecimalPlaces = 2;
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(236, 3);
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
            this.txtResultado.Size = new System.Drawing.Size(94, 35);
            this.txtResultado.TabIndex = 53;
            this.txtResultado.ThousandsSeparator = true;
            this.txtResultado.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 40);
            this.label1.TabIndex = 54;
            this.label1.Text = "%";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(110, 62);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 107;
            // 
            // txtTasaNominal
            // 
            this.txtTasaNominal.DecimalPlaces = 2;
            this.txtTasaNominal.Location = new System.Drawing.Point(162, 3);
            this.txtTasaNominal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtTasaNominal.Name = "txtTasaNominal";
            this.txtTasaNominal.Size = new System.Drawing.Size(57, 20);
            this.txtTasaNominal.TabIndex = 102;
            this.txtTasaNominal.ThousandsSeparator = true;
            this.txtTasaNominal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 21);
            this.label5.TabIndex = 101;
            this.label5.Text = "Tasa Nominal = j%";
            // 
            // panelTasaNominal
            // 
            this.panelTasaNominal.AutoSize = true;
            this.panelTasaNominal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTasaNominal.Controls.Add(this.label5);
            this.panelTasaNominal.Controls.Add(this.txtTasaNominal);
            this.panelTasaNominal.Location = new System.Drawing.Point(102, 3);
            this.panelTasaNominal.Name = "panelTasaNominal";
            this.panelTasaNominal.Size = new System.Drawing.Size(222, 26);
            this.panelTasaNominal.TabIndex = 108;
            // 
            // cbPeriodos
            // 
            this.cbPeriodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeriodos.FormattingEnabled = true;
            this.cbPeriodos.Location = new System.Drawing.Point(243, 3);
            this.cbPeriodos.Name = "cbPeriodos";
            this.cbPeriodos.Size = new System.Drawing.Size(126, 21);
            this.cbPeriodos.TabIndex = 107;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(3, 0);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(234, 21);
            this.lblTiempo.TabIndex = 106;
            this.lblTiempo.Text = "Período de capitalización = m";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.lblTiempo);
            this.flowLayoutPanel2.Controls.Add(this.cbPeriodos);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(18, 49);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(372, 27);
            this.flowLayoutPanel2.TabIndex = 109;
            // 
            // TasaEfectiva_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panelTasaNominal);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.btnCalcular);
            this.Name = "TasaEfectiva_A";
            this.Size = new System.Drawing.Size(547, 199);
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasaNominal)).EndInit();
            this.panelTasaNominal.ResumeLayout(false);
            this.panelTasaNominal.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.FlowLayoutPanel panelResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NumericUpDown txtTasaNominal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel panelTasaNominal;
        private System.Windows.Forms.ComboBox cbPeriodos;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}
