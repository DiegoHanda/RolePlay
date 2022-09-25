using System;
using System.Collections.Generic;

namespace Library;
public class Lejana:IArma
{
    public string Nombre;
    public Lejana()
    {
        Nombre=Arsenal();
    }
    public string Arsenal()
    {
        Random random = new Random();        
        var list = new List<string>{"Arco","Ballesta"};
        int index = random.Next(list.Count);
        return (list[index]);
    }
}