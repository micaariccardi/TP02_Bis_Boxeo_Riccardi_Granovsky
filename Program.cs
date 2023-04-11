const string OPCION ="Ingrese qué acción quiere hacer: ", INTELIGENCIA = "Ingrese la inteligencia: ",NOMBRE = "Ingrese el nombre del boxeador: ", PAIS = "Ingrese país: ", PESO = "Ingrese peso: ", P_GOLPES = "Ingrese la potencia de los golpes: ", V_PIERNAS = "Ingrese la velocidad de las piernas: ";
const string OPCIONES = "1. Cargar datos del boxeador 1\n2. Cargar datos del boxeador 2\n3. Pelear!\n4. Salir";
string nombre, pais;
int peso, potenciaGolpes, velocidadPiernas, inteligencia, opcion;
Boxeador boxeador1 = new Boxeador();
Boxeador boxeador2 = new Boxeador();


Console.WriteLine(OPCIONES);
opcion=IngresarEnteroRango(OPCION, 1, 4);

while (opcion!=4)
{
    switch(opcion)
    {
        case 1:
        nombre = IngresarTexto(NOMBRE);
        pais = IngresarTexto(PAIS);
        peso = IngresarEntero(PESO);
        potenciaGolpes = IngresarEnteroRango(P_GOLPES, 1, 100);
        velocidadPiernas = IngresarEnteroRango(V_PIERNAS, 1, 100);
        inteligencia = IngresarEnteroRango(INTELIGENCIA, 1, 100);

        boxeador1 = new Boxeador(nombre, pais, peso, potenciaGolpes, velocidadPiernas, inteligencia);
        break;

        case 2:
        nombre = IngresarTexto(NOMBRE);
        pais = IngresarTexto(PAIS);
        peso = IngresarEntero(PESO);
        potenciaGolpes = IngresarEnteroRango(P_GOLPES, 1, 100);
        velocidadPiernas = IngresarEnteroRango(V_PIERNAS, 1, 100);
        inteligencia = IngresarEnteroRango(INTELIGENCIA, 1, 100);

        boxeador2 = new Boxeador(nombre, pais, peso, potenciaGolpes, velocidadPiernas, inteligencia);
        break;

        case 3:
        if(boxeador1.nombre == "" || boxeador2.nombre == "")
        {
            Console.WriteLine("Datos insuficientes.");
        }
        else
        {
            double skill1 = boxeador1.ObtenerSkill();
            double skill2 = boxeador2.ObtenerSkill();
            double diferencia = Diferencia(skill1, skill2);
            if (diferencia <= -30)
            {
                Console.WriteLine("Ganó " + boxeador2.nombre + " por KO");
            }
            else if (diferencia <= -10)
            {
                Console.WriteLine("Ganó " + boxeador2.nombre + " por puntos en fallo unánime");
            }
            else if (diferencia < 0 && diferencia > -10)
            {
                Console.WriteLine("Ganó " + boxeador2.nombre + " por puntos de fallo dividido");
            }
            else if (diferencia == 0)
            {
                Console.WriteLine("Empate");
            }
            else if (diferencia > 0 && diferencia < 10)
            {
                Console.WriteLine("Ganó " + boxeador1.nombre + " por puntos de fallo dividido");
            }
            else if (diferencia <= 10)
            {
                Console.WriteLine("Ganó " + boxeador1.nombre + " por puntos en fallo unánime");
            }
            else if (diferencia >= 30)
            {
                Console.WriteLine("Ganó " + boxeador1.nombre + " por KO");
            }
        }

        break;
    }
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine(OPCIONES);
    opcion=IngresarEnteroRango(OPCION, 1, 4);

}

double Diferencia(double num1, double num2)
{
    return num1 - num2;
}

int IngresarEntero(string mensaje)
{
    Console.Write(mensaje);
    return int.Parse(Console.ReadLine());
}

string IngresarTexto(string mensaje)
{
    Console.Write(mensaje);
    return Console.ReadLine();
}

int IngresarEnteroRango(string mensaje, int desde, int hasta)
{
    int entero;
    do
    {
        Console.Write(mensaje);
        entero = int.Parse(Console.ReadLine());
    }
    while (entero < desde || entero > hasta);
    return entero;
}
