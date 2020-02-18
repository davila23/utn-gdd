namespace FrbaHotel.ABM_de_Habitacion
{
    partial class ModifHabitacion
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNHab = new System.Windows.Forms.TextBox();
            this.txtPH = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtTHab = new System.Windows.Forms.TextBox();
            this.txtUbi = new System.Windows.Forms.TextBox();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nro Habitación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Piso en Hotel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hotel que pertenece:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo Habitación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ubicación(C/S vista):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Descripción:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtNHab
            // 
            this.txtNHab.Location = new System.Drawing.Point(169, 10);
            this.txtNHab.Name = "txtNHab";
            this.txtNHab.Size = new System.Drawing.Size(116, 21);
            this.txtNHab.TabIndex = 6;
            // 
            // txtPH
            // 
            this.txtPH.Location = new System.Drawing.Point(169, 37);
            this.txtPH.Name = "txtPH";
            this.txtPH.Size = new System.Drawing.Size(116, 21);
            this.txtPH.TabIndex = 7;
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(169, 64);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(116, 21);
            this.txtH.TabIndex = 8;
            // 
            // txtTHab
            // 
            this.txtTHab.Location = new System.Drawing.Point(432, 10);
            this.txtTHab.Name = "txtTHab";
            this.txtTHab.Size = new System.Drawing.Size(116, 21);
            this.txtTHab.TabIndex = 9;
            // 
            // txtUbi
            // 
            this.txtUbi.Location = new System.Drawing.Point(433, 37);
            this.txtUbi.Name = "txtUbi";
            this.txtUbi.Size = new System.Drawing.Size(116, 21);
            this.txtUbi.TabIndex = 10;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(433, 64);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(116, 21);
            this.txtDesc.TabIndex = 11;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(236, 107);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(104, 23);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // ModifHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(570, 142);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.txtUbi);
            this.Controls.Add(this.txtTHab);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtPH);
            this.Controls.Add(this.txtNHab);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "ModifHabitacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Habitacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNHab;
        private System.Windows.Forms.TextBox txtPH;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtTHab;
        private System.Windows.Forms.TextBox txtUbi;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Button btnGuardar;
    }
}