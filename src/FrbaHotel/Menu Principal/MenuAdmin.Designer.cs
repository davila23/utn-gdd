namespace FrbaHotel.Menu_Principal
{
    partial class MenuAdmin
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
            this.btnRol = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnHotel = new System.Windows.Forms.Button();
            this.btnHabitacion = new System.Windows.Forms.Button();
            this.btnREGIMEN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ABM\'S: ";
            // 
            // btnRol
            // 
            this.btnRol.Location = new System.Drawing.Point(17, 31);
            this.btnRol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRol.Name = "btnRol";
            this.btnRol.Size = new System.Drawing.Size(94, 34);
            this.btnRol.TabIndex = 1;
            this.btnRol.Text = "ROL";
            this.btnRol.UseVisualStyleBackColor = true;
            this.btnRol.Click += new System.EventHandler(this.btnRol_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Location = new System.Drawing.Point(119, 31);
            this.btnUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(107, 34);
            this.btnUsuario.TabIndex = 2;
            this.btnUsuario.Text = "USUARIO";
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(234, 31);
            this.btnCliente.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(111, 34);
            this.btnCliente.TabIndex = 3;
            this.btnCliente.Text = "CLIENTE";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnHotel
            // 
            this.btnHotel.Location = new System.Drawing.Point(119, 73);
            this.btnHotel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHotel.Name = "btnHotel";
            this.btnHotel.Size = new System.Drawing.Size(107, 37);
            this.btnHotel.TabIndex = 4;
            this.btnHotel.Text = "HOTEL";
            this.btnHotel.UseVisualStyleBackColor = true;
            this.btnHotel.Click += new System.EventHandler(this.btnHotel_Click);
            // 
            // btnHabitacion
            // 
            this.btnHabitacion.Location = new System.Drawing.Point(234, 73);
            this.btnHabitacion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHabitacion.Name = "btnHabitacion";
            this.btnHabitacion.Size = new System.Drawing.Size(111, 37);
            this.btnHabitacion.TabIndex = 5;
            this.btnHabitacion.Text = "HABITACION";
            this.btnHabitacion.UseVisualStyleBackColor = true;
            this.btnHabitacion.Click += new System.EventHandler(this.btnHabitacion_Click);
            // 
            // btnREGIMEN
            // 
            this.btnREGIMEN.Location = new System.Drawing.Point(18, 73);
            this.btnREGIMEN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnREGIMEN.Name = "btnREGIMEN";
            this.btnREGIMEN.Size = new System.Drawing.Size(94, 37);
            this.btnREGIMEN.TabIndex = 6;
            this.btnREGIMEN.Text = "REGIMEN";
            this.btnREGIMEN.UseVisualStyleBackColor = true;
            this.btnREGIMEN.Click += new System.EventHandler(this.btnREGIMEN_Click);
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(390, 138);
            this.Controls.Add(this.btnREGIMEN);
            this.Controls.Add(this.btnHabitacion);
            this.Controls.Add(this.btnHotel);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.btnUsuario);
            this.Controls.Add(this.btnRol);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRol;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnHotel;
        private System.Windows.Forms.Button btnHabitacion;
        private System.Windows.Forms.Button btnREGIMEN;
    }
}