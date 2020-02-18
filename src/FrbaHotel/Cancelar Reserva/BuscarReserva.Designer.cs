namespace FrbaHotel.Cancelar_Reserva
{
    partial class BuscarReserva
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
            this.BuscarBoton = new System.Windows.Forms.Button();
            this.IngreseElCodigoDeReservaLabel = new System.Windows.Forms.Label();
            this.codigoReservaTextBox = new System.Windows.Forms.TextBox();
            this.CancelarBoton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BuscarBoton
            // 
            this.BuscarBoton.Location = new System.Drawing.Point(44, 99);
            this.BuscarBoton.Name = "BuscarBoton";
            this.BuscarBoton.Size = new System.Drawing.Size(87, 29);
            this.BuscarBoton.TabIndex = 0;
            this.BuscarBoton.Text = "Buscar";
            this.BuscarBoton.UseVisualStyleBackColor = true;
            this.BuscarBoton.Click += new System.EventHandler(this.BuscarBoton_Click);
            // 
            // IngreseElCodigoDeReservaLabel
            // 
            this.IngreseElCodigoDeReservaLabel.AutoSize = true;
            this.IngreseElCodigoDeReservaLabel.Location = new System.Drawing.Point(16, 28);
            this.IngreseElCodigoDeReservaLabel.Name = "IngreseElCodigoDeReservaLabel";
            this.IngreseElCodigoDeReservaLabel.Size = new System.Drawing.Size(147, 13);
            this.IngreseElCodigoDeReservaLabel.TabIndex = 1;
            this.IngreseElCodigoDeReservaLabel.Text = "Ingrese el Código de Reserva";
            // 
            // codigoReservaTextBox
            // 
            this.codigoReservaTextBox.Location = new System.Drawing.Point(33, 59);
            this.codigoReservaTextBox.Name = "codigoReservaTextBox";
            this.codigoReservaTextBox.Size = new System.Drawing.Size(218, 20);
            this.codigoReservaTextBox.TabIndex = 2;
            this.codigoReservaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // CancelarBoton
            // 
            this.CancelarBoton.Location = new System.Drawing.Point(154, 99);
            this.CancelarBoton.Name = "CancelarBoton";
            this.CancelarBoton.Size = new System.Drawing.Size(87, 29);
            this.CancelarBoton.TabIndex = 3;
            this.CancelarBoton.Text = "Salir";
            this.CancelarBoton.UseVisualStyleBackColor = true;
            this.CancelarBoton.Click += new System.EventHandler(this.CancelarBoton_Click);
            // 
            // BuscarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 140);
            this.Controls.Add(this.CancelarBoton);
            this.Controls.Add(this.codigoReservaTextBox);
            this.Controls.Add(this.IngreseElCodigoDeReservaLabel);
            this.Controls.Add(this.BuscarBoton);
            this.Name = "BuscarReserva";
            this.Text = "BuscarReserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarBoton;
        private System.Windows.Forms.Label IngreseElCodigoDeReservaLabel;
        private System.Windows.Forms.TextBox codigoReservaTextBox;
        private System.Windows.Forms.Button CancelarBoton;
    }
}
