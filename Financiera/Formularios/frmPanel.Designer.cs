namespace Financiera
{
    partial class frmPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPanel));
            this.BtnInteresSimple = new System.Windows.Forms.Button();
            this.BtnDescuentos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMontoSimple = new System.Windows.Forms.Button();
            this.btnInteresCompuesto = new System.Windows.Forms.Button();
            this.btnPerpetuidadVencidaPagadera = new System.Windows.Forms.Button();
            this.btnPerpetuidadVencida = new System.Windows.Forms.Button();
            this.btnPerpetualidadAnticipada = new System.Windows.Forms.Button();
            this.btnAnticipada = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnVencida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnInteresSimple
            // 
            this.BtnInteresSimple.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnInteresSimple.Location = new System.Drawing.Point(171, 174);
            this.BtnInteresSimple.Name = "BtnInteresSimple";
            this.BtnInteresSimple.Size = new System.Drawing.Size(195, 80);
            this.BtnInteresSimple.TabIndex = 0;
            this.BtnInteresSimple.Text = "Interes Simple";
            this.BtnInteresSimple.UseVisualStyleBackColor = true;
            this.BtnInteresSimple.Click += new System.EventHandler(this.BtnInteresSimple_Click);
            // 
            // BtnDescuentos
            // 
            this.BtnDescuentos.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnDescuentos.Location = new System.Drawing.Point(388, 174);
            this.BtnDescuentos.Name = "BtnDescuentos";
            this.BtnDescuentos.Size = new System.Drawing.Size(195, 80);
            this.BtnDescuentos.TabIndex = 1;
            this.BtnDescuentos.Text = "Descuentos";
            this.BtnDescuentos.UseVisualStyleBackColor = true;
            this.BtnDescuentos.Click += new System.EventHandler(this.BtnDescuentos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Matematica Financiera 1430";
            // 
            // btnMontoSimple
            // 
            this.btnMontoSimple.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnMontoSimple.Location = new System.Drawing.Point(171, 260);
            this.btnMontoSimple.Name = "btnMontoSimple";
            this.btnMontoSimple.Size = new System.Drawing.Size(195, 80);
            this.btnMontoSimple.TabIndex = 5;
            this.btnMontoSimple.Text = "Monto Simple";
            this.btnMontoSimple.UseVisualStyleBackColor = true;
            this.btnMontoSimple.Click += new System.EventHandler(this.btnMontoSimple_Click);
            // 
            // btnInteresCompuesto
            // 
            this.btnInteresCompuesto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnInteresCompuesto.Location = new System.Drawing.Point(388, 260);
            this.btnInteresCompuesto.Name = "btnInteresCompuesto";
            this.btnInteresCompuesto.Size = new System.Drawing.Size(195, 80);
            this.btnInteresCompuesto.TabIndex = 6;
            this.btnInteresCompuesto.Text = "Interes Compuesto";
            this.btnInteresCompuesto.UseVisualStyleBackColor = true;
            this.btnInteresCompuesto.Click += new System.EventHandler(this.btnInteresCompuesto_Click);
            // 
            // btnPerpetuidadVencidaPagadera
            // 
            this.btnPerpetuidadVencidaPagadera.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPerpetuidadVencidaPagadera.Location = new System.Drawing.Point(605, 346);
            this.btnPerpetuidadVencidaPagadera.Name = "btnPerpetuidadVencidaPagadera";
            this.btnPerpetuidadVencidaPagadera.Size = new System.Drawing.Size(195, 80);
            this.btnPerpetuidadVencidaPagadera.TabIndex = 7;
            this.btnPerpetuidadVencidaPagadera.Text = "Anualidad con Perpetuidad Vencida Pagadera";
            this.btnPerpetuidadVencidaPagadera.UseVisualStyleBackColor = true;
            this.btnPerpetuidadVencidaPagadera.Click += new System.EventHandler(this.btnPerpetuidadVencidaPagadera_Click);
            // 
            // btnPerpetuidadVencida
            // 
            this.btnPerpetuidadVencida.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPerpetuidadVencida.Location = new System.Drawing.Point(605, 260);
            this.btnPerpetuidadVencida.Name = "btnPerpetuidadVencida";
            this.btnPerpetuidadVencida.Size = new System.Drawing.Size(195, 80);
            this.btnPerpetuidadVencida.TabIndex = 7;
            this.btnPerpetuidadVencida.Text = "Anualidad con Perpetuidad Vencida";
            this.btnPerpetuidadVencida.UseVisualStyleBackColor = true;
            this.btnPerpetuidadVencida.Click += new System.EventHandler(this.btnPerpetuidadVencida_Click);
            // 
            // btnPerpetualidadAnticipada
            // 
            this.btnPerpetualidadAnticipada.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPerpetualidadAnticipada.Location = new System.Drawing.Point(605, 174);
            this.btnPerpetualidadAnticipada.Name = "btnPerpetualidadAnticipada";
            this.btnPerpetualidadAnticipada.Size = new System.Drawing.Size(195, 80);
            this.btnPerpetualidadAnticipada.TabIndex = 7;
            this.btnPerpetualidadAnticipada.Text = "Anualidad con Perpetuidad Anticipada";
            this.btnPerpetualidadAnticipada.UseVisualStyleBackColor = true;
            this.btnPerpetualidadAnticipada.Click += new System.EventHandler(this.btnPerpetualidadAnticipada_Click);
            // 
            // btnAnticipada
            // 
            this.btnAnticipada.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnticipada.Location = new System.Drawing.Point(171, 346);
            this.btnAnticipada.Name = "btnAnticipada";
            this.btnAnticipada.Size = new System.Drawing.Size(195, 80);
            this.btnAnticipada.TabIndex = 7;
            this.btnAnticipada.Text = "Anualidad Anticipada Simple";
            this.btnAnticipada.UseVisualStyleBackColor = true;
            this.btnAnticipada.Click += new System.EventHandler(this.btnAnticipada_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.LightCyan;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnExit.Image = global::Financiera.Properties.Resources.exit;
            this.btnExit.Location = new System.Drawing.Point(869, 456);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExit.Size = new System.Drawing.Size(113, 99);
            this.btnExit.TabIndex = 2;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnVencida
            // 
            this.btnVencida.Location = new System.Drawing.Point(388, 346);
            this.btnVencida.Name = "btnVencida";
            this.btnVencida.Size = new System.Drawing.Size(195, 80);
            this.btnVencida.TabIndex = 7;
            this.btnVencida.Text = "Anualidad Vencida Simple";
            this.btnVencida.UseVisualStyleBackColor = true;
            this.btnVencida.Click += new System.EventHandler(this.btnVencida_Click);
            // 
            // frmPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1018, 567);
            this.Controls.Add(this.btnPerpetuidadVencida);
            this.Controls.Add(this.btnPerpetuidadVencidaPagadera);
            this.Controls.Add(this.btnPerpetualidadAnticipada);
            this.Controls.Add(this.btnAnticipada);
            this.Controls.Add(this.btnVencida);
            this.Controls.Add(this.btnInteresCompuesto);
            this.Controls.Add(this.btnMontoSimple);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.BtnDescuentos);
            this.Controls.Add(this.BtnInteresSimple);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPanel";
            this.Opacity = 0.97D;
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Financiera";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnInteresSimple;
        private System.Windows.Forms.Button BtnDescuentos;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMontoSimple;
        private System.Windows.Forms.Button btnInteresCompuesto;
        private System.Windows.Forms.Button btnPerpetuidadVencida;
        private System.Windows.Forms.Button btnPerpetuidadVencidaPagadera;
        private System.Windows.Forms.Button btnPerpetualidadAnticipada;
        private System.Windows.Forms.Button btnAnticipada;
        private System.Windows.Forms.Button btnVencida;
    }
}

