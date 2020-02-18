namespace FrbaHotel.Registrar_Estadia
{
    partial class IngresoOEgreso
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
            this.EgresoBoton = new System.Windows.Forms.Button();
            this.IngresoBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EgresoBoton
            // 
            this.EgresoBoton.Location = new System.Drawing.Point(58, 101);
            this.EgresoBoton.Name = "EgresoBoton";
            this.EgresoBoton.Size = new System.Drawing.Size(85, 30);
            this.EgresoBoton.TabIndex = 32;
            this.EgresoBoton.Text = "Egreso";
            this.EgresoBoton.UseVisualStyleBackColor = true;
            this.EgresoBoton.Click += new System.EventHandler(this.EgresoBoton_Click);
            // 
            // IngresoBoton
            // 
            this.IngresoBoton.Location = new System.Drawing.Point(58, 46);
            this.IngresoBoton.Name = "IngresoBoton";
            this.IngresoBoton.Size = new System.Drawing.Size(85, 30);
            this.IngresoBoton.TabIndex = 31;
            this.IngresoBoton.Text = "Ingreso";
            this.IngresoBoton.UseVisualStyleBackColor = true;
            this.IngresoBoton.Click += new System.EventHandler(this.IngresoBoton_Click);
            // 
            // IngresoOEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(201, 177);
            this.Controls.Add(this.EgresoBoton);
            this.Controls.Add(this.IngresoBoton);
            this.Name = "IngresoOEgreso";
            this.Text = "IngresoOEgreso";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EgresoBoton;
        private System.Windows.Forms.Button IngresoBoton;

    }
}