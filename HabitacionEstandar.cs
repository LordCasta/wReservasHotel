using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wReservasHotel
{
    public class HabitacionEstandar : Reserva
    {
        public double TarifaBase { get; set; }
        public HabitacionEstandar(double tarifa, string nombre, DateTime fechaReserva, int noches, int habitacion) : 
            base(nombre, fechaReserva, noches, habitacion)
        {

            TarifaBase = tarifa;
        }

        public override double CalcularCosto(int noches)
        {
            if (!(TarifaBase >= 0))
            {
                throw new ArgumentException("La tarifa debe ser mayor a 0");
            }
            else
            {
                return TarifaBase * noches;
            }
           
        }

        public override double CalcularCosto(int noches, double tarifa)
        {
            if(!(tarifa >= 0))
            {
                throw new ArgumentException("La tarifa debe ser mayor a 0");
            }
            else
            {
                return tarifa * noches;
            }
            
        }
    }
}
