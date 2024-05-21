// See https://aka.ms/new-console-template for more information
namespace EspacioCalculadora
{
    public class Calculadora
    {
        private double dato;
        public double Resultado { get => dato; }

        public void Sumar(double num)
        {
            this.dato = dato + num;
        }

        public void Restar(double num)
        {
            this.dato = dato - num;
        }

        public void Multiplicar(double num)
        {
            this.dato = dato * num;
        }

        public void Dividir(double num)
        {
            this.dato = dato / num;
        }

        public void Limpiar()
        {
            this.dato = 0;
        }
    }

}