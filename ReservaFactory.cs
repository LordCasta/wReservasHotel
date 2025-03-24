using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wReservasHotel
{
    public class ReservaFactory
    {
        public static Reserva CrearReserva(string tipo, string nombre, DateTime fechaReserva, int noches, int habitacion, double tarifa, float descuento)
        {
            switch (tipo)
            {
                case "HabitacionEstandar":
                    return new HabitacionEstandar(tarifa, nombre, fechaReserva, noches, habitacion );
                case "HabitacionVIP":
                    return new HabitacionVIP(descuento, nombre, fechaReserva, noches, habitacion);
                default:
                    throw new ArgumentException("Tipo de empleado no válido");
            }
        }
    }
}
