namespace Financiera.Formularios
{
    partial class frmMontoSimple
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblcapital = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDescuento = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Interes = I";
            // 
            // lblcapital
            // 
            this.lblcapital.AutoSize = true;
            this.lblcapital.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcapital.Location = new System.Drawing.Point(40, 217);
            this.lblcapital.Name = "lblcapital";
            this.lblcapital.Size = new System.Drawing.Size(94, 21);
            this.lblcapital.TabIndex = 37;
            this.lblcapital.Text = "Capital = P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 36;
            this.label2.Text = "Monto = S";
            // 
            // txtInteres
            // 
            this.txtInteres.Location = new System.Drawing.Point(233, 255);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(187, 20);
            this.txtInteres.TabIndex = 35;
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(233, 215);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(187, 20);
            this.txtCapital.TabIndex = 34;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(233, 182);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(187, 20);
            this.txtMonto.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 21);
            this.label3.TabIndex = 32;
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
            this.cbDescuento.Location = new System.Drawing.Point(233, 131);
            this.cbDescuento.Name = "cbDescuento";
            this.cbDescuento.Size = new System.Drawing.Size(187, 21);
            this.cbDescuento.TabIndex = 31;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(39, 68);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(171, 31);
            this.lblTitulo.TabIndex = 30;
            this.lblTitulo.Text = "Monto Simple";
            // 
            // frmMontoSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 428);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblcapital);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInteres);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbDescuento);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmMontoSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmMontoSimple";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcapital;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDescuento;
        private System.Windows.Forms.Label lblTitulo;
    }
}