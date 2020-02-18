namespace FrbaHotel.Menu_Principal
{
    partial class MenuGuest
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
            this.btnModificar = new System.Windows.Forms.Button();
            this.bnCancelGuest = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(136, 27);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(129, 40);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar Reserva";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // bnCancelGuest
            // 
            this.bnCancelGuest.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnCancelGuest.Location = new System.Drawing.Point(271, 27);
            this.bnCancelGuest.Name = "bnCancelGuest";
            this.bnCancelGuest.Size = new System.Drawing.Size(129, 40);
            this.bnCancelGuest.TabIndex = 2;
            this.bnCancelGuest.Text = "Cancelar Reserva";
            this.bnCancelGuest.UseVisualStyleBackColor = true;
            this.bnCancelGuest.Click += new System.EventHandler(this.bnCancelGuest_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(12, 27);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(118, 40);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar Reserva";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // MenuGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(414, 77);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.bnCancelGuest);
            this.Controls.Add(this.btnModificar);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MenuGuest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Guest";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button bnCancelGuest;
        private System.Windows.Forms.Button btnGenerar;
    }
}