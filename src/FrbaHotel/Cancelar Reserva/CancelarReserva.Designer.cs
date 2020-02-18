namespace FrbaHotel.Cancelar_Reserva
{
    partial class CancelarReserva
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
            this.MotivoLabel = new System.Windows.Forms.Label();
            this.AceptarBoton = new System.Windows.Forms.Button();
            this.CancelarBoton = new System.Windows.Forms.Button();
            this.MotivoRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // MotivoLabel
            // 
            this.MotivoLabel.AutoSize = true;
            this.MotivoLabel.Location = new System.Drawing.Point(12, 23);
            this.MotivoLabel.Name = "MotivoLabel";
            this.MotivoLabel.Size = new System.Drawing.Size(39, 13);
            this.MotivoLabel.TabIndex = 1;
            this.MotivoLabel.Text = "Motivo";
            // 
            // AceptarBoton
            // 
            this.AceptarBoton.Location = new System.Drawing.Point(53, 182);
            this.AceptarBoton.Name = "AceptarBoton";
            this.AceptarBoton.Size = new System.Drawing.Size(81, 36);
            this.AceptarBoton.TabIndex = 4;
            this.AceptarBoton.Text = "Aceptar";
            this.AceptarBoton.UseVisualStyleBackColor = true;
            this.AceptarBoton.Click += new System.EventHandler(this.AceptarBoton_Click);
            // 
            // CancelarBoton
            // 
            this.CancelarBoton.Location = new System.Drawing.Point(151, 182);
            this.CancelarBoton.Name = "CancelarBoton";
            this.CancelarBoton.Size = new System.Drawing.Size(81, 36);
            this.CancelarBoton.TabIndex = 5;
            this.CancelarBoton.Text = "Cancelar";
            this.CancelarBoton.UseVisualStyleBackColor = true;
            this.CancelarBoton.Click += new System.EventHandler(this.CancelarBoton_Click);
            // 
            // MotivoRichTextBox
            // 
            this.MotivoRichTextBox.Location = new System.Drawing.Point(14, 39);
            this.MotivoRichTextBox.Name = "MotivoRichTextBox";
            this.MotivoRichTextBox.Size = new System.Drawing.Size(257, 135);
            this.MotivoRichTextBox.TabIndex = 6;
            this.MotivoRichTextBox.Text = "";
            // 
            // CancelarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 228);
            this.Controls.Add(this.MotivoRichTextBox);
            this.Controls.Add(this.CancelarBoton);
            this.Controls.Add(this.AceptarBoton);
            this.Controls.Add(this.MotivoLabel);
            this.Name = "CancelarReserva";
            this.Text = "CancelarReserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MotivoLabel;
        private System.Windows.Forms.Button AceptarBoton;
        private System.Windows.Forms.Button CancelarBoton;
        private System.Windows.Forms.RichTextBox MotivoRichTextBox;
    }
}
