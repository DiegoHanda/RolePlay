 using System;
 namespace Library;
public class Enano: IPersonaje
{
    public int CantidadCuracion;
    public string Nombre {get; set;}
    public int Salud {get; set;}
    public int Nivel {get; set;}
    public int Daño {get; set;}
    public int XP {get; set;}
    public string Descripcion {get; set;}
    
    public Enano (string nombre)
    {   
        this.Nombre = nombre;
        this.Salud = 1300;
        this.Daño = 200;
        this.Nivel = 1;
        this.XP=0;
        this.Descripcion="Los enanos son seres temperamentales, muy buenos en combate con las armas, físicamente fuertes, con mucha resistencia y leales a sus amigos.";
        this.CantidadCuracion=100;
    }
    public string SubirNivel()
    {
        int necesario=100*(this.Nivel/5+1);
        if (this.XP >=necesario)
        {
            Nivel+=1;
            this.XP=this.XP-necesario;
            if (this.Nivel % 5 !=0)
            {
                this.Daño=Convert.ToInt16(this.Daño*1.1);
                this.Salud=Convert.ToInt16(this.Salud*1.1);
            }
            else
            {
                this.Daño=Convert.ToInt16(this.Daño*1.2);
                this.Salud=Convert.ToInt16(this.Salud*1.2);
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
        personaje.RecibirSalud (CantidadCuracion);
    }
    public void RecibirSalud(int cantsalud)
    {
        Salud+=cantsalud;
    }

}