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
            this.label3 = new System.Windows.Forms.Label();
            this.cbDescuento = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcapital = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTasaDescuento = new System.Windows.Forms.TextBox();
            this.txtSumaSolicitada = new System.Windows.Forms.TextBox();
            this.txtDescuentoBancario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Que Desea Calcular?";
            // 
            // cbDescuento
            // 
            this.cbDescuento.FormattingEnabled = true;
            this.cbDescuento.Items.AddRange(new object[] {
            "Descuento Bancario",
            "Suma Solicitada",
            "Tasa Descuento",
            "Tiempo"});
            this.cbDescuento.Location = new System.Drawing.Point(251, 115);
            this.cbDescuento.Name = "cbDescuento";
            this.cbDescuento.Size = new System.Drawing.Size(187, 21);
            this.cbDescuento.TabIndex = 10;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(444, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 21);
            this.label6.TabIndex = 29;
            this.label6.Text = "Meses";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempo.Location = new System.Drawing.Point(58, 324);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(67, 21);
            this.lblTiempo.TabIndex = 28;
            this.lblTiempo.Text = "Tiempo";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(251, 322);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(187, 20);
            this.txtTiempo.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 21);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tasa de Descuento = d";
            // 
            // lblcapital
            // 
            this.lblcapital.AutoSize = true;
            this.lblcapital.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcapital.Location = new System.Drawing.Point(58, 201);
            this.lblcapital.Name = "lblcapital";
            this.lblcapital.Size = new System.Drawing.Size(162, 21);
            this.lblcapital.TabIndex = 25;
            this.lblcapital.Text = "Suma Solicitada = S";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "Decuento Bancario = D";
            // 
            // txtTasaDescuento
            // 
            this.txtTasaDescuento.Location = new System.Drawing.Point(251, 239);
            this.txtTasaDescuento.Name = "txtTasaDescuento";
            this.txtTasaDescuento.Size = new System.Drawing.Size(187, 20);
            this.txtTasaDescuento.TabIndex = 23;
            // 
            // txtSumaSolicitada
            // 
            this.txtSumaSolicitada.Location = new System.Drawing.Point(251, 199);
            this.txtSumaSolicitada.Name = "txtSumaSolicitada";
            this.txtSumaSolicitada.Size = new System.Drawing.Size(187, 20);
            this.txtSumaSolicitada.TabIndex = 22;
            // 
            // txtDescuentoBancario
            // 
            this.txtDescuentoBancario.Location = new System.Drawing.Point(251, 166);
            this.txtDescuentoBancario.Name = "txtDescuentoBancario";
            this.txtDescuentoBancario.Size = new System.Drawing.Size(187, 20);
            this.txtDescuentoBancario.TabIndex = 21;
            // 
            // frmDescuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcapital);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTasaDescuento);
            this.Controls.Add(this.txtSumaSolicitada);
            this.Controls.Add(this.txtDescuentoBancario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDescuento);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDescuentos";
            this.Text = "frmDescuentos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDescuento;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcapital;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTasaDescuento;
        private System.Windows.Forms.TextBox txtSumaSolicitada;
        private System.Windows.Forms.TextBox txtDescuentoBancario;
    }
}