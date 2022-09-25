 using System;
 namespace Library;
public class Enano: IPersonaje
{
    public string Nombre {get; set;}
    public int Salud {get; set;}
    public int Nivel {get; set;}
    public int Daño {get; set;}
    public int XP {get; set;}
    public string Descripcion {get; set;}
    
    public Enano (string nombre)
    {   
        Nombre = nombre;
        Salud = 1300;
        Daño = 200;
        Nivel = 1;
        XP=0;
        Descripcion="Los enanos son seres temperamentales, muy buenos en combate con las armas, físicamente fuertes, con mucha resistencia y leales a sus amigos.";
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


            return ($"{this.Nombre} ha subido a nivel {this.Nivel}");
            
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