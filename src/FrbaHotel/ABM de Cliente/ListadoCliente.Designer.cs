namespace FrbaHotel.ABM_de_Cliente
{
    partial class ListadoCliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dGVListadoSeleccionados = new System.Windows.Forms.DataGridView();
            this.btnLimpieza = new System.Windows.Forms.Button();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtApe = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.cBtipoIdent = new System.Windows.Forms.ComboBox();
            this.txtNDoc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGVListadoSeleccionados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Doc:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nro Doc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mail:";
            // 
            // dGVListadoSeleccionados
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVListadoSeleccionados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dGVListadoSeleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVListadoSeleccionados.DefaultCellStyle = dataGridViewCellStyle2;
            this.dGVListadoSeleccionados.Location = new System.Drawing.Point(14, 138);
            this.dGVListadoSeleccionados.Name = "dGVListadoSeleccionados";
            this.dGVListadoSeleccionados.Size = new System.Drawing.Size(750, 279);
            this.dGVListadoSeleccionados.TabIndex = 5;
            this.dGVListadoSeleccionados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVListadoSeleccionados_CellContentClick);
            // 
            // btnLimpieza
            // 
            this.btnLimpieza.Location = new System.Drawing.Point(527, 93);
            this.btnLimpieza.Name = "btnLimpieza";
            this.btnLimpieza.Size = new System.Drawing.Size(87, 39);
            this.btnLimpieza.TabIndex = 6;
            this.btnLimpieza.Text = "Limpiar";
            this.btnLimpieza.UseVisualStyleBackColor = true;
            this.btnLimpieza.Click += new System.EventHandler(this.btnLimpieza_Click);
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.Location = new System.Drawing.Point(649, 93);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(87, 39);
            this.btnBusqueda.TabIndex = 7;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            this.btnBusqueda.Click += new System.EventHandler(this.btnBusqueda_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(87, 23);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(304, 21);
            this.txtNom.TabIndex = 8;
            this.txtNom.TextChanged += new System.EventHandler(this.txtNom_TextChanged);
            // 
            // txtApe
            // 
            this.txtApe.Location = new System.Drawing.Point(87, 59);
            this.txtApe.Name = "txtApe";
            this.txtApe.Size = new System.Drawing.Size(304, 21);
            this.txtApe.TabIndex = 9;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(87, 90);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(304, 21);
            this.txtMail.TabIndex = 10;
            // 
            // cBtipoIdent
            // 
            this.cBtipoIdent.FormattingEnabled = true;
            this.cBtipoIdent.Location = new System.Drawing.Point(527, 23);
            this.cBtipoIdent.Name = "cBtipoIdent";
            this.cBtipoIdent.Size = new System.Drawing.Size(70, 21);
            this.cBtipoIdent.TabIndex = 11;
            // 
            // txtNDoc
            // 
            this.txtNDoc.Location = new System.Drawing.Point(527, 59);
            this.txtNDoc.Name = "txtNDoc";
            this.txtNDoc.Size = new System.Drawing.Size(164, 21);
            this.txtNDoc.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(319, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "(*) Buscar por Tipo y numero de documento por favor";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // ListadoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(775, 458);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNDoc);
            this.Controls.Add(this.cBtipoIdent);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtApe);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.btnLimpieza);
            this.Controls.Add(this.dGVListadoSeleccionados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ListadoCliente";
            this.Text = "ListadoCliente";
            this.Load += new System.EventHandler(this.ListadoCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVListadoSeleccionados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dGVListadoSeleccionados;
        private System.Windows.Forms.Button btnLimpieza;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtApe;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ComboBox cBtipoIdent;
        private System.Windows.Forms.TextBox txtNDoc;
        private System.Windows.Forms.Label label6;
    }
}