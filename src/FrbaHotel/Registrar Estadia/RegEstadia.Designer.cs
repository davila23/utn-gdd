namespace FrbaHotel.Registrar_Estadia
{
    partial class RegEstadia
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
            this.btnIngreso = new System.Windows.Forms.Button();
            this.btnEgreso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIngreso
            // 
            this.btnIngreso.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.Location = new System.Drawing.Point(12, 12);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(117, 40);
            this.btnIngreso.TabIndex = 0;
            this.btnIngreso.Text = "Check-In";
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // btnEgreso
            // 
            this.btnEgreso.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEgreso.Location = new System.Drawing.Point(172, 12);
            this.btnEgreso.Name = "btnEgreso";
            this.btnEgreso.Size = new System.Drawing.Size(127, 40);
            this.btnEgreso.TabIndex = 1;
            this.btnEgreso.Text = "Check-Out";
            this.btnEgreso.UseVisualStyleBackColor = true;
            this.btnEgreso.Click += new System.EventHandler(this.btnEgreso_Click);
            // 
            // RegEstadia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(336, 74);
            this.Controls.Add(this.btnEgreso);
            this.Controls.Add(this.btnIngreso);
            this.Name = "RegEstadia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Estadia";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnEgreso;
    }
}