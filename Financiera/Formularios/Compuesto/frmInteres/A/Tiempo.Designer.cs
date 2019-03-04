namespace Financiera.Formularios
{
    partial class Tiempo
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
            this.txtTotalPeriodos = new System.Windows.Forms.NumericUpDown();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.txtResultado = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPeriodo = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.NumericUpDown();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPeriodos)).BeginInit();
            this.panelResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTotalPeriodos
            // 
            this.txtTotalPeriodos.DecimalPlaces = 2;
            this.txtTotalPeriodos.Location = new System.Drawing.Point(265, 18);
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
            this.txtTotalPeriodos.TabIndex = 117;
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
            this.lblTiempo.Location = new System.Drawing.Point(81, 17);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(174, 21);
            this.lblTiempo.TabIndex = 116;
            this.lblTiempo.Text = "Total de períodos = n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 21);
            this.label1.TabIndex = 118;
            this.label1.Text = "Frecuencia de capitalización = m";
            // 
            // panelResultado
            // 
            this.panelResultado.Controls.Add(this.txtResultado);
            this.panelResultado.Controls.Add(this.label4);
            this.panelResultado.Controls.Add(this.labelPeriodo);
            this.panelResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelResultado.Location = new System.Drawing.Point(0, 109);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(561, 56);
            this.panelResultado.TabIndex = 121;
            this.panelResultado.Visible = false;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.Info;
            this.txtResultado.DecimalPlaces = 2;
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(173, 9);
            this.txtResultado.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(227, 29);
            this.txtResultado.TabIndex = 51;
            this.txtResultado.ThousandsSeparator = true;
            this.txtResultado.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 50;
            this.label4.Text = "Tiempo= t";
            // 
            // labelPeriodo
            // 
            this.labelPeriodo.AutoSize = true;
            this.labelPeriodo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeriodo.Location = new System.Drawing.Point(433, 8);
            this.labelPeriodo.Name = "labelPeriodo";
            this.labelPeriodo.Size = new System.Drawing.Size(62, 21);
            this.labelPeriodo.TabIndex = 123;
            this.labelPeriodo.Text = "Año(s)";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.DecimalPlaces = 2;
            this.txtPeriodo.Location = new System.Drawing.Point(265, 57);
            this.txtPeriodo.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.txtPeriodo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.Size = new System.Drawing.Size(157, 20);
            this.txtPeriodo.TabIndex = 126;
            this.txtPeriodo.ThousandsSeparator = true;
            this.txtPeriodo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(450, 44);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(90, 51);
            this.btnCalcular.TabIndex = 127;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Tiempo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPeriodo);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalPeriodos);
            this.Controls.Add(this.lblTiempo);
            this.Name = "Tiempo";
            this.Size = new System.Drawing.Size(561, 165);
            ((System.ComponentModel.ISupportInitialize)(this.txtTotalPeriodos)).EndInit();
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtTotalPeriodos;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.NumericUpDown txtResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelPeriodo;
        private System.Windows.Forms.NumericUpDown txtPeriodo;
        private System.Windows.Forms.Button btnCalcular;
    }
}
