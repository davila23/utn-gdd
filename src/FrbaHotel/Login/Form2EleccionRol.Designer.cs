namespace FrbaCommerce.Login
{
    partial class Form2EleccionRol
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
            this.LBlistaRoles = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBlistaRoles
            // 
            this.LBlistaRoles.FormattingEnabled = true;
            this.LBlistaRoles.Location = new System.Drawing.Point(77, 29);
            this.LBlistaRoles.Name = "LBlistaRoles";
            this.LBlistaRoles.Size = new System.Drawing.Size(120, 43);
            this.LBlistaRoles.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elija un rol para ingresar";
            // 
            // btnIngreso
            // 
            this.btnIngreso.Location = new System.Drawing.Point(98, 78);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(75, 23);
            this.btnIngreso.TabIndex = 2;
            this.btnIngreso.Text = "Ingresar";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // Form2EleccionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 122);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBlistaRoles);
            this.Name = "Form2EleccionRol";
            this.Text = "Form2EleccionRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LBlistaRoles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIngreso;
    }
}