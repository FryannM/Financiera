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
            this.BtnInteresSimple = new System.Windows.Forms.Button();
            this.BtnDescuentos = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnInteresSimple
            // 
            this.BtnInteresSimple.Location = new System.Drawing.Point(72, 70);
            this.BtnInteresSimple.Name = "BtnInteresSimple";
            this.BtnInteresSimple.Size = new System.Drawing.Size(195, 80);
            this.BtnInteresSimple.TabIndex = 0;
            this.BtnInteresSimple.Text = "Interes Simple";
            this.BtnInteresSimple.UseVisualStyleBackColor = true;
            this.BtnInteresSimple.Click += new System.EventHandler(this.BtnInteresSimple_Click);
            // 
            // BtnDescuentos
            // 
            this.BtnDescuentos.Location = new System.Drawing.Point(289, 70);
            this.BtnDescuentos.Name = "BtnDescuentos";
            this.BtnDescuentos.Size = new System.Drawing.Size(195, 80);
            this.BtnDescuentos.TabIndex = 1;
            this.BtnDescuentos.Text = "Descuentos";
            this.BtnDescuentos.UseVisualStyleBackColor = true;
            this.BtnDescuentos.Click += new System.EventHandler(this.BtnDescuentos_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(825, 475);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(195, 80);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 567);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.BtnDescuentos);
            this.Controls.Add(this.BtnInteresSimple);
            this.Name = "frmPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Financiera";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnInteresSimple;
        private System.Windows.Forms.Button BtnDescuentos;
        private System.Windows.Forms.Button btnExit;
    }
}

