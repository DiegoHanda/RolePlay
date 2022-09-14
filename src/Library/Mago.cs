namespace Library;
public class Mago
{
    public string Nombre {get; set;}
    public float Salud {get; set;}
    public int Nivel {get; set;}

    public Mago (string nombre, float salud, string item)
    {   
        this.Nombre = nombre;
        this.Salud = salud;
        this.Nivel = 1;
    }

}