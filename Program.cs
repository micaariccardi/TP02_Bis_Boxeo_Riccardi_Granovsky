const string OPCION ="Ingrese qué acción quiere hacer: ", NOMBRE = "Ingrese el nombre del boxeador: ", PAIS = "Ingrese país: ", PESO = "Ingrese peso: ", P_GOLPES = "Ingrese la potencia de los golpes: ", V_PIERNAS = "Ingrese la velocidad de las piernas: ";
//HACER CONSTANTES PARA LOS RANGOS!!!
string nombre, pais;
int peso, potenciaGolpes, velocidadPiernas, opcion;
Boxeador boxeador1, boxeador2;


Console.WriteLine("MENSAJE CON OPCIONES :D");
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

        boxeador1 = new Boxeador(nombre,pais,peso,potenciaGolpes,velocidadPiernas);
        break;

        case 2:
        nombre = IngresarTexto(NOMBRE);
        pais = IngresarTexto(PAIS);
        peso = IngresarEntero(PESO);
        potenciaGolpes = IngresarEnteroRango(P_GOLPES, 1, 100);
        velocidadPiernas = IngresarEnteroRango(V_PIERNAS, 1, 100);

        boxeador2 = new Boxeador(nombre,pais,peso,potenciaGolpes,velocidadPiernas);
        break;

        case 3:
        break;
    }
    opcion=IngresarEnteroRango(OPCION, 1, 4);

}


int IngresarEntero(string mensaje)
{
    Console.WriteLine(mensaje);
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
