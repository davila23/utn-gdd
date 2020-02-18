namespace FrbaHotel.ABM_de_Rol
{
    partial class ModificarRol
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomRol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBFuncActuales = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBFuncAAgregar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(174, 123);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(87, 33);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Modificar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // txtNomRol
            // 
            this.txtNomRol.Location = new System.Drawing.Point(174, 6);
            this.txtNomRol.Name = "txtNomRol";
            this.txtNomRol.Size = new System.Drawing.Size(228, 21);
            this.txtNomRol.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Funcionalidades a quitar:";
            // 
            // cBFuncActuales
            // 
            this.cBFuncActuales.FormattingEnabled = true;
            this.cBFuncActuales.Location = new System.Drawing.Point(174, 33);
            this.cBFuncActuales.Name = "cBFuncActuales";
            this.cBFuncActuales.Size = new System.Drawing.Size(228, 21);
            this.cBFuncActuales.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Funcionalidades a agregar:";
            // 
            // cBFuncAAgregar
            // 
            this.cBFuncAAgregar.FormattingEnabled = true;
            this.cBFuncAAgregar.Location = new System.Drawing.Point(174, 60);
            this.cBFuncAAgregar.Name = "cBFuncAAgregar";
            this.cBFuncAAgregar.Size = new System.Drawing.Size(228, 21);
            this.cBFuncAAgregar.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estado:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(174, 87);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(228, 21);
            this.txtEstado.TabIndex = 8;
            // 
            // ModificarRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(416, 168);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBFuncAAgregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBFuncActuales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomRol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ModificarRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar_Rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomRol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBFuncActuales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBFuncAAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEstado;
    }
}