namespace Library;
public class Enano
{
    public string Nombre {get; set;}
    public int Salud {get; set;}
    public int Nivel {get; set;}
    public int Daño {get; set;}
    public int XP {get; set;}

    public Enano (string nombre)
    {   
        this.Nombre = nombre;
        this.Salud = 1000;
        this.Daño = 250;
        this.Nivel = 1;
        this.XP = 0;
    }
    public string SubirNivel()
    {
        int necesario=100*(this.Nivel / 10 + 1);
        if (this.XP >=necesario)
        {
            this.Nivel+=1;
            return ($"{this.Nombre} ha subido a nivel {this.Nivel}");
            
        }
        return "";
    }

    public 


}