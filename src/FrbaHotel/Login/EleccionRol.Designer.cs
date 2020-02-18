namespace FrbaHotel.Login
{
    partial class EleccionRol
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
            this.lBEleccionRoles = new System.Windows.Forms.ListBox();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elija el rol con el que desea iniciar sesión:";
            // 
            // lBEleccionRoles
            // 
            this.lBEleccionRoles.FormattingEnabled = true;
            this.lBEleccionRoles.Location = new System.Drawing.Point(34, 25);
            this.lBEleccionRoles.Name = "lBEleccionRoles";
            this.lBEleccionRoles.Size = new System.Drawing.Size(196, 225);
            this.lBEleccionRoles.TabIndex = 2;
            // 
            // btnIngreso
            // 
            this.btnIngreso.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.Location = new System.Drawing.Point(34, 256);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(196, 27);
            this.btnIngreso.TabIndex = 3;
            this.btnIngreso.Text = "Aceptar";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // EleccionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(267, 297);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.lBEleccionRoles);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EleccionRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eleccion_Rol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lBEleccionRoles;
        private System.Windows.Forms.Button btnIngreso;
    }
}