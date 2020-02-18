namespace FrbaHotel.Cancelar_Reserva
{
    partial class CancelReser
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNroReserva = new System.Windows.Forms.TextBox();
            this.txtFecCancel = new System.Windows.Forms.TextBox();
            this.txtMotivo = new System.Windows.Forms.TextBox();
            this.btnAceptarCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro de Reserva:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Motivo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Cancelación:";
            // 
            // txtNroReserva
            // 
            this.txtNroReserva.Location = new System.Drawing.Point(113, 12);
            this.txtNroReserva.Name = "txtNroReserva";
            this.txtNroReserva.Size = new System.Drawing.Size(236, 21);
            this.txtNroReserva.TabIndex = 4;
            // 
            // txtFecCancel
            // 
            this.txtFecCancel.Enabled = false;
            this.txtFecCancel.Location = new System.Drawing.Point(131, 175);
            this.txtFecCancel.Name = "txtFecCancel";
            this.txtFecCancel.ReadOnly = true;
            this.txtFecCancel.Size = new System.Drawing.Size(218, 21);
            this.txtFecCancel.TabIndex = 6;
            // 
            // txtMotivo
            // 
            this.txtMotivo.Location = new System.Drawing.Point(10, 58);
            this.txtMotivo.Multiline = true;
            this.txtMotivo.Name = "txtMotivo";
            this.txtMotivo.Size = new System.Drawing.Size(339, 111);
            this.txtMotivo.TabIndex = 7;
            // 
            // btnAceptarCancel
            // 
            this.btnAceptarCancel.Location = new System.Drawing.Point(10, 231);
            this.btnAceptarCancel.Name = "btnAceptarCancel";
            this.btnAceptarCancel.Size = new System.Drawing.Size(127, 28);
            this.btnAceptarCancel.TabIndex = 8;
            this.btnAceptarCancel.Text = "Aceptar";
            this.btnAceptarCancel.UseVisualStyleBackColor = true;
            this.btnAceptarCancel.Click += new System.EventHandler(this.btnAceptarCancel_Click);
            // 
            // CancelReser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(384, 268);
            this.Controls.Add(this.btnAceptarCancel);
            this.Controls.Add(this.txtMotivo);
            this.Controls.Add(this.txtFecCancel);
            this.Controls.Add(this.txtNroReserva);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "CancelReser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar Reserva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNroReserva;
        private System.Windows.Forms.TextBox txtFecCancel;
        private System.Windows.Forms.TextBox txtMotivo;
        private System.Windows.Forms.Button btnAceptarCancel;
    }
}