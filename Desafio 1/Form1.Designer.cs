namespace Desafio_1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtcap = new System.Windows.Forms.TextBox();
            this.lblcap = new System.Windows.Forms.Label();
            this.lblinte = new System.Windows.Forms.Label();
            this.txtinte = new System.Windows.Forms.TextBox();
            this.lblperi = new System.Windows.Forms.Label();
            this.txtperi = new System.Windows.Forms.TextBox();
            this.btmcalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcap
            // 
            this.txtcap.Location = new System.Drawing.Point(12, 42);
            this.txtcap.Name = "txtcap";
            this.txtcap.Size = new System.Drawing.Size(100, 20);
            this.txtcap.TabIndex = 0;
            // 
            // lblcap
            // 
            this.lblcap.AutoSize = true;
            this.lblcap.Location = new System.Drawing.Point(9, 26);
            this.lblcap.Name = "lblcap";
            this.lblcap.Size = new System.Drawing.Size(69, 13);
            this.lblcap.TabIndex = 1;
            this.lblcap.Text = "Capital Inicial";
            // 
            // lblinte
            // 
            this.lblinte.AutoSize = true;
            this.lblinte.Location = new System.Drawing.Point(9, 65);
            this.lblinte.Name = "lblinte";
            this.lblinte.Size = new System.Drawing.Size(50, 13);
            this.lblinte.TabIndex = 2;
            this.lblinte.Text = "Interes %";
            // 
            // txtinte
            // 
            this.txtinte.Location = new System.Drawing.Point(13, 82);
            this.txtinte.Name = "txtinte";
            this.txtinte.Size = new System.Drawing.Size(100, 20);
            this.txtinte.TabIndex = 3;
            // 
            // lblperi
            // 
            this.lblperi.AutoSize = true;
            this.lblperi.Location = new System.Drawing.Point(12, 109);
            this.lblperi.Name = "lblperi";
            this.lblperi.Size = new System.Drawing.Size(84, 13);
            this.lblperi.TabIndex = 4;
            this.lblperi.Text = "Periodo en años";
            // 
            // txtperi
            // 
            this.txtperi.Location = new System.Drawing.Point(12, 126);
            this.txtperi.Name = "txtperi";
            this.txtperi.Size = new System.Drawing.Size(100, 20);
            this.txtperi.TabIndex = 5;
            // 
            // btmcalc
            // 
            this.btmcalc.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btmcalc.Location = new System.Drawing.Point(12, 153);
            this.btmcalc.Name = "btmcalc";
            this.btmcalc.Size = new System.Drawing.Size(100, 46);
            this.btmcalc.TabIndex = 6;
            this.btmcalc.Text = "Calcular";
            this.btmcalc.UseVisualStyleBackColor = false;
            this.btmcalc.Click += new System.EventHandler(this.btmcalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btmcalc);
            this.Controls.Add(this.txtperi);
            this.Controls.Add(this.lblperi);
            this.Controls.Add(this.txtinte);
            this.Controls.Add(this.lblinte);
            this.Controls.Add(this.lblcap);
            this.Controls.Add(this.txtcap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcap;
        private System.Windows.Forms.Label lblcap;
        private System.Windows.Forms.Label lblinte;
        private System.Windows.Forms.TextBox txtinte;
        private System.Windows.Forms.Label lblperi;
        private System.Windows.Forms.TextBox txtperi;
        private System.Windows.Forms.Button btmcalc;
    }
}

