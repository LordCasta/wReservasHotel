using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wReservasHotel
{
    public partial class formReservas : Form
    {
        public formReservas()
        {
            InitializeComponent();
            
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            DateTime fechaReserva = dtpFecha.Value;
            string tipo = cmbTipo.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("El nombre no puede ser nulo o vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (fechaReserva < DateTime.Now)
            {
                MessageBox.Show("La fecha de reserva debe ser de hoy en adelante.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!int.TryParse(txtNoches.Text, out int habitacion) || habitacion < 0)
            {
                MessageBox.Show("Habitación debe ser un número mayor a 0.", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!int.TryParse(txtNoches.Text, out int noches) || noches<= 0)
            {
                MessageBox.Show("Noches debe ser un número mayor a 0.", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Reserva reserva = ReservaFactory.CrearReserva(tipo, nombre, fechaReserva, noches, habitacion, 100, 0.20f);
                    double costo = reserva.CalcularCosto(noches);
                    MessageBox.Show($"El costo de la reserva es de {costo}", "Costo de la reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
    }
}
