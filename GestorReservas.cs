using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wReservasHotel
{
    public class GestorReservas
    {
        private static GestorReservas _instancia;
        private List<Reserva> reservas;
        private GestorReservas()
        {
            reservas = new List<Reserva>();
        }
        public static GestorReservas Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new GestorReservas();
                }
                return _instancia;
            }
        }
        public void AgregarReserva(Reserva reserva)
        {
            reservas.Add(reserva);
        }
        public void EliminarReserva(Reserva reserva)
        {
            reserva = BuscarReserva(reserva.Habitacion, reserva.FechaReserva);
            reservas.Remove(reserva);
        }
        public List<Reserva> ObtenerReservas()
        {
            return reservas;
        }
        public Reserva BuscarReserva(int habitacion, DateTime fechaReserva)
        {
            return reservas.FirstOrDefault(r => r.Habitacion == habitacion && r.FechaReserva == fechaReserva);
        }
        public void EditarReserva(int numeroHabitacion, DateTime fechaReserva, string nuevoCliente, int nuevaDuracion)
        {
            var reserva = BuscarReserva(numeroHabitacion, fechaReserva);

            if (reserva != null)
            {
                reserva.Nombre = nuevoCliente;
                reserva.Noches = nuevaDuracion;
            }
            else
            {
                throw new Exception("No se encontró la reserva.");
            }
        }
    }
}
