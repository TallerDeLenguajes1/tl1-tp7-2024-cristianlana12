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
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime fechaIngresoEmpresa;
        private double sueldoBasico;
        private Cargo cargoEmpleado;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public DateTime FechaIngresoEmpresa { get => fechaIngresoEmpresa; set => fechaIngresoEmpresa = value; }
        public double SueldoBasico { get => sueldoBasico; set => sueldoBasico = value; }
        public Cargo CargoEmpleado { get => cargoEmpleado; set => cargoEmpleado = value; }
    }
}