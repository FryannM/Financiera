namespace Financiera.Formularios.Simple.Anualidad.frmPerpetuidadVencidaPagadera
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
            this.cbAnualidadPerpetuaPagadera = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelResultante = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cbAnualidadPerpetuaPagadera
            // 
            this.cbAnualidadPerpetuaPagadera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnualidadPerpetuaPagadera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAnualidadPerpetuaPagadera.FormattingEnabled = true;
            this.cbAnualidadPerpetuaPagadera.Items.AddRange(new object[] {
            "Renta",
            "Valor Actual"});
            this.cbAnualidadPerpetuaPagadera.Location = new System.Drawing.Point(252, 74);
            this.cbAnualidadPerpetuaPagadera.Name = "cbAnualidadPerpetuaPagadera";
            this.cbAnualidadPerpetuaPagadera.Size = new System.Drawing.Size(244, 28);
            this.cbAnualidadPerpetuaPagadera.TabIndex = 39;
            this.cbAnualidadPerpetuaPagadera.SelectedIndexChanged += new System.EventHandler(this.cbAnualidadPerpetuaPagadera_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "¿Qué Desea Calcular?";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(57, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(595, 31);
            this.lblTitulo.TabIndex = 40;
            this.lblTitulo.Text = "Anualidad con Perpetuidad Vencida Simple Pagadera";
            // 
            // panelResultante
            // 
            this.panelResultante.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelResultante.Location = new System.Drawing.Point(0, 114);
            this.panelResultante.Name = "panelResultante";
            this.panelResultante.Size = new System.Drawing.Size(729, 272);
            this.panelResultante.TabIndex = 43;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 386);
            this.Controls.Add(this.cbAnualidadPerpetuaPagadera);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelResultante);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "frmPerpetuidadVencidaPagadera";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbAnualidadPerpetuaPagadera;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelResultante;
    }
}