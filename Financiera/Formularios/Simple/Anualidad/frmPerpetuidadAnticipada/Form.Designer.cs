namespace Financiera.Formularios.Simple.Anualidad.frmPerpetuidadAnticipada
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
            this.groupBoxOpciones = new System.Windows.Forms.GroupBox();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.cbPerpetuidadAnticipada = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelResultante = new System.Windows.Forms.Panel();
            this.groupBoxOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOpciones
            // 
            this.groupBoxOpciones.Controls.Add(this.radioButtonB);
            this.groupBoxOpciones.Controls.Add(this.radioButtonA);
            this.groupBoxOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOpciones.Location = new System.Drawing.Point(198, 119);
            this.groupBoxOpciones.Name = "groupBoxOpciones";
            this.groupBoxOpciones.Size = new System.Drawing.Size(135, 57);
            this.groupBoxOpciones.TabIndex = 42;
            this.groupBoxOpciones.TabStop = false;
            this.groupBoxOpciones.Text = "Opción";
            this.groupBoxOpciones.Visible = false;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonB.Location = new System.Drawing.Point(87, 27);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(38, 24);
            this.radioButtonB.TabIndex = 3;
            this.radioButtonB.Text = "B";
            this.radioButtonB.UseVisualStyleBackColor = true;
            this.radioButtonB.CheckedChanged += new System.EventHandler(this.radioButtonB_CheckedChanged);
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonA.Location = new System.Drawing.Point(21, 27);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(38, 24);
            this.radioButtonA.TabIndex = 2;
            this.radioButtonA.Text = "A";
            this.radioButtonA.UseVisualStyleBackColor = true;
            this.radioButtonA.CheckedChanged += new System.EventHandler(this.radioButtonA_CheckedChanged);
            // 
            // cbPerpetuidadAnticipada
            // 
            this.cbPerpetuidadAnticipada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPerpetuidadAnticipada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPerpetuidadAnticipada.FormattingEnabled = true;
            this.cbPerpetuidadAnticipada.Items.AddRange(new object[] {
            "Renta",
            "Tasa Periódica",
            "Valor Actual"});
            this.cbPerpetuidadAnticipada.Location = new System.Drawing.Point(252, 74);
            this.cbPerpetuidadAnticipada.Name = "cbPerpetuidadAnticipada";
            this.cbPerpetuidadAnticipada.Size = new System.Drawing.Size(244, 28);
            this.cbPerpetuidadAnticipada.TabIndex = 39;
            this.cbPerpetuidadAnticipada.SelectedIndexChanged += new System.EventHandler(this.cbPerpetuidadAnticipada_SelectedIndexChanged);
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
            this.lblTitulo.Size = new System.Drawing.Size(270, 31);
            this.lblTitulo.TabIndex = 40;
            this.lblTitulo.Text = "Perpetuidad Anticipada";
            // 
            // panelResultante
            // 
            this.panelResultante.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelResultante.Location = new System.Drawing.Point(0, 182);
            this.panelResultante.Name = "panelResultante";
            this.panelResultante.Size = new System.Drawing.Size(742, 272);
            this.panelResultante.TabIndex = 43;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 454);
            this.Controls.Add(this.groupBoxOpciones);
            this.Controls.Add(this.cbPerpetuidadAnticipada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.panelResultante);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "frmPerpetuidadAnticipada";
            this.groupBoxOpciones.ResumeLayout(false);
            this.groupBoxOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOpciones;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.ComboBox cbPerpetuidadAnticipada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelResultante;
    }
}