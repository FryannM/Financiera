namespace Financiera.Formularios.Simple.frmInteres
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cbInteresSimple = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelCampos = new System.Windows.Forms.Panel();
            this.btnInteres = new System.Windows.Forms.Button();
            this.btnTiempo = new System.Windows.Forms.Button();
            this.btnTasaInteres = new System.Windows.Forms.Button();
            this.btnCapital = new System.Windows.Forms.Button();
            this.txtTiempo = new System.Windows.Forms.NumericUpDown();
            this.txtTasaInteres = new System.Windows.Forms.NumericUpDown();
            this.txtCapital = new System.Windows.Forms.NumericUpDown();
            this.txtInteres = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbTipoTasa = new System.Windows.Forms.ComboBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcapital = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTiempo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasaInteres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapital)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInteres)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(62, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(170, 31);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Interes Simple";
            // 
            // cbInteresSimple
            // 
            this.cbInteresSimple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInteresSimple.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInteresSimple.FormattingEnabled = true;
            this.cbInteresSimple.Items.AddRange(new object[] {
            "Interes Simple",
            "Capital",
            "Tasa de Interes",
            "Tiempo"});
            this.cbInteresSimple.Location = new System.Drawing.Point(244, 57);
            this.cbInteresSimple.Name = "cbInteresSimple";
            this.cbInteresSimple.Size = new System.Drawing.Size(187, 29);
            this.cbInteresSimple.TabIndex = 7;
            this.cbInteresSimple.SelectedIndexChanged += new System.EventHandler(this.cbInteresSimple_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "¿Qué Desea Calcular?";
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.btnInteres);
            this.panelCampos.Controls.Add(this.btnTiempo);
            this.panelCampos.Controls.Add(this.btnTasaInteres);
            this.panelCampos.Controls.Add(this.btnCapital);
            this.panelCampos.Controls.Add(this.txtTiempo);
            this.panelCampos.Controls.Add(this.txtTasaInteres);
            this.panelCampos.Controls.Add(this.txtCapital);
            this.panelCampos.Controls.Add(this.txtInteres);
            this.panelCampos.Controls.Add(this.label6);
            this.panelCampos.Controls.Add(this.label5);
            this.panelCampos.Controls.Add(this.cbTipoTasa);
            this.panelCampos.Controls.Add(this.lblTiempo);
            this.panelCampos.Controls.Add(this.label4);
            this.panelCampos.Controls.Add(this.txtResultado);
            this.panelCampos.Controls.Add(this.label1);
            this.panelCampos.Controls.Add(this.lblcapital);
            this.panelCampos.Controls.Add(this.label2);
            this.panelCampos.Location = new System.Drawing.Point(7, 98);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(516, 277);
            this.panelCampos.TabIndex = 24;
            this.panelCampos.Visible = false;
            // 
            // btnInteres
            // 
            this.btnInteres.Location = new System.Drawing.Point(401, 207);
            this.btnInteres.Name = "btnInteres";
            this.btnInteres.Size = new System.Drawing.Size(90, 51);
            this.btnInteres.TabIndex = 40;
            this.btnInteres.Text = "Interes";
            this.btnInteres.UseVisualStyleBackColor = true;
            this.btnInteres.Click += new System.EventHandler(this.btnInteres_Click);
            // 
            // btnTiempo
            // 
            this.btnTiempo.Location = new System.Drawing.Point(402, 207);
            this.btnTiempo.Name = "btnTiempo";
            this.btnTiempo.Size = new System.Drawing.Size(90, 51);
            this.btnTiempo.TabIndex = 39;
            this.btnTiempo.Text = "Tiempo";
            this.btnTiempo.UseVisualStyleBackColor = true;
            this.btnTiempo.Click += new System.EventHandler(this.btnTiempo_Click);
            // 
            // btnTasaInteres
            // 
            this.btnTasaInteres.Location = new System.Drawing.Point(403, 207);
            this.btnTasaInteres.Name = "btnTasaInteres";
            this.btnTasaInteres.Size = new System.Drawing.Size(90, 51);
            this.btnTasaInteres.TabIndex = 38;
            this.btnTasaInteres.Text = "Tasa Interes";
            this.btnTasaInteres.UseVisualStyleBackColor = true;
            this.btnTasaInteres.Click += new System.EventHandler(this.btnTasaInteres_Click);
            // 
            // btnCapital
            // 
            this.btnCapital.Location = new System.Drawing.Point(400, 207);
            this.btnCapital.Name = "btnCapital";
            this.btnCapital.Size = new System.Drawing.Size(90, 51);
            this.btnCapital.TabIndex = 37;
            this.btnCapital.Text = "Capital";
            this.btnCapital.UseVisualStyleBackColor = true;
            this.btnCapital.Click += new System.EventHandler(this.btnCapital_Click);
            // 
            // txtTiempo
            // 
            this.txtTiempo.DecimalPlaces = 2;
            this.txtTiempo.Location = new System.Drawing.Point(214, 85);
            this.txtTiempo.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.txtTiempo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(187, 20);
            this.txtTiempo.TabIndex = 36;
            this.txtTiempo.ThousandsSeparator = true;
            this.txtTiempo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtTasaInteres
            // 
            this.txtTasaInteres.DecimalPlaces = 2;
            this.txtTasaInteres.Location = new System.Drawing.Point(214, 112);
            this.txtTasaInteres.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.txtTasaInteres.Name = "txtTasaInteres";
            this.txtTasaInteres.Size = new System.Drawing.Size(187, 20);
            this.txtTasaInteres.TabIndex = 35;
            this.txtTasaInteres.ThousandsSeparator = true;
            this.txtTasaInteres.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtCapital
            // 
            this.txtCapital.DecimalPlaces = 2;
            this.txtCapital.Location = new System.Drawing.Point(214, 58);
            this.txtCapital.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtCapital.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(187, 20);
            this.txtCapital.TabIndex = 34;
            this.txtCapital.ThousandsSeparator = true;
            this.txtCapital.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtInteres
            // 
            this.txtInteres.DecimalPlaces = 2;
            this.txtInteres.Location = new System.Drawing.Point(214, 24);
            this.txtInteres.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtInteres.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(187, 20);
            this.txtInteres.TabIndex = 24;
            this.txtInteres.ThousandsSeparator = true;
            this.txtInteres.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(407, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 33;
            this.label6.Text = "Meses";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 32;
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
            "Quicenal"});
            this.cbTipoTasa.Location = new System.Drawing.Point(214, 140);
            this.cbTipoTasa.Name = "cbTipoTasa";
            this.cbTipoTasa.Size = new System.Drawing.Size(187, 21);
            this.cbTipoTasa.TabIndex = 31;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(45, 88);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(67, 21);
            this.lblTiempo.TabIndex = 30;
            this.lblTiempo.Text = "Tiempo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 29;
            this.label4.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(214, 169);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(187, 20);
            this.txtResultado.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "Tasa de Interes = i %";
            // 
            // lblcapital
            // 
            this.lblcapital.AutoSize = true;
            this.lblcapital.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcapital.Location = new System.Drawing.Point(45, 55);
            this.lblcapital.Name = "lblcapital";
            this.lblcapital.Size = new System.Drawing.Size(94, 21);
            this.lblcapital.TabIndex = 26;
            this.lblcapital.Text = "Capital = P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 25;
            this.label2.Text = "Interes = I";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 377);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbInteresSimple);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelCampos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InteresSimple";
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTiempo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTasaInteres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapital)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtInteres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cbInteresSimple;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelCampos;
        private System.Windows.Forms.NumericUpDown txtTiempo;
        private System.Windows.Forms.NumericUpDown txtTasaInteres;
        private System.Windows.Forms.NumericUpDown txtCapital;
        private System.Windows.Forms.NumericUpDown txtInteres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbTipoTasa;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcapital;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInteres;
        private System.Windows.Forms.Button btnTiempo;
        private System.Windows.Forms.Button btnTasaInteres;
        private System.Windows.Forms.Button btnCapital;
    }
}