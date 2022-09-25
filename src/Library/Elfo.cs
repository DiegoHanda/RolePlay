using System;
namespace Library;
public class Elfo:IPersonaje
{
    public string Nombre {get; set;}
    public int Salud {get; set;}
    public int Nivel {get; set;}
    public int Daño {get; set;}
    public int XP {get; set;}
    public string Descripcion {get;}
    
    public Elfo (string nombre)
    {   
        Nombre = nombre;
        Salud = 1000;
        Daño=175;
        Nivel = 1;
        XP=0;
        Descripcion="Los elfos son criaturas supernaturales que también poseen características mágicas, y en general son conocidos por ayudar a los demás.";
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
}