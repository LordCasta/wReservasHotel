## Explicación proyecto universitario
<b>Patrones de diseño:</b> Singleton & factory <br/>
CRUD con Listas <br/>
Proyecto sobre la gestión de reservas de un hotel en Winforms con C#, para aplicar conocimientos sobre estos dos patrones de diseño y mejorar las habilidades en winforms.

## Clases
<ol>
  <li><b>Reserva:</b> Clase abstracta principal, con: NombreCliente, NumeroHabitacion, FechaReserva, DuracionEstadia.</li>
  <li><b>GestionReservas:</b> Singleton donde se almacena el CRUD con las listas</li>
  <li><b>HabitacionEstandar:</b> Una de las dos clases dentro del factory, que tiene una tarifa fija</li>
  <li><b>HabitacionVIP:</b> La otra clase para el factory, que cuenta con un descuento VIP</li>
  <li><b>ReservaFactory:</b> Factory donde se usan las dos clases de habitación para realizar las reservas</li>
</ol>
