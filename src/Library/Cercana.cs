using System;
using System.Collections.Generic;

namespace Library;
public class Cercana: IItemsArma
{
    public string Nombre;
    public Cercana()
    {
        Nombre=Arsenal();
    }
    public string Arsenal()
    {
        Random random = new Random();        
        var list = new List<string>{"Maza","Tizona","Hacha Leviatan","Zulfiqar","Excalibur"," Lanza de Gungnir","Hojas del Caos","Espada de Diamante"};
        int index = random.Next(list.Count);
        return (list[index]);
    }
}