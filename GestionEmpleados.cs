namespace GestionEmpleados
{
    public enum Cargo
        {
            Auxiliar,
            Administrativo,
            Ingeniero,
            Epecialista,
            Investigador
        }
    class Empleado
    {
        private string Nombre;
        private string Apellido;
        private DateTime FechaNacimiento;
        private string EstadoCivil;
        private DateTime FechaIngresoEmpresa;
        private double SueldoBasico;
        private Cargo CargoEmpleado;
    }
}