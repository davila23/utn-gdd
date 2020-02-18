namespace FrbaHotel.Generar_Modificar_Reserva
{
    partial class GenerarReserva
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
            this.HotelLabel = new System.Windows.Forms.Label();
            this.FechaDesdeLabel = new System.Windows.Forms.Label();
            this.FechaHasta = new System.Windows.Forms.Label();
            this.RegimenLabel = new System.Windows.Forms.Label();
            this.DesdeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.HastaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hotelComboBox = new System.Windows.Forms.ComboBox();
            this.BuscarBoton = new System.Windows.Forms.Button();
            this.ConfirmarBoton = new System.Windows.Forms.Button();
            this.CancelarBoton = new System.Windows.Forms.Button();
            this.HabitacionesDisponiblesDataGrid = new System.Windows.Forms.DataGridView();
            this.HabitacionesDisponiblesGroupBox = new System.Windows.Forms.GroupBox();
            this.RegimenDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.HabitacionesDisponiblesDataGrid)).BeginInit();
            this.HabitacionesDisponiblesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegimenDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // HotelLabel
            // 
            this.HotelLabel.AutoSize = true;
            this.HotelLabel.Location = new System.Drawing.Point(12, 25);
            this.HotelLabel.Name = "HotelLabel";
            this.HotelLabel.Size = new System.Drawing.Size(32, 13);
            this.HotelLabel.TabIndex = 0;
            this.HotelLabel.Text = "Hotel";
            // 
            // FechaDesdeLabel
            // 
            this.FechaDesdeLabel.AutoSize = true;
            this.FechaDesdeLabel.Location = new System.Drawing.Point(12, 84);
            this.FechaDesdeLabel.Name = "FechaDesdeLabel";
            this.FechaDesdeLabel.Size = new System.Drawing.Size(38, 13);
            this.FechaDesdeLabel.TabIndex = 1;
            this.FechaDesdeLabel.Text = "Desde";
            // 
            // FechaHasta
            // 
            this.FechaHasta.AutoSize = true;
            this.FechaHasta.Location = new System.Drawing.Point(12, 141);
            this.FechaHasta.Name = "FechaHasta";
            this.FechaHasta.Size = new System.Drawing.Size(35, 13);
            this.FechaHasta.TabIndex = 2;
            this.FechaHasta.Text = "Hasta";
            // 
            // RegimenLabel
            // 
            this.RegimenLabel.AutoSize = true;
            this.RegimenLabel.Location = new System.Drawing.Point(346, 22);
            this.RegimenLabel.Name = "RegimenLabel";
            this.RegimenLabel.Size = new System.Drawing.Size(49, 13);
            this.RegimenLabel.TabIndex = 3;
            this.RegimenLabel.Text = "Regimen";
            // 
            // DesdeDateTimePicker
            // 
            this.DesdeDateTimePicker.Location = new System.Drawing.Point(66, 78);
            this.DesdeDateTimePicker.Name = "DesdeDateTimePicker";
            this.DesdeDateTimePicker.Size = new System.Drawing.Size(262, 20);
            this.DesdeDateTimePicker.TabIndex = 6;
            // 
            // HastaDateTimePicker
            // 
            this.HastaDateTimePicker.Location = new System.Drawing.Point(66, 135);
            this.HastaDateTimePicker.Name = "HastaDateTimePicker";
            this.HastaDateTimePicker.Size = new System.Drawing.Size(262, 20);
            this.HastaDateTimePicker.TabIndex = 7;
            // 
            // hotelComboBox
            // 
            this.hotelComboBox.FormattingEnabled = true;
            this.hotelComboBox.Location = new System.Drawing.Point(66, 22);
            this.hotelComboBox.Name = "hotelComboBox";
            this.hotelComboBox.Size = new System.Drawing.Size(262, 21);
            this.hotelComboBox.TabIndex = 8;
            this.hotelComboBox.SelectedIndexChanged += new System.EventHandler(this.hotelComboBox_SelectedIndexChanged);
            // 
            // BuscarBoton
            // 
            this.BuscarBoton.Location = new System.Drawing.Point(307, 194);
            this.BuscarBoton.Name = "BuscarBoton";
            this.BuscarBoton.Size = new System.Drawing.Size(87, 33);
            this.BuscarBoton.TabIndex = 9;
            this.BuscarBoton.Text = "Buscar";
            this.BuscarBoton.UseVisualStyleBackColor = true;
            this.BuscarBoton.Click += new System.EventHandler(this.BuscarBoton_Click);
            // 
            // ConfirmarBoton
            // 
            this.ConfirmarBoton.Location = new System.Drawing.Point(496, 408);
            this.ConfirmarBoton.Name = "ConfirmarBoton";
            this.ConfirmarBoton.Size = new System.Drawing.Size(87, 33);
            this.ConfirmarBoton.TabIndex = 10;
            this.ConfirmarBoton.Text = "Confirmar";
            this.ConfirmarBoton.UseVisualStyleBackColor = true;
            this.ConfirmarBoton.Click += new System.EventHandler(this.ConfirmarBoton_Click);
            // 
            // CancelarBoton
            // 
            this.CancelarBoton.Location = new System.Drawing.Point(608, 408);
            this.CancelarBoton.Name = "CancelarBoton";
            this.CancelarBoton.Size = new System.Drawing.Size(87, 33);
            this.CancelarBoton.TabIndex = 11;
            this.CancelarBoton.Text = "Cancelar";
            this.CancelarBoton.UseVisualStyleBackColor = true;
            this.CancelarBoton.Click += new System.EventHandler(this.CancelarBoton_Click);
            // 
            // HabitacionesDisponiblesDataGrid
            // 
            this.HabitacionesDisponiblesDataGrid.AllowUserToAddRows = false;
            this.HabitacionesDisponiblesDataGrid.AllowUserToDeleteRows = false;
            this.HabitacionesDisponiblesDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HabitacionesDisponiblesDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.HabitacionesDisponiblesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HabitacionesDisponiblesDataGrid.Location = new System.Drawing.Point(6, 19);
            this.HabitacionesDisponiblesDataGrid.Name = "HabitacionesDisponiblesDataGrid";
            this.HabitacionesDisponiblesDataGrid.ReadOnly = true;
            this.HabitacionesDisponiblesDataGrid.Size = new System.Drawing.Size(669, 144);
            this.HabitacionesDisponiblesDataGrid.TabIndex = 12;
            // 
            // HabitacionesDisponiblesGroupBox
            // 
            this.HabitacionesDisponiblesGroupBox.Controls.Add(this.HabitacionesDisponiblesDataGrid);
            this.HabitacionesDisponiblesGroupBox.Location = new System.Drawing.Point(12, 233);
            this.HabitacionesDisponiblesGroupBox.Name = "HabitacionesDisponiblesGroupBox";
            this.HabitacionesDisponiblesGroupBox.Size = new System.Drawing.Size(683, 169);
            this.HabitacionesDisponiblesGroupBox.TabIndex = 13;
            this.HabitacionesDisponiblesGroupBox.TabStop = false;
            this.HabitacionesDisponiblesGroupBox.Text = "Habitaciones Disponibles";
            // 
            // RegimenDataGrid
            // 
            this.RegimenDataGrid.AllowUserToAddRows = false;
            this.RegimenDataGrid.AllowUserToDeleteRows = false;
            this.RegimenDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RegimenDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RegimenDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegimenDataGrid.Location = new System.Drawing.Point(401, 19);
            this.RegimenDataGrid.MultiSelect = false;
            this.RegimenDataGrid.Name = "RegimenDataGrid";
            this.RegimenDataGrid.ReadOnly = true;
            this.RegimenDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RegimenDataGrid.Size = new System.Drawing.Size(286, 146);
            this.RegimenDataGrid.TabIndex = 14;
            this.RegimenDataGrid.SelectionChanged += new System.EventHandler(this.RegimenDataGrid_SelectionChanged);
            // 
            // GenerarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(701, 453);
            this.Controls.Add(this.RegimenDataGrid);
            this.Controls.Add(this.HabitacionesDisponiblesGroupBox);
            this.Controls.Add(this.CancelarBoton);
            this.Controls.Add(this.ConfirmarBoton);
            this.Controls.Add(this.BuscarBoton);
            this.Controls.Add(this.hotelComboBox);
            this.Controls.Add(this.HastaDateTimePicker);
            this.Controls.Add(this.DesdeDateTimePicker);
            this.Controls.Add(this.RegimenLabel);
            this.Controls.Add(this.FechaHasta);
            this.Controls.Add(this.FechaDesdeLabel);
            this.Controls.Add(this.HotelLabel);
            this.Name = "GenerarReserva";
            this.Text = "Generar Reserva";
            ((System.ComponentModel.ISupportInitialize)(this.HabitacionesDisponiblesDataGrid)).EndInit();
            this.HabitacionesDisponiblesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RegimenDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HotelLabel;
        private System.Windows.Forms.Label FechaDesdeLabel;
        private System.Windows.Forms.Label FechaHasta;
        private System.Windows.Forms.Label RegimenLabel;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicker;
        private System.Windows.Forms.DateTimePicker HastaDateTimePicker;
        private System.Windows.Forms.ComboBox hotelComboBox;
        private System.Windows.Forms.Button BuscarBoton;
        private System.Windows.Forms.Button ConfirmarBoton;
        private System.Windows.Forms.Button CancelarBoton;
        private System.Windows.Forms.DataGridView HabitacionesDisponiblesDataGrid;
        private System.Windows.Forms.GroupBox HabitacionesDisponiblesGroupBox;
        private System.Windows.Forms.DataGridView RegimenDataGrid;
    }
}