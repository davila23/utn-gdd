using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.NINIRODIE.Clases;
using FrbaHotel.NINIRODIE.Repositorios;

namespace FrbaHotel.Cancelar_Reserva
{
    public partial class CancelarReserva : Form
    {
        public Usuario usuario { get; set; }
        public Boolean puedeCancelarse { get; set; }
        public Reserva reserva { get; set; }

        public CancelarReserva()
        {
            InitializeComponent();
        }

        public CancelarReserva(Usuario user, Reserva reserv) : this() 
        {
            usuario = user;
            reserva = reserv;
        }

        private void CancelarBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AceptarBoton_Click(object sender, EventArgs e)
        {
            if (this.MotivoRichTextBox.Text != "")
            {
                Cancelacion cancelacion = new Cancelacion(this.MotivoRichTextBox.Text, reserva.identificador, usuario.codigo);
                RepositorioReserva.Instance.RealizarCancelacion(cancelacion);
                RepositorioReserva.Instance.ActualizarEstadoReservaACancelada(usuario, cancelacion);
                MessageBox.Show("Su código de cancelación es: " + cancelacion.codigo.ToString(),
                                "Informe", MessageBoxButtons.OK);

                RepositorioHabitacion.Instance.CancelarReserva(reserva);

                this.Close();
            }
            else
                MessageBox.Show("Debe ingresar un motivo\n" +
                                "por el cual realiza la cancelacion.", "Atención", MessageBoxButtons.OK);
        }
    }
}