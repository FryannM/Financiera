namespace Financiera.Formularios
{
    partial class TasaNominal_B
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtMonto = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCapital = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxPeriodo = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTotalPeriodos = new System.Windows.Forms.NumericUpDown();
            this.cbPeriodos = new System.Windows.Forms.ComboBox();
            this.panelResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapital)).BeginInit();
            this.groupBoxPeriodo.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPeriodos)).BeginInit();
            this.SuspendLayout();
            // 
            // panelResultado
            // 
            this.panelResultado.Controls.Add(this.txtResultado);
            this.panelResultado.Controls.Add(this.label4);
            this.panelResultado.Controls.Add(this.label1);
            this.panelResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelResultado.Location = new System.Drawing.Point(0, 206);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(531, 56);
            this.panelResultado.TabIndex = 119;
            this.panelResultado.Visible = false;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.Info;
            this.txtResultado.DecimalPlaces = 2;
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(254, 9);
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
            this.txtResultado.Size = new System.Drawing.Size(226, 35);
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
            this.label4.Location = new System.Drawing.Point(-3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(251, 40);
            this.label4.TabIndex = 50;
            this.label4.Text = "Tasa Efectiva = i";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 40);
            this.label1.TabIndex = 53;
            this.label1.Text = "%";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(425, 118);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(90, 51);
            this.btnCalcular.TabIndex = 118;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtMonto
            // 
            this.txtMonto.DecimalPlaces = 2;
            this.txtMonto.Location = new System.Drawing.Point(248, 5);
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
            this.txtMonto.TabIndex = 123;
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
            this.label3.Location = new System.Drawing.Point(148, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 122;
            this.label3.Text = "Monto = S";
            // 
            // txtCapital
            // 
            this.txtCapital.DecimalPlaces = 2;
            this.txtCapital.Location = new System.Drawing.Point(244, 48);
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
            this.txtCapital.TabIndex = 121;
            this.txtCapital.ThousandsSeparator = true;
            this.txtCapital.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(144, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 120;
            this.label2.Text = "Capital = P";
            // 
            // groupBoxPeriodo
            // 
            this.groupBoxPeriodo.Controls.Add(this.flowLayoutPanel1);
            this.groupBoxPeriodo.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.groupBoxPeriodo.Location = new System.Drawing.Point(40, 89);
            this.groupBoxPeriodo.Name = "groupBoxPeriodo";
            this.groupBoxPeriodo.Size = new System.Drawing.Size(436, 100);
            this.groupBoxPeriodo.TabIndex = 124;
            this.groupBoxPeriodo.TabStop = false;
            this.groupBoxPeriodo.Text = "Total de Períodos = n";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txtTotalPeriodos);
            this.flowLayoutPanel1.Controls.Add(this.cbPeriodos);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(46, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(335, 43);
            this.flowLayoutPanel1.TabIndex = 125;
            // 
            // txtTotalPeriodos
            // 
            this.txtTotalPeriodos.DecimalPlaces = 2;
            this.txtTotalPeriodos.Location = new System.Drawing.Point(3, 3);
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
            this.txtTotalPeriodos.Size = new System.Drawing.Size(157, 29);
            this.txtTotalPeriodos.TabIndex = 125;
            this.txtTotalPeriodos.ThousandsSeparator = true;
            this.txtTotalPeriodos.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbPeriodos
            // 
            this.cbPeriodos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPeriodos.FormattingEnabled = true;
            this.cbPeriodos.Location = new System.Drawing.Point(166, 3);
            this.cbPeriodos.Name = "cbPeriodos";
            this.cbPeriodos.Size = new System.Drawing.Size(149, 29);
            this.cbPeriodos.TabIndex = 124;
            // 
            // TasaNominal_B
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxPeriodo);
            this.Name = "TasaNominal_B";
            this.Size = new System.Drawing.Size(531, 262);
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapital)).EndInit();
            this.groupBoxPeriodo.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPeriodos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.NumericUpDown txtResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.NumericUpDown txtMonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtCapital;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxPeriodo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NumericUpDown txtTotalPeriodos;
        private System.Windows.Forms.ComboBox cbPeriodos;
    }
}
