using System;
namespace Library;
public class Mago:IPersonaje
{
    public int CantidadCuracion;
    public string Nombre {get; set;}
    public int Salud {get; set;}
    public int Nivel {get; set;}
    public int Daño {get; set;}
    private string Descripcion {get; set;}
    public Mago (string nombre)
    {   
        Nombre = nombre;
        Salud = 100;
        Daño=10;
        Nivel = 1;
        Descripcion="Los magos, también conocidos como Istari, tienen el dominio de la mágia, que provee capacidades de ataque y de defensa. La mágia es innata a ellos, aunque pueden adquirir más mediante el estudio de la asignatura, y mediante elementos que la potencian";
        CantidadCuracion=150;
    }
    public string SubirNivel()
    {
        Nivel+=1;
        if (Nivel % 5 !=0)
        {
            Daño=Convert.ToInt16(Daño*1.1);
            Salud=Convert.ToInt16(Salud*1.1);
        }
        else
        {
            Daño=Convert.ToInt16(Daño*1.2);
            Salud=Convert.ToInt16(Salud*1.2);
        }

        return ($"{Nombre} ha subido a nivel {Nivel}");
    }
    public void Atacar(IPersonaje personaje)
    {
       personaje.RecibirDaño(Daño);
    }
    public void RecibirDaño(int daño)
    {  
        Salud-=daño;
        if (Salud<=0) Console.WriteLine($"{Nombre} ha muerto");

    }
    public void Curar(IPersonaje personaje)
    {
        personaje.RecibirSalud (CantidadCuracion);
    }
    public void RecibirSalud(int cantsalud)
    {
        Salud+=cantsalud;
    }
    public void LeerLibro(Libro libro)
    {
        Daño=Convert.ToInt16(Daño*(libro.Nivel/10+1));
    }
}