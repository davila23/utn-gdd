namespace FrbaHotel.Generar_Modificar_Reserva
{
    partial class ModificarReserva
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
            this.HabitacionesDisponiblesDataGrid = new System.Windows.Forms.DataGridView();
            this.RegimenDataGrid = new System.Windows.Forms.DataGridView();
            this.hotelComboBox = new System.Windows.Forms.ComboBox();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.RegimenLabel = new System.Windows.Forms.Label();
            this.FechaHasta = new System.Windows.Forms.Label();
            this.FechaDesdeLabel = new System.Windows.Forms.Label();
            this.HotelLabel = new System.Windows.Forms.Label();
            this.HabitacionesReservadasGroupBox = new System.Windows.Forms.GroupBox();
            this.quitarBoton = new System.Windows.Forms.Button();
            this.HabitacionesReservadasDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.agregarBoton = new System.Windows.Forms.Button();
            this.CancelarBoton = new System.Windows.Forms.Button();
            this.modificarBoton = new System.Windows.Forms.Button();
            this.regimenActualDataGrid = new System.Windows.Forms.DataGridView();
            this.regimenActualLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cambiarBoton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HabitacionesDisponiblesDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegimenDataGrid)).BeginInit();
            this.HabitacionesReservadasGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HabitacionesReservadasDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regimenActualDataGrid)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // HabitacionesDisponiblesDataGrid
            // 
            this.HabitacionesDisponiblesDataGrid.AllowUserToAddRows = false;
            this.HabitacionesDisponiblesDataGrid.AllowUserToDeleteRows = false;
            this.HabitacionesDisponiblesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HabitacionesDisponiblesDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.HabitacionesDisponiblesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HabitacionesDisponiblesDataGrid.Location = new System.Drawing.Point(7, 19);
            this.HabitacionesDisponiblesDataGrid.MultiSelect = false;
            this.HabitacionesDisponiblesDataGrid.Name = "HabitacionesDisponiblesDataGrid";
            this.HabitacionesDisponiblesDataGrid.ReadOnly = true;
            this.HabitacionesDisponiblesDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HabitacionesDisponiblesDataGrid.Size = new System.Drawing.Size(672, 108);
            this.HabitacionesDisponiblesDataGrid.TabIndex = 13;
            // 
            // RegimenDataGrid
            // 
            this.RegimenDataGrid.AllowUserToAddRows = false;
            this.RegimenDataGrid.AllowUserToDeleteRows = false;
            this.RegimenDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RegimenDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RegimenDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegimenDataGrid.Location = new System.Drawing.Point(66, 75);
            this.RegimenDataGrid.MultiSelect = false;
            this.RegimenDataGrid.Name = "RegimenDataGrid";
            this.RegimenDataGrid.ReadOnly = true;
            this.RegimenDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RegimenDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RegimenDataGrid.Size = new System.Drawing.Size(286, 80);
            this.RegimenDataGrid.TabIndex = 22;
            // 
            // hotelComboBox
            // 
            this.hotelComboBox.FormattingEnabled = true;
            this.hotelComboBox.Location = new System.Drawing.Point(62, 26);
            this.hotelComboBox.Name = "hotelComboBox";
            this.hotelComboBox.Size = new System.Drawing.Size(262, 21);
            this.hotelComboBox.TabIndex = 21;
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.Location = new System.Drawing.Point(62, 133);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(262, 20);
            this.HastaDateTimePicker.TabIndex = 20;
            this.HastaDateTimePicker.ValueChanged += new System.EventHandler(this.HastaDateTimePicker_ValueChanged);
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(62, 78);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(262, 20);
            this.DesdeDateTimePicker.TabIndex = 19;
            this.DesdeDateTimePicker.ValueChanged += new System.EventHandler(this.DesdeDateTimePicker_ValueChanged);
            // 
            // RegimenLabel
            // 
            this.RegimenLabel.AutoSize = true;
            this.RegimenLabel.Location = new System.Drawing.Point(6, 75);
            this.RegimenLabel.Name = "RegimenLabel";
            this.RegimenLabel.Size = new System.Drawing.Size(46, 13);
            this.RegimenLabel.TabIndex = 18;
            this.RegimenLabel.Text = "Posibles";
            // 
            // FechaHasta
            // 
            this.FechaHasta.AutoSize = true;
            this.FechaHasta.Location = new System.Drawing.Point(8, 139);
            this.FechaHasta.Name = "FechaHasta";
            this.FechaHasta.Size = new System.Drawing.Size(35, 13);
            this.FechaHasta.TabIndex = 17;
            this.FechaHasta.Text = "Hasta";
            // 
            // FechaDesdeLabel
            // 
            this.FechaDesdeLabel.AutoSize = true;
            this.FechaDesdeLabel.Location = new System.Drawing.Point(8, 84);
            this.FechaDesdeLabel.Name = "FechaDesdeLabel";
            this.FechaDesdeLabel.Size = new System.Drawing.Size(38, 13);
            this.FechaDesdeLabel.TabIndex = 16;
            this.FechaDesdeLabel.Text = "Desde";
            // 
            // HotelLabel
            // 
            this.HotelLabel.AutoSize = true;
            this.HotelLabel.Location = new System.Drawing.Point(8, 29);
            this.HotelLabel.Name = "HotelLabel";
            this.HotelLabel.Size = new System.Drawing.Size(32, 13);
            this.HotelLabel.TabIndex = 15;
            this.HotelLabel.Text = "Hotel";
            // 
            // HabitacionesReservadasGroupBox
            // 
            this.HabitacionesReservadasGroupBox.Controls.Add(this.quitarBoton);
            this.HabitacionesReservadasGroupBox.Controls.Add(this.HabitacionesReservadasDataGrid);
            this.HabitacionesReservadasGroupBox.Location = new System.Drawing.Point(5, 204);
            this.HabitacionesReservadasGroupBox.Name = "HabitacionesReservadasGroupBox";
            this.HabitacionesReservadasGroupBox.Size = new System.Drawing.Size(683, 159);
            this.HabitacionesReservadasGroupBox.TabIndex = 25;
            this.HabitacionesReservadasGroupBox.TabStop = false;
            this.HabitacionesReservadasGroupBox.Text = "Habitaciones Reservadas";
            // 
            // quitarBoton
            // 
            this.quitarBoton.Location = new System.Drawing.Point(603, 130);
            this.quitarBoton.Name = "quitarBoton";
            this.quitarBoton.Size = new System.Drawing.Size(73, 23);
            this.quitarBoton.TabIndex = 29;
            this.quitarBoton.Text = "Quitar";
            this.quitarBoton.UseVisualStyleBackColor = true;
            this.quitarBoton.Click += new System.EventHandler(this.quitarBoton_Click);
            // 
            // HabitacionesReservadasDataGrid
            // 
            this.HabitacionesReservadasDataGrid.AllowUserToAddRows = false;
            this.HabitacionesReservadasDataGrid.AllowUserToDeleteRows = false;
            this.HabitacionesReservadasDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HabitacionesReservadasDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.HabitacionesReservadasDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HabitacionesReservadasDataGrid.Location = new System.Drawing.Point(9, 19);
            this.HabitacionesReservadasDataGrid.MultiSelect = false;
            this.HabitacionesReservadasDataGrid.Name = "HabitacionesReservadasDataGrid";
            this.HabitacionesReservadasDataGrid.ReadOnly = true;
            this.HabitacionesReservadasDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HabitacionesReservadasDataGrid.Size = new System.Drawing.Size(669, 105);
            this.HabitacionesReservadasDataGrid.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.agregarBoton);
            this.groupBox1.Controls.Add(this.HabitacionesDisponiblesDataGrid);
            this.groupBox1.Location = new System.Drawing.Point(5, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 162);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Habitaciones Libres";
            // 
            // agregarBoton
            // 
            this.agregarBoton.Location = new System.Drawing.Point(604, 133);
            this.agregarBoton.Name = "agregarBoton";
            this.agregarBoton.Size = new System.Drawing.Size(73, 23);
            this.agregarBoton.TabIndex = 30;
            this.agregarBoton.Text = "Agregar";
            this.agregarBoton.UseVisualStyleBackColor = true;
            this.agregarBoton.Click += new System.EventHandler(this.agregarBoton_Click);
            // 
            // CancelarBoton
            // 
            this.CancelarBoton.Location = new System.Drawing.Point(359, 537);
            this.CancelarBoton.Name = "CancelarBoton";
            this.CancelarBoton.Size = new System.Drawing.Size(87, 33);
            this.CancelarBoton.TabIndex = 28;
            this.CancelarBoton.Text = "Cancelar";
            this.CancelarBoton.UseVisualStyleBackColor = true;
            this.CancelarBoton.Click += new System.EventHandler(this.CancelarBoton_Click);
            // 
            // modificarBoton
            // 
            this.modificarBoton.Location = new System.Drawing.Point(247, 537);
            this.modificarBoton.Name = "modificarBoton";
            this.modificarBoton.Size = new System.Drawing.Size(87, 33);
            this.modificarBoton.TabIndex = 27;
            this.modificarBoton.Text = "Modificar";
            this.modificarBoton.UseVisualStyleBackColor = true;
            this.modificarBoton.Click += new System.EventHandler(this.modificarBoton_Click);
            // 
            // regimenActualDataGrid
            // 
            this.regimenActualDataGrid.AllowUserToAddRows = false;
            this.regimenActualDataGrid.AllowUserToDeleteRows = false;
            this.regimenActualDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.regimenActualDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.regimenActualDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.regimenActualDataGrid.Location = new System.Drawing.Point(65, 15);
            this.regimenActualDataGrid.MultiSelect = false;
            this.regimenActualDataGrid.Name = "regimenActualDataGrid";
            this.regimenActualDataGrid.ReadOnly = true;
            this.regimenActualDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.regimenActualDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.regimenActualDataGrid.Size = new System.Drawing.Size(286, 50);
            this.regimenActualDataGrid.TabIndex = 30;
            // 
            // regimenActualLabel
            // 
            this.regimenActualLabel.AutoSize = true;
            this.regimenActualLabel.Location = new System.Drawing.Point(11, 16);
            this.regimenActualLabel.Name = "regimenActualLabel";
            this.regimenActualLabel.Size = new System.Drawing.Size(37, 13);
            this.regimenActualLabel.TabIndex = 29;
            this.regimenActualLabel.Text = "Actual";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cambiarBoton);
            this.groupBox2.Controls.Add(this.regimenActualDataGrid);
            this.groupBox2.Controls.Add(this.regimenActualLabel);
            this.groupBox2.Controls.Add(this.RegimenDataGrid);
            this.groupBox2.Controls.Add(this.RegimenLabel);
            this.groupBox2.Location = new System.Drawing.Point(330, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 190);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Regimen";
            // 
            // cambiarBoton
            // 
            this.cambiarBoton.Location = new System.Drawing.Point(278, 161);
            this.cambiarBoton.Name = "cambiarBoton";
            this.cambiarBoton.Size = new System.Drawing.Size(73, 23);
            this.cambiarBoton.TabIndex = 30;
            this.cambiarBoton.Text = "Cambiar";
            this.cambiarBoton.UseVisualStyleBackColor = true;
            this.cambiarBoton.Click += new System.EventHandler(this.cambiarBoton_Click);
            // 
            // ModificarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(693, 574);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.CancelarBoton);
            this.Controls.Add(this.modificarBoton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.HabitacionesReservadasGroupBox);
            this.Controls.Add(this.hotelComboBox);
            this.Controls.Add(this.HastaDateTimePicker);
            this.Controls.Add(this.DesdeDateTimePicker);
            this.Controls.Add(this.FechaHasta);
            this.Controls.Add(this.FechaDesdeLabel);
            this.Controls.Add(this.HotelLabel);
            this.Name = "ModificarReserva";
            this.Text = "Modificar Reserva";
            ((System.ComponentModel.ISupportInitialize)(this.HabitacionesDisponiblesDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegimenDataGrid)).EndInit();
            this.HabitacionesReservadasGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HabitacionesReservadasDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.regimenActualDataGrid)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView HabitacionesDisponiblesDataGrid;
        private System.Windows.Forms.DataGridView RegimenDataGrid;
        private System.Windows.Forms.ComboBox hotelComboBox;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.Label RegimenLabel;
        private System.Windows.Forms.Label FechaHasta;
        private System.Windows.Forms.Label FechaDesdeLabel;
        private System.Windows.Forms.Label HotelLabel;
        private System.Windows.Forms.GroupBox HabitacionesReservadasGroupBox;
        private System.Windows.Forms.DataGridView HabitacionesReservadasDataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button CancelarBoton;
        private System.Windows.Forms.Button modificarBoton;
        private System.Windows.Forms.Button quitarBoton;
        private System.Windows.Forms.Button agregarBoton;
        private System.Windows.Forms.DataGridView regimenActualDataGrid;
        private System.Windows.Forms.Label regimenActualLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cambiarBoton;
    }
}