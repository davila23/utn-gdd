using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class Tipos_Habitaciones : Form
    {
        public Tipos_Habitaciones(string tipoHabActual,DataTable tiposHabs)
        {
            InitializeComponent();
        }

        private void Tipos_Habitaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
