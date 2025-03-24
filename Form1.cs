using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace wReservasHotel
{
    public partial class formReservas : Form
    {
        GestorReservas gestor = GestorReservas.Instancia;
        Reserva reserva;
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
            else if (!int.TryParse(txtHabitacion.Text, out int habitacion) || habitacion < 0)
            {
                MessageBox.Show("Habitación debe ser un número mayor a 0.", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(txtNoches.Text, out int noches) || noches <= 0)
            {
                MessageBox.Show("Noches debe ser un número mayor a 0.", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    
                    if (gestor.BuscarReserva(habitacion, fechaReserva) == null)
                    {
                        reserva = ReservaFactory.CrearReserva(tipo, nombre, fechaReserva, noches, habitacion, 100, 0.20f);
                        double costo = reserva.CalcularCosto(noches, 100);
                        gestor.AgregarReserva(reserva);
                        MessageBox.Show($"Se ha creado correctamente y, el costo de la reserva es de {(int)Math.Round(costo)}", "Costo de la reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarReservas();
                        LimpiarCampos();
                    }
                    else
                    {
                        MessageBox.Show("La habitación ya está reservada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    MostrarReservas();

                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void formReservas_Load(object sender, EventArgs e)
        {
            #region[Combo habitaciones]
            cmbTipo.Items.Add("HabitacionEstandar");
            cmbTipo.Items.Add("HabitacionVIP");
            cmbTipo.SelectedIndex = 0;
            editarTipo.Items.Add("HabitacionEstandar");
            editarTipo.Items.Add("HabitacionVIP");
            editarTipo.SelectedIndex = 0;
            #endregion

        }

        public void LimpiarCampos()
        {
            txtNombre.Clear();
            txtNoches.Clear();
            dtpFecha.Value = DateTime.Now;
            cmbTipo.SelectedIndex = 0;
            txtHabitacion.Clear();
            txtNombre.Focus();

            editarNoches.Clear();
            editarNombre.Clear();
            editarFecha.Value = DateTime.Now;
            editarHabitacion.Clear();
        }

        public void MostrarReservas()
        {
            listBoxReservas.Items.Clear();
            listBoxReservas.Items.Add("Habitacion | Nombre | fecha | Noches");
            foreach (Reserva reserva in gestor.ObtenerReservas())
            {
                listBoxReservas.Items.Add(reserva.ToString());
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            

            //Búsqueda de la habitación y fecha extraídas de los campos del formulario que se usan para reservar
            if (!int.TryParse(txtHabitacion.Text, out int buscarHabitacion) || buscarHabitacion <= 0)
            {
                MessageBox.Show("Habitación debe ser un número mayor a 0.", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DateTime buscarFecha = dtpFecha.Value;

            reserva = gestor.BuscarReserva(buscarHabitacion, buscarFecha);
            //Si no hay nada en el campo, el valor se mantiene
            string nuevoNombre = string.IsNullOrWhiteSpace(editarNombre.Text)
                ? reserva.Nombre
                : editarNombre.Text.Trim();
            int nuevaHabitacion = string.IsNullOrWhiteSpace(editarHabitacion.Text)
                ? reserva.Habitacion
                : int.Parse(editarHabitacion.Text);
            int nuevasNoches = string.IsNullOrWhiteSpace(editarNoches.Text)
                ? reserva.Noches
                : int.Parse(editarNoches.Text);

            string nuevoTipo = editarTipo.SelectedItem.ToString();
            DateTime nuevaFecha = editarFecha.Value;

            if (nuevaFecha.Date < reserva.FechaReserva.Date)
            {
                MessageBox.Show("La fecha de reserva (editar) debe ser posterior o igual a la original.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ( nuevaHabitacion <= 0)
            {
                MessageBox.Show("Habitación (editar) debe ser un número mayor a 0.", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if ( nuevasNoches <= 0)
            {
                MessageBox.Show("Noches (editar) debe ser un número mayor a 0.", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if(gestor.BuscarReserva(nuevasNoches, nuevaFecha) != null)
                    {
                        MessageBox.Show("La habitación ya está reservada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        gestor.EditarReserva(buscarHabitacion, buscarFecha, nuevoNombre, nuevasNoches, nuevaFecha, nuevaHabitacion, nuevoTipo);
                        double costo = reserva.CalcularCosto(nuevasNoches, 100);
                        MessageBox.Show($"Se ha actualizado correctamente y, el nuevo costo de la reserva es de {(int)Math.Round(costo)}", "Costo de la reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarReservas();
                        LimpiarCampos();
                    }
                    
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Búsqueda de la habitación y fecha extraídas de los campos del formulario que se usan para reservar
            if (!int.TryParse(txtHabitacion.Text, out int buscarHabitacion) || buscarHabitacion <= 0)
            {
                MessageBox.Show("Habitación debe ser un número mayor a 0.", "Error",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DateTime buscarFecha = dtpFecha.Value;

            if(gestor.BuscarReserva(buscarHabitacion, buscarFecha) == null)
            {
                MessageBox.Show("La reserva no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                gestor.EliminarReserva(gestor.BuscarReserva(buscarHabitacion, buscarFecha));
                MessageBox.Show("Reserva eliminada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarReservas();
                LimpiarCampos();
            }
        }
    }
}
