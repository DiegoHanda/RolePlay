using System;
using System.Collections.Generic;
namespace Library;

public class Libro
{
    private string Titulo {get; set;}
    public int Nivel {get;}


    public Libro()
    {
        Nivel=ConocerNivel();
        Titulo=$"{Biblioteca()} {Nivel}";
    }

    public string Biblioteca()
    {
        Random random = new Random();        
        var list = new List<string>{ "DarkHold","La Llave de Salomón","El Libro de Moisés","Petit Albert","El Libro de San Cipriano","Dragón Rojo","El Libro de Honorio","El Mago","El Necronomicón","Libro de las Sombras"};
        int index = random.Next(list.Count);
        return (list[index]);
    }
    public int ConocerNivel()
    {
        Random rnd = new Random();
        int nivel  = rnd.Next(1, 10);
        return nivel;
    }
}
