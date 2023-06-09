public class Boxeador{
    public string nombre{get;set;} = "";
    private string pais{get;set;}
    private int peso{get;set;}
    private int potenciaGolpes{get;set;}
    private int velocidadPiernas{get;set;}
    private int inteligencia{get;set;}
    public Boxeador()
    {

    }
    public Boxeador(string nom, string pa, int pe, int pg, int vp, int inte)
    {
        nombre = nom;
        pais = pa;
        peso = pe;
        potenciaGolpes = pg;
        velocidadPiernas = vp;
        inteligencia = inte;
    }

    public double ObtenerSkill()
    {
        double suma = velocidadPiernas * 0.6;
        suma += potenciaGolpes * 0.8;
        suma += GenerarRandom(1, 10);
        suma += inteligencia * 0.25;
        return suma;
    }
    private int GenerarRandom(int min, int max)
        {
            int num;
            Random rnd = new Random();
            num = rnd.Next(min, max+1);
            return num;
        }
}
