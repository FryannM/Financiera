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
            this.panelResultado = new System.Windows.Forms.Panel();
            this.txtResultado = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPeriodo = new System.Windows.Forms.Label();
            this.groupBoxPeriodo = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtPeriodo = new System.Windows.Forms.NumericUpDown();
            this.cbPeriodos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panelResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultado)).BeginInit();
            this.groupBoxPeriodo.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTiempo)).BeginInit();
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
            // panelResultado
            // 
            this.panelResultado.Controls.Add(this.txtResultado);
            this.panelResultado.Controls.Add(this.label4);
            this.panelResultado.Controls.Add(this.labelPeriodo);
            this.panelResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelResultado.Location = new System.Drawing.Point(0, 153);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(751, 56);
            this.panelResultado.TabIndex = 120;
            this.panelResultado.Visible = false;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.Info;
            this.txtResultado.DecimalPlaces = 2;
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(287, 9);
            this.txtResultado.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(227, 35);
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
            this.label4.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 36);
            this.label4.TabIndex = 50;
            this.label4.Text = "Total de Períodos = n";
            // 
            // labelPeriodo
            // 
            this.labelPeriodo.AutoSize = true;
            this.labelPeriodo.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeriodo.Location = new System.Drawing.Point(527, 8);
            this.labelPeriodo.Name = "labelPeriodo";
            this.labelPeriodo.Size = new System.Drawing.Size(209, 36);
            this.labelPeriodo.TabIndex = 123;
            this.labelPeriodo.Text = "Cuatrimestre(s)";
            // 
            // groupBoxPeriodo
            // 
            this.groupBoxPeriodo.Controls.Add(this.flowLayoutPanel1);
            this.groupBoxPeriodo.Font = new System.Drawing.Font("Times New Roman", 14.25F);
            this.groupBoxPeriodo.Location = new System.Drawing.Point(16, 42);
            this.groupBoxPeriodo.Name = "groupBoxPeriodo";
            this.groupBoxPeriodo.Size = new System.Drawing.Size(436, 100);
            this.groupBoxPeriodo.TabIndex = 121;
            this.groupBoxPeriodo.TabStop = false;
            this.groupBoxPeriodo.Text = "Períodos de capitalización = m";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.txtPeriodo);
            this.flowLayoutPanel1.Controls.Add(this.cbPeriodos);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(59, 25);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(344, 43);
            this.flowLayoutPanel1.TabIndex = 125;
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.DecimalPlaces = 2;
            this.txtPeriodo.Location = new System.Drawing.Point(3, 3);
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
            this.txtPeriodo.Size = new System.Drawing.Size(157, 29);
            this.txtPeriodo.TabIndex = 125;
            this.txtPeriodo.ThousandsSeparator = true;
            this.txtPeriodo.Value = new decimal(new int[] {
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
            this.cbPeriodos.Size = new System.Drawing.Size(154, 29);
            this.cbPeriodos.TabIndex = 124;
            this.cbPeriodos.SelectedIndexChanged += new System.EventHandler(this.cbPeriodos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 112;
            this.label1.Text = "Tiempo = t";
            // 
            // txtTiempo
            // 
            this.txtTiempo.DecimalPlaces = 2;
            this.txtTiempo.Location = new System.Drawing.Point(237, 10);
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
            this.txtTiempo.Size = new System.Drawing.Size(167, 20);
            this.txtTiempo.TabIndex = 113;
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
            this.label2.Location = new System.Drawing.Point(410, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 114;
            this.label2.Text = "año(s)";
            // 
            // TotalPeriodos_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxPeriodo);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Name = "TotalPeriodos_A";
            this.Size = new System.Drawing.Size(751, 209);
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultado)).EndInit();
            this.groupBoxPeriodo.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTiempo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.NumericUpDown txtResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxPeriodo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.NumericUpDown txtPeriodo;
        private System.Windows.Forms.ComboBox cbPeriodos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtTiempo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelPeriodo;
    }
}
