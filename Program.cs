using EspacioCalculadora;

Calculadora num = new Calculadora();
int opcion = 999;
double operando;

while (opcion != 6)
{
    Console.WriteLine("#####CALCULADORA#####");
    Console.WriteLine("1_Sumar");
    Console.WriteLine("2_Restar");
    Console.WriteLine("3_Multiplicar");
    Console.WriteLine("4_Dividir");
    Console.WriteLine("5_Limpiar");
    Console.WriteLine("6_FINALIZAR");

    Console.WriteLine("Ingresar Opcion: ");
    int.TryParse(Console.ReadLine(), out opcion);

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese un numero: ");
            double.TryParse(Console.ReadLine(), out operando);
            if (num.Resultado == 0)
            {
                num.Sumar(operando);
                Console.WriteLine("0 + " + operando + " = " + num.Resultado);
            }
            else
            {
                double aux = num.Resultado;
                num.Sumar(operando);
                Console.WriteLine(aux + " + " + operando + " = " + num.Resultado);
            }
            break;

        case 2:
            Console.WriteLine("Ingrese un numero: ");
            double.TryParse(Console.ReadLine(), out operando);
            if (num.Resultado == 0)
            {
                num.Restar(operando);
                Console.WriteLine("0 - " + operando + " = " + num.Resultado);
            }
            else
            {
                double aux = num.Resultado;
                num.Restar(operando);
                Console.WriteLine(aux + " - " + operando + " = " + num.Resultado);
            }
            break;
        case 3:
            Console.WriteLine("Ingrese un numero: ");
            double.TryParse(Console.ReadLine(), out operando);
            if (num.Resultado == 0)
            {
                num.Multiplicar(operando);
                Console.WriteLine("0 x " + operando + " = " + num.Resultado);
            }
            else
            {
                double aux = num.Resultado;
                num.Multiplicar(operando);
                Console.WriteLine(aux + " x " + operando + " = " + num.Resultado);
            }
            break;
        case 4:
            Console.WriteLine("Ingrese un numero: ");
            double.TryParse(Console.ReadLine(), out operando);
            if (num.Resultado == 0)
            {
                num.Dividir(operando);
                Console.WriteLine("0 / " + operando + " = " + num.Resultado);
            }
            else
            {
                double aux = num.Resultado;
                num.Dividir(operando);
                Console.WriteLine(aux + " / " + operando + " = " + num.Resultado);
            }
            break;
        case 5:
            if (num.Resultado == 0)
            {
                num.Limpiar();
                Console.WriteLine("El resultado volvio a: " + num.Resultado);
            }
            else
            {
                num.Limpiar();
                Console.WriteLine("El resultado volvio a: " + num.Resultado);
            }
            break;

    }
}