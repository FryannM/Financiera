namespace Financiera.Formularios.Compuesto.Interes
{
    partial class View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbInteresCompuesto = new System.Windows.Forms.ComboBox();
            this.groupBoxOpciones = new System.Windows.Forms.GroupBox();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.panelResultante = new System.Windows.Forms.Panel();
            this.groupBoxOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(57, 52);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(218, 31);
            this.lblTitulo.TabIndex = 9;
            this.lblTitulo.Text = "Interés Compuesto";
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
            // cbInteresCompuesto
            // 
            this.cbInteresCompuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInteresCompuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInteresCompuesto.FormattingEnabled = true;
            this.cbInteresCompuesto.Items.AddRange(new object[] {
            "Capital",
            "Interés",
            "Monto",
            "Número total de períodos",
            "Tasa de interés por período",
            "Tasa nominal",
            "Tiempo"});
            this.cbInteresCompuesto.Location = new System.Drawing.Point(252, 100);
            this.cbInteresCompuesto.Name = "cbInteresCompuesto";
            this.cbInteresCompuesto.Size = new System.Drawing.Size(244, 28);
            this.cbInteresCompuesto.TabIndex = 1;
            this.cbInteresCompuesto.SelectedIndexChanged += new System.EventHandler(this.cbInteresCompuesto_SelectedIndexChanged);
            // 
            // groupBoxOpciones
            // 
            this.groupBoxOpciones.Controls.Add(this.radioButtonC);
            this.groupBoxOpciones.Controls.Add(this.radioButtonB);
            this.groupBoxOpciones.Controls.Add(this.radioButtonA);
            this.groupBoxOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOpciones.Location = new System.Drawing.Point(175, 154);
            this.groupBoxOpciones.Name = "groupBoxOpciones";
            this.groupBoxOpciones.Size = new System.Drawing.Size(200, 57);
            this.groupBoxOpciones.TabIndex = 37;
            this.groupBoxOpciones.TabStop = false;
            this.groupBoxOpciones.Text = "Opción";
            this.groupBoxOpciones.Visible = false;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Enabled = false;
            this.radioButtonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonC.Location = new System.Drawing.Point(150, 27);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(38, 24);
            this.radioButtonC.TabIndex = 4;
            this.radioButtonC.Text = "C";
            this.radioButtonC.UseVisualStyleBackColor = true;
            this.radioButtonC.CheckedChanged += new System.EventHandler(this.radioButtonC_CheckedChanged);
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
            // panelResultante
            // 
            this.panelResultante.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelResultante.Location = new System.Drawing.Point(0, 221);
            this.panelResultante.Name = "panelResultante";
            this.panelResultante.Size = new System.Drawing.Size(742, 272);
            this.panelResultante.TabIndex = 38;
            // 
            // frmInteresCompuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 493);
            this.Controls.Add(this.panelResultante);
            this.Controls.Add(this.groupBoxOpciones);
            this.Controls.Add(this.cbInteresCompuesto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInteresCompuesto";
            this.Text = "frmInteresCompuesto";
            this.groupBoxOpciones.ResumeLayout(false);
            this.groupBoxOpciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbInteresCompuesto;
        private System.Windows.Forms.GroupBox groupBoxOpciones;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.Panel panelResultante;
    }
}