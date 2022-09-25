using System;
namespace Library;
public class Mago:IPersonaje
{
    public string Nombre {get; set;}
    public int Salud {get; set;}
    public int Nivel {get; set;}
    public int Daño {get; set;}
    public int XP {get; set;}
    private string Descripcion {get; set;}
    public Mago (string nombre)
    {   
        Nombre = nombre;
        Salud = 100;
        Daño=10;
        Nivel = 1;
        XP=0;
        Descripcion="Los magos, también conocidos como Istari, tienen el dominio de la mágia, que provee capacidades de ataque y de defensa. La mágia es innata a ellos, aunque pueden adquirir más mediante el estudio de la asignatura, y mediante elementos que la potencian";
    }
    public string SubirNivel()
    {
        double necesario=100*(Nivel/5+1);
        if (XP >=necesario)
        {
            Nivel+=1;
            XP=0;
            if (Nivel % 5 !=0)
            {
                Salud=Convert.ToInt16(Salud*11);
            }
            else
            {
                Salud=Convert.ToInt16(Salud*1.5);
            }

            return ($"{Nombre} ha subido a nivel {Nivel}");
            
        }
        return "";
    }
    public void Atacar(IPersonaje personaje)
    {
       personaje.RecibirDaño(Daño);
    }
    public void RecibirDaño(int daño)
    {  
        Salud-=daño;
    }
    public void Curar(IPersonaje personaje)
    {
        personaje.RecibirSalud (Salud);
    }
    public void RecibirSalud(int salud)
    {
        Salud+=salud;
    }
    public void LeerLibro(Libro libro)
    {
        Daño=Convert.ToInt16(Daño*(libro.Nivel/10+1));
    }
}