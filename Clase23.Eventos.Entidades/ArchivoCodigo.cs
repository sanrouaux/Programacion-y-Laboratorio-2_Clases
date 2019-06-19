using Clase23.Eventos.Entidades;

public delegate void DelegadoSueldo(Empleado e, float sueldo);

public delegate void DelSueldo(EmpleadoMejorado emp, EmpleadoSueldoArgs e);

public enum ETipoManejador
{
  limiteSueldo,
  log,
  ambos
}
