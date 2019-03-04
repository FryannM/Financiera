namespace Financiera.Formularios
{
    partial class TotalPeriodos_A
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
            this.panelTiempo = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPeriodos = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPeriodo = new System.Windows.Forms.NumericUpDown();
            this.panelResultado = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.NumericUpDown();
            this.panelTiempo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTiempo)).BeginInit();
            this.panelPeriodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo)).BeginInit();
            this.panelResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(545, 45);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(90, 51);
            this.btnCalcular.TabIndex = 106;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // panelTiempo
            // 
            this.panelTiempo.AutoSize = true;
            this.panelTiempo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTiempo.Controls.Add(this.label1);
            this.panelTiempo.Controls.Add(this.txtTiempo);
            this.panelTiempo.Controls.Add(this.label2);
            this.panelTiempo.Location = new System.Drawing.Point(185, 9);
            this.panelTiempo.Name = "panelTiempo";
            this.panelTiempo.Size = new System.Drawing.Size(280, 26);
            this.panelTiempo.TabIndex = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 117;
            this.label1.Text = "Tiempo = t";
            // 
            // txtTiempo
            // 
            this.txtTiempo.DecimalPlaces = 2;
            this.txtTiempo.Location = new System.Drawing.Point(102, 3);
            this.txtTiempo.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.txtTiempo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(112, 20);
            this.txtTiempo.TabIndex = 115;
            this.txtTiempo.ThousandsSeparator = true;
            this.txtTiempo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(220, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 116;
            this.label2.Text = "año(s)";
            // 
            // panelPeriodos
            // 
            this.panelPeriodos.AutoSize = true;
            this.panelPeriodos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelPeriodos.Controls.Add(this.label3);
            this.panelPeriodos.Controls.Add(this.txtPeriodo);
            this.panelPeriodos.Location = new System.Drawing.Point(35, 45);
            this.panelPeriodos.Name = "panelPeriodos";
            this.panelPeriodos.Size = new System.Drawing.Size(400, 26);
            this.panelPeriodos.TabIndex = 128;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 21);
            this.label3.TabIndex = 127;
            this.label3.Text = "Períodos de capitalización = m";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.DecimalPlaces = 2;
            this.txtPeriodo.Location = new System.Drawing.Point(251, 3);
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
            this.txtPeriodo.Size = new System.Drawing.Size(146, 20);
            this.txtPeriodo.TabIndex = 128;
            this.txtPeriodo.ThousandsSeparator = true;
            this.txtPeriodo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panelResultado
            // 
            this.panelResultado.AutoSize = true;
            this.panelResultado.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelResultado.Controls.Add(this.label4);
            this.panelResultado.Controls.Add(this.txtResultado);
            this.panelResultado.Location = new System.Drawing.Point(71, 115);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(414, 35);
            this.panelResultado.TabIndex = 129;
            this.panelResultado.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 21);
            this.label4.TabIndex = 52;
            this.label4.Text = "Total de Períodos = n";
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.Info;
            this.txtResultado.DecimalPlaces = 2;
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(184, 3);
            this.txtResultado.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(227, 29);
            this.txtResultado.TabIndex = 53;
            this.txtResultado.ThousandsSeparator = true;
            this.txtResultado.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // TotalPeriodos_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.panelPeriodos);
            this.Controls.Add(this.panelTiempo);
            this.Controls.Add(this.btnCalcular);
            this.Name = "TotalPeriodos_A";
            this.Size = new System.Drawing.Size(637, 159);
            this.panelTiempo.ResumeLayout(false);
            this.panelTiempo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTiempo)).EndInit();
            this.panelPeriodos.ResumeLayout(false);
            this.panelPeriodos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo)).EndInit();
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.FlowLayoutPanel panelTiempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtTiempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel panelPeriodos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtPeriodo;
        private System.Windows.Forms.FlowLayoutPanel panelResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtResultado;
    }
}
