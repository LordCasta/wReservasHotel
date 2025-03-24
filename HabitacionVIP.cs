using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wReservasHotel
{
    public class HabitacionVIP : Reserva
    {
        public float Descuento { get; set; }
        public HabitacionVIP(float descuento, string nombre, DateTime fechaReserva, int noches, int habitacion) : 
            base(nombre, fechaReserva, noches, habitacion)
        {
            Descuento = descuento;
        }

        public override double CalcularCosto(int noches)
        {
            
            if(noches > 5)
            {
                return (100  * noches) - ((100 * noches) * Descuento);
            }
            else
            {
                return 100 * noches;
            }
            
        }

        public override double CalcularCosto(int noches, double tarifa)
        {
            if (!(tarifa >= 0))
            {
                throw new ArgumentException("La tarifa debe ser mayor a 0");
            }
            else
            {
                return (tarifa * noches) - ((tarifa * noches) * Descuento);
            }

        }
    }
}
