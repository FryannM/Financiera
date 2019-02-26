namespace Financiera.Formularios
{
    partial class frmDescuentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDescuentos));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDescuentoSimple = new System.Windows.Forms.ComboBox();
            this.panelCampos = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipoTasa = new System.Windows.Forms.ComboBox();
            this.btnSumaSolicitada = new System.Windows.Forms.Button();
            this.btnTasaDescuento = new System.Windows.Forms.Button();
            this.btnDescuento = new System.Windows.Forms.Button();
            this.btnTiempo = new System.Windows.Forms.Button();
            this.txtTiempo = new System.Windows.Forms.NumericUpDown();
            this.txtTasaDescuento = new System.Windows.Forms.NumericUpDown();
            this.txtDescuentoBancario = new System.Windows.Forms.NumericUpDown();
            this.txtSumaSolicitada = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcapital = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.txtResultado = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panelCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasaDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuentoBancario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSumaSolicitada)).BeginInit();
            this.panelResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(57, 52);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(212, 31);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Descuento Simple";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 21);
            this.label3.TabIndex = 34;
            this.label3.Text = "¿Qué Desea Calcular?";
            // 
            // cbDescuentoSimple
            // 
            this.cbDescuentoSimple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDescuentoSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDescuentoSimple.FormattingEnabled = true;
            this.cbDescuentoSimple.Items.AddRange(new object[] {
            "Descuento Bancario",
            "Suma Solicitada",
            "Tasa de Descuento",
            "Tiempo"});
            this.cbDescuentoSimple.Location = new System.Drawing.Point(252, 100);
            this.cbDescuentoSimple.Name = "cbDescuentoSimple";
            this.cbDescuentoSimple.Size = new System.Drawing.Size(187, 28);
            this.cbDescuentoSimple.TabIndex = 35;
            this.cbDescuentoSimple.SelectedIndexChanged += new System.EventHandler(this.cbDescuentoSimple_SelectedIndexChanged);
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.label5);
            this.panelCampos.Controls.Add(this.cbTipoTasa);
            this.panelCampos.Controls.Add(this.btnSumaSolicitada);
            this.panelCampos.Controls.Add(this.btnTasaDescuento);
            this.panelCampos.Controls.Add(this.btnDescuento);
            this.panelCampos.Controls.Add(this.btnTiempo);
            this.panelCampos.Controls.Add(this.txtTiempo);
            this.panelCampos.Controls.Add(this.txtTasaDescuento);
            this.panelCampos.Controls.Add(this.txtDescuentoBancario);
            this.panelCampos.Controls.Add(this.txtSumaSolicitada);
            this.panelCampos.Controls.Add(this.label6);
            this.panelCampos.Controls.Add(this.lblTiempo);
            this.panelCampos.Controls.Add(this.label1);
            this.panelCampos.Controls.Add(this.lblcapital);
            this.panelCampos.Controls.Add(this.label2);
            this.panelCampos.Controls.Add(this.panelResultado);
            this.panelCampos.Location = new System.Drawing.Point(27, 143);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(510, 306);
            this.panelCampos.TabIndex = 36;
            this.panelCampos.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(117, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 53;
            this.label5.Text = "Tasa en ";
            // 
            // cbTipoTasa
            // 
            this.cbTipoTasa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoTasa.FormattingEnabled = true;
            this.cbTipoTasa.Items.AddRange(new object[] {
            "Mensual",
            "Bimestral",
            "Trimestral",
            "Cuatrimestral",
            "Semestral",
            "Anual",
            "Quincenal"});
            this.cbTipoTasa.Location = new System.Drawing.Point(225, 151);
            this.cbTipoTasa.Name = "cbTipoTasa";
            this.cbTipoTasa.Size = new System.Drawing.Size(187, 21);
            this.cbTipoTasa.TabIndex = 52;
            this.cbTipoTasa.SelectedIndex = cbTipoTasa.Items.IndexOf("Mensual");
            // 
            // btnSumaSolicitada
            // 
            this.btnSumaSolicitada.Location = new System.Drawing.Point(414, 188);
            this.btnSumaSolicitada.Name = "btnSumaSolicitada";
            this.btnSumaSolicitada.Size = new System.Drawing.Size(90, 51);
            this.btnSumaSolicitada.TabIndex = 46;
            this.btnSumaSolicitada.Text = "Suma Solicitada";
            this.btnSumaSolicitada.UseVisualStyleBackColor = true;
            this.btnSumaSolicitada.Click += new System.EventHandler(this.btnSumaSolicitada_Click);
            // 
            // btnTasaDescuento
            // 
            this.btnTasaDescuento.Location = new System.Drawing.Point(414, 188);
            this.btnTasaDescuento.Name = "btnTasaDescuento";
            this.btnTasaDescuento.Size = new System.Drawing.Size(90, 51);
            this.btnTasaDescuento.TabIndex = 45;
            this.btnTasaDescuento.Text = "Tasa Descuento";
            this.btnTasaDescuento.UseVisualStyleBackColor = true;
            this.btnTasaDescuento.Click += new System.EventHandler(this.btnTasaDescuento_Click);
            // 
            // btnDescuento
            // 
            this.btnDescuento.Location = new System.Drawing.Point(414, 188);
            this.btnDescuento.Name = "btnDescuento";
            this.btnDescuento.Size = new System.Drawing.Size(90, 51);
            this.btnDescuento.TabIndex = 43;
            this.btnDescuento.Text = "Descuento";
            this.btnDescuento.UseVisualStyleBackColor = true;
            this.btnDescuento.Click += new System.EventHandler(this.btnDescuento_Click);
            // 
            // btnTiempo
            // 
            this.btnTiempo.Location = new System.Drawing.Point(414, 188);
            this.btnTiempo.Name = "btnTiempo";
            this.btnTiempo.Size = new System.Drawing.Size(90, 51);
            this.btnTiempo.TabIndex = 44;
            this.btnTiempo.Text = "Tiempo";
            this.btnTiempo.UseVisualStyleBackColor = true;
            this.btnTiempo.Click += new System.EventHandler(this.btnTiempo_Click);
            // 
            // txtTiempo
            // 
            this.txtTiempo.DecimalPlaces = 2;
            this.txtTiempo.Location = new System.Drawing.Point(224, 83);
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
            this.txtTiempo.Size = new System.Drawing.Size(187, 20);
            this.txtTiempo.TabIndex = 42;
            this.txtTiempo.ThousandsSeparator = true;
            this.txtTiempo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtTasaDescuento
            // 
            this.txtTasaDescuento.DecimalPlaces = 2;
            this.txtTasaDescuento.Location = new System.Drawing.Point(224, 121);
            this.txtTasaDescuento.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtTasaDescuento.Name = "txtTasaDescuento";
            this.txtTasaDescuento.Size = new System.Drawing.Size(187, 20);
            this.txtTasaDescuento.TabIndex = 41;
            this.txtTasaDescuento.ThousandsSeparator = true;
            this.txtTasaDescuento.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtDescuentoBancario
            // 
            this.txtDescuentoBancario.DecimalPlaces = 2;
            this.txtDescuentoBancario.Location = new System.Drawing.Point(224, 11);
            this.txtDescuentoBancario.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtDescuentoBancario.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtDescuentoBancario.Name = "txtDescuentoBancario";
            this.txtDescuentoBancario.Size = new System.Drawing.Size(187, 20);
            this.txtDescuentoBancario.TabIndex = 40;
            this.txtDescuentoBancario.ThousandsSeparator = true;
            this.txtDescuentoBancario.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtSumaSolicitada
            // 
            this.txtSumaSolicitada.DecimalPlaces = 2;
            this.txtSumaSolicitada.Location = new System.Drawing.Point(224, 47);
            this.txtSumaSolicitada.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtSumaSolicitada.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtSumaSolicitada.Name = "txtSumaSolicitada";
            this.txtSumaSolicitada.Size = new System.Drawing.Size(187, 20);
            this.txtSumaSolicitada.TabIndex = 39;
            this.txtSumaSolicitada.ThousandsSeparator = true;
            this.txtSumaSolicitada.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 38;
            this.label6.Text = "Meses";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(118, 83);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(67, 21);
            this.lblTiempo.TabIndex = 37;
            this.lblTiempo.Text = "Tiempo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 21);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tasa de Descuento = d%";
            // 
            // lblcapital
            // 
            this.lblcapital.AutoSize = true;
            this.lblcapital.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcapital.Location = new System.Drawing.Point(31, 45);
            this.lblcapital.Name = "lblcapital";
            this.lblcapital.Size = new System.Drawing.Size(162, 21);
            this.lblcapital.TabIndex = 35;
            this.lblcapital.Text = "Suma Solicitada = S";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 21);
            this.label2.TabIndex = 34;
            this.label2.Text = "Descuento Bancario = D";
            // 
            // panelResultado
            // 
            this.panelResultado.Controls.Add(this.txtResultado);
            this.panelResultado.Controls.Add(this.label4);
            this.panelResultado.Location = new System.Drawing.Point(33, 242);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(471, 56);
            this.panelResultado.TabIndex = 51;
            this.panelResultado.Visible = false;
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.SystemColors.Info;
            this.txtResultado.DecimalPlaces = 2;
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(184, 11);
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
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 50;
            this.label4.Text = "Resultado";
            // 
            // frmDescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.cbDescuentoSimple);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelCampos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDescuentos";
            this.Text = "frmDescuentos";
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasaDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescuentoBancario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSumaSolicitada)).EndInit();
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtResultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDescuentoSimple;
        private System.Windows.Forms.Panel panelCampos;
        private System.Windows.Forms.NumericUpDown txtTiempo;
        private System.Windows.Forms.NumericUpDown txtTasaDescuento;
        private System.Windows.Forms.NumericUpDown txtDescuentoBancario;
        private System.Windows.Forms.NumericUpDown txtSumaSolicitada;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcapital;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDescuento;
        private System.Windows.Forms.Button btnTiempo;
        private System.Windows.Forms.Button btnTasaDescuento;
        private System.Windows.Forms.Button btnSumaSolicitada;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.NumericUpDown txtResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTipoTasa;
    }
}