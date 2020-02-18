namespace FrbaHotel.ABM_de_Rol
{
    partial class ListadoRol
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
            this.btnLimpieza = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.txtNomRol = new System.Windows.Forms.TextBox();
            this.cBEstadoRol = new System.Windows.Forms.ComboBox();
            this.cBFuncionalidades = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Rol:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado Rol:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(295, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Funcionalidad:";
            // 
            // btnLimpieza
            // 
            this.btnLimpieza.Location = new System.Drawing.Point(605, 3);
            this.btnLimpieza.Name = "btnLimpieza";
            this.btnLimpieza.Size = new System.Drawing.Size(87, 23);
            this.btnLimpieza.TabIndex = 3;
            this.btnLimpieza.Text = "Limpieza";
            this.btnLimpieza.UseVisualStyleBackColor = true;
            this.btnLimpieza.Click += new System.EventHandler(this.btnLimpieza_Click);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(605, 40);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(87, 25);
            this.btnBusqueda.TabIndex = 4;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // txtNomRol
            // 
            this.txtNomRol.Location = new System.Drawing.Point(98, 6);
            this.txtNomRol.Name = "txtNomRol";
            this.txtNomRol.Size = new System.Drawing.Size(166, 21);
            this.txtNomRol.TabIndex = 5;
            // 
            // cBEstadoRol
            // 
            this.cBEstadoRol.FormattingEnabled = true;
            this.cBEstadoRol.Location = new System.Drawing.Point(98, 37);
            this.cBEstadoRol.Name = "cBEstadoRol";
            this.cBEstadoRol.Size = new System.Drawing.Size(166, 21);
            this.cBEstadoRol.TabIndex = 6;
            // 
            // cBFuncionalidades
            // 
            this.cBFuncionalidades.FormattingEnabled = true;
            this.cBFuncionalidades.Location = new System.Drawing.Point(390, 6);
            this.cBFuncionalidades.Name = "cBFuncionalidades";
            this.cBFuncionalidades.Size = new System.Drawing.Size(166, 21);
            this.cBFuncionalidades.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(675, 329);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ListadoRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(707, 412);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cBFuncionalidades);
            this.Controls.Add(this.cBEstadoRol);
            this.Controls.Add(this.txtNomRol);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.btnLimpieza);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ListadoRol";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado_Rol";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimpieza;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.TextBox txtNomRol;
        private System.Windows.Forms.ComboBox cBEstadoRol;
        private System.Windows.Forms.ComboBox cBFuncionalidades;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}