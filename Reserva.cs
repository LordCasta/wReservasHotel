using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wReservasHotel
{
    public abstract class Reserva
    {
        public string Nombre { get; set; }
        public DateTime FechaReserva { get; set; }
        public int Noches { get; set; }
        public int Habitacion { get; set; }

        public Reserva(string nombre, DateTime fechaReserva, int noches, int habitacion)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                throw new ArgumentException("El nombre no puede ser nulo o vacío");

            }
            if (fechaReserva == null)
            {
                throw new ArgumentException("La fecha no puede estar vacía");
            }
            if(!(noches > 0))
            {
                throw new ArgumentException("El número de noches debe ser mayor a 0");
            }
            Nombre = nombre;
            FechaReserva = fechaReserva;
            Noches = noches;
            Habitacion = habitacion;
        }

        public abstract double CalcularCosto(int noches);
        public abstract double CalcularCosto(int noches, double tarifa);

        public override string ToString()
        {
            return $"{Habitacion} | {Nombre} | {FechaReserva} | {Noches}";
        }
    }
}
