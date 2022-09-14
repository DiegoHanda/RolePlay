namespace Library;
public class Elfo:IPersonaje
{
    public string Nombre {get; set;}
    public int Salud {get; set;}
    public int Nivel {get; set;}
    public int Daño {get; set;}
    public int XP {get; set;}

    public Elfo (string nombre)
    {   
        this.Nombre = nombre;
        this.Salud = 1000;
        this.Daño=175;
        this.Nivel = 1;
        this.XP=0;
    }
    public string SubirNivel()
    {
        double necesario=100*(this.Nivel/5+1);
        if (this.XP >=necesario)
        {
            this.Nivel+=1;
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
        this.Salud-=daño;
    }

}