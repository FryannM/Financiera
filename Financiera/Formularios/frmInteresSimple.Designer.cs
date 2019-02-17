namespace Financiera.Formularios
{
    partial class frmInteresSimple
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInteresSimple));
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.txtTasaInteres = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblcapital = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbInteresSimple = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.btnCapital = new System.Windows.Forms.Button();
            this.btnTasaInteres = new System.Windows.Forms.Button();
            this.btnTiempo = new System.Windows.Forms.Button();
            this.btnInteres = new System.Windows.Forms.Button();
            this.cbTipoTasa = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInteres
            // 
            this.txtInteres.Location = new System.Drawing.Point(244, 141);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(187, 20);
            this.txtInteres.TabIndex = 0;
            this.txtInteres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInteres_KeyPress);
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(244, 174);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(187, 20);
            this.txtCapital.TabIndex = 1;
            this.txtCapital.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapital_KeyPress);
            // 
            // txtTasaInteres
            // 
            this.txtTasaInteres.Location = new System.Drawing.Point(244, 236);
            this.txtTasaInteres.Name = "txtTasaInteres";
            this.txtTasaInteres.Size = new System.Drawing.Size(187, 20);
            this.txtTasaInteres.TabIndex = 2;
            this.txtTasaInteres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTasaInteres_KeyPress);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Interes = I";
            // 
            // lblcapital
            // 
            this.lblcapital.AutoSize = true;
            this.lblcapital.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcapital.Location = new System.Drawing.Point(71, 176);
            this.lblcapital.Name = "lblcapital";
            this.lblcapital.Size = new System.Drawing.Size(94, 21);
            this.lblcapital.TabIndex = 5;
            this.lblcapital.Text = "Capital = P";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tasa de Interes = i %";
            // 
            // cbInteresSimple
            // 
            this.cbInteresSimple.FormattingEnabled = true;
            this.cbInteresSimple.Items.AddRange(new object[] {
            "Interes Simple",
            "Capital",
            "Tasa de Interes"});
            this.cbInteresSimple.Location = new System.Drawing.Point(244, 82);
            this.cbInteresSimple.Name = "cbInteresSimple";
            this.cbInteresSimple.Size = new System.Drawing.Size(187, 21);
            this.cbInteresSimple.TabIndex = 7;
            this.cbInteresSimple.SelectedIndexChanged += new System.EventHandler(this.cbInteresSimple_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Que Desea Calcular?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(244, 338);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(187, 20);
            this.txtResultado.TabIndex = 9;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(71, 212);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(67, 21);
            this.lblTiempo.TabIndex = 12;
            this.lblTiempo.Text = "Tiempo";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(244, 210);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(187, 20);
            this.txtTiempo.TabIndex = 11;
            this.txtTiempo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTiempo_KeyPress);
            // 
            // btnCapital
            // 
            this.btnCapital.Location = new System.Drawing.Point(66, 394);
            this.btnCapital.Name = "btnCapital";
            this.btnCapital.Size = new System.Drawing.Size(90, 51);
            this.btnCapital.TabIndex = 14;
            this.btnCapital.Text = "Capital";
            this.btnCapital.UseVisualStyleBackColor = true;
            this.btnCapital.Click += new System.EventHandler(this.btnCapital_Click);
            // 
            // btnTasaInteres
            // 
            this.btnTasaInteres.Location = new System.Drawing.Point(66, 394);
            this.btnTasaInteres.Name = "btnTasaInteres";
            this.btnTasaInteres.Size = new System.Drawing.Size(90, 51);
            this.btnTasaInteres.TabIndex = 15;
            this.btnTasaInteres.Text = "Tasa Interes";
            this.btnTasaInteres.UseVisualStyleBackColor = true;
            this.btnTasaInteres.Click += new System.EventHandler(this.btnTasaInteres_Click);
            // 
            // btnTiempo
            // 
            this.btnTiempo.Location = new System.Drawing.Point(68, 394);
            this.btnTiempo.Name = "btnTiempo";
            this.btnTiempo.Size = new System.Drawing.Size(90, 51);
            this.btnTiempo.TabIndex = 16;
            this.btnTiempo.Text = "Tiempo";
            this.btnTiempo.UseVisualStyleBackColor = true;
            // 
            // btnInteres
            // 
            this.btnInteres.Location = new System.Drawing.Point(68, 394);
            this.btnInteres.Name = "btnInteres";
            this.btnInteres.Size = new System.Drawing.Size(90, 51);
            this.btnInteres.TabIndex = 17;
            this.btnInteres.Text = "Interes";
            this.btnInteres.UseVisualStyleBackColor = true;
            this.btnInteres.Click += new System.EventHandler(this.btnInteres_Click);
            // 
            // cbTipoTasa
            // 
            this.cbTipoTasa.FormattingEnabled = true;
            this.cbTipoTasa.Items.AddRange(new object[] {
            "Mensual",
            "Bimestral",
            "Trimestral",
            "Cuatrimestral",
            "Semestral",
            "Anual"});
            this.cbTipoTasa.Location = new System.Drawing.Point(244, 277);
            this.cbTipoTasa.Name = "cbTipoTasa";
            this.cbTipoTasa.Size = new System.Drawing.Size(187, 21);
            this.cbTipoTasa.TabIndex = 18;
            this.cbTipoTasa.SelectedIndexChanged += new System.EventHandler(this.cbTipoTasa_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tasa en ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(437, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "Meses";
            // 
            // frmInteresSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 496);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTipoTasa);
            this.Controls.Add(this.btnInteres);
            this.Controls.Add(this.btnTiempo);
            this.Controls.Add(this.btnTasaInteres);
            this.Controls.Add(this.btnCapital);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbInteresSimple);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcapital);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTasaInteres);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.txtInteres);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInteresSimple";
            this.Text = "InteresSimple";
            this.Load += new System.EventHandler(this.frmInteresSimple_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.TextBox txtTasaInteres;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblcapital;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbInteresSimple;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Button btnCapital;
        private System.Windows.Forms.Button btnTasaInteres;
        private System.Windows.Forms.Button btnTiempo;
        private System.Windows.Forms.Button btnInteres;
        private System.Windows.Forms.ComboBox cbTipoTasa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}