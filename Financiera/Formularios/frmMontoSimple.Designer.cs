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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMontoSimple));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMontoSimple = new System.Windows.Forms.ComboBox();
            this.panelCampos = new System.Windows.Forms.Panel();
            this.txtInteres = new System.Windows.Forms.NumericUpDown();
            this.txtMonto = new System.Windows.Forms.NumericUpDown();
            this.txtCapital = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcapital = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInteres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapital)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(39, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(171, 31);
            this.lblTitulo.TabIndex = 30;
            this.lblTitulo.Text = "Monto Simple";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 21);
            this.label3.TabIndex = 44;
            this.label3.Text = "¿Qué Desea Calcular?";
            // 
            // cbMontoSimple
            // 
            this.cbMontoSimple.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMontoSimple.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMontoSimple.FormattingEnabled = true;
            this.cbMontoSimple.Items.AddRange(new object[] {
            "Capital",
            "Interes",
            "Monto"});
            this.cbMontoSimple.Location = new System.Drawing.Point(194, 80);
            this.cbMontoSimple.Name = "cbMontoSimple";
            this.cbMontoSimple.Size = new System.Drawing.Size(187, 28);
            this.cbMontoSimple.TabIndex = 45;
            this.cbMontoSimple.SelectedIndexChanged += new System.EventHandler(this.cbMontoSimple_SelectedIndexChanged);
            // 
            // panelCampos
            // 
            this.panelCampos.Controls.Add(this.txtInteres);
            this.panelCampos.Controls.Add(this.txtMonto);
            this.panelCampos.Controls.Add(this.txtCapital);
            this.panelCampos.Controls.Add(this.label1);
            this.panelCampos.Controls.Add(this.lblcapital);
            this.panelCampos.Controls.Add(this.label2);
            this.panelCampos.Location = new System.Drawing.Point(23, 123);
            this.panelCampos.Name = "panelCampos";
            this.panelCampos.Size = new System.Drawing.Size(371, 187);
            this.panelCampos.TabIndex = 46;
            this.panelCampos.Visible = false;
            // 
            // txtInteres
            // 
            this.txtInteres.DecimalPlaces = 2;
            this.txtInteres.Location = new System.Drawing.Point(171, 68);
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
            this.txtInteres.TabIndex = 58;
            this.txtInteres.ThousandsSeparator = true;
            this.txtInteres.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtMonto
            // 
            this.txtMonto.DecimalPlaces = 2;
            this.txtMonto.Location = new System.Drawing.Point(171, 9);
            this.txtMonto.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.txtMonto.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(187, 20);
            this.txtMonto.TabIndex = 57;
            this.txtMonto.ThousandsSeparator = true;
            this.txtMonto.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtCapital
            // 
            this.txtCapital.DecimalPlaces = 2;
            this.txtCapital.Location = new System.Drawing.Point(171, 37);
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
            this.txtCapital.TabIndex = 56;
            this.txtCapital.ThousandsSeparator = true;
            this.txtCapital.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 55;
            this.label1.Text = "Interes = I";
            // 
            // lblcapital
            // 
            this.lblcapital.AutoSize = true;
            this.lblcapital.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcapital.Location = new System.Drawing.Point(19, 36);
            this.lblcapital.Name = "lblcapital";
            this.lblcapital.Size = new System.Drawing.Size(94, 21);
            this.lblcapital.TabIndex = 54;
            this.lblcapital.Text = "Capital = P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 21);
            this.label2.TabIndex = 53;
            this.label2.Text = "Monto = S";
            // 
            // frmMontoSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 371);
            this.Controls.Add(this.cbMontoSimple);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelCampos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMontoSimple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MontoSimple";
            this.panelCampos.ResumeLayout(false);
            this.panelCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtInteres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMonto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCapital)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMontoSimple;
        private System.Windows.Forms.Panel panelCampos;
        private System.Windows.Forms.NumericUpDown txtInteres;
        private System.Windows.Forms.NumericUpDown txtMonto;
        private System.Windows.Forms.NumericUpDown txtCapital;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcapital;
        private System.Windows.Forms.Label label2;
    }
}