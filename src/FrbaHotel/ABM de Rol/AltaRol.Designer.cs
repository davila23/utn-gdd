namespace FrbaHotel.ABM_de_Rol
{
    partial class AltaRol
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
            this.txtNomRol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cBFuncio = new System.Windows.Forms.ComboBox();
            this.btnCrearRol = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese nombre:";
            // 
            // txtNomRol
            // 
            this.txtNomRol.Location = new System.Drawing.Point(135, 10);
            this.txtNomRol.Name = "txtNomRol";
            this.txtNomRol.Size = new System.Drawing.Size(205, 21);
            this.txtNomRol.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Funcionalidades:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Estado:";
            // 
            // cBFuncio
            // 
            this.cBFuncio.FormattingEnabled = true;
            this.cBFuncio.Location = new System.Drawing.Point(135, 46);
            this.cBFuncio.Name = "cBFuncio";
            this.cBFuncio.Size = new System.Drawing.Size(205, 21);
            this.cBFuncio.TabIndex = 4;
            // 
            // btnCrearRol
            // 
            this.btnCrearRol.Location = new System.Drawing.Point(135, 131);
            this.btnCrearRol.Name = "btnCrearRol";
            this.btnCrearRol.Size = new System.Drawing.Size(102, 24);
            this.btnCrearRol.TabIndex = 7;
            this.btnCrearRol.Text = "Crear";
            this.btnCrearRol.UseVisualStyleBackColor = true;
            this.btnCrearRol.Click += new System.EventHandler(this.btnCrearRol_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "0(Activo)/1(Inactivo)";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(135, 83);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(205, 21);
            this.txtEstado.TabIndex = 9;
            // 
            // AltaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(363, 166);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCrearRol);
            this.Controls.Add(this.cBFuncio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomRol);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AltaRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta_Rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBFuncio;
        private System.Windows.Forms.Button btnCrearRol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEstado;
    }
}