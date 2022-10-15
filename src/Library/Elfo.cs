using System;
namespace Library;
public class Elfo:IPersonaje
{
    public string Nombre {get; set;}
    public int Salud {get; set;}
    public int Nivel {get; set;}
    public int Daño {get; set;}
    public string Descripcion {get;}
    
    public Elfo (string nombre)
    {   
        Nombre = nombre;
        Salud = 1000;
        Daño=175;
        Nivel = 1;
        Descripcion="Los elfos son criaturas supernaturales que también poseen características mágicas, y en general son conocidos por ayudar a los demás.";
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
        personaje.RecibirSalud (Salud);
    }
    public void RecibirSalud(int salud)
    {
        Salud+=salud;
    }
}