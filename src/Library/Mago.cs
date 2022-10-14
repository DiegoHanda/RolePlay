using System;
namespace Library;
public class Mago:IPersonaje
{
    public int CantidadCuracion;
    public string Nombre {get; set;}
    public int Salud {get; set;}
    public int Nivel {get; set;}
    public int Daño {get; set;}
    public int XP {get; set;}
    private string Descripcion {get; set;}
    public Mago (string nombre)
    {   
        this.Nombre = nombre;
        this.Salud = 100;
        this.Daño=10;
        this.Nivel = 1;
        this.XP=0;
        this.Descripcion="Los magos, también conocidos como Istari, tienen el dominio de la mágia, que provee capacidades de ataque y de defensa. La mágia es innata a ellos, aunque pueden adquirir más mediante el estudio de la asignatura, y mediante elementos que la potencian";
        this.CantidadCuracion=150;
    }
    public string SubirNivel()
    {
        int necesario=100*(Nivel/5+1);
        if (this.XP >=necesario)
        {
            Nivel+=1;
            this.XP=this.XP-necesario;
            if (Nivel % 5 !=0)
            {
                this.Salud=Convert.ToInt16(this.Salud*11);
            }
            else
            {
                this.Salud=Convert.ToInt16(this.Salud*1.5);
            }

            return ($"{this.Nombre} ha subido a nivel {this.Nivel}");
            
        }
        return "";
    }
    public void Atacar(IPersonaje personaje)
    {
       personaje.RecibirDaño(this.Daño);
    }
    public void RecibirDaño(int daño)
    {  
        Salud-=daño;
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