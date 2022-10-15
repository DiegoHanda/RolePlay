 using System;
 namespace Library;
public class Enano: IPersonaje
{
    public int CantidadCuracion;
    public string Nombre {get; set;}
    public int Salud {get; set;}
    public int Nivel {get; set;}
    public int Daño {get; set;}
    public string Descripcion {get; set;}
    
    public Enano (string nombre)
    {   
        Nombre = nombre;
        Salud = 1300;
        Daño = 200;
        Nivel = 1;
        Descripcion="Los enanos son seres temperamentales, muy buenos en combate con las armas, físicamente fuertes, con mucha resistencia y leales a sus amigos.";
        CantidadCuracion=100;
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

}