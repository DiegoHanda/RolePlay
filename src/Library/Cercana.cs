using System;
using System.Collections.Generic;

namespace Library;
public class Cercana: IItemsArma
{
    public string GetNombre()
    {
        return this.Nombre;
    }
    public int GetDamage()
    {
        return this.Damage;
    }

    public string GetDescripcion()
    {
        return this.Descripcion;
    }
    public string Nombre;
    public int Damage;
    public string Descripcion;
    public Cercana(string Nombre, int Damage, string Descripcion)
    {
        this.Nombre=Nombre;
        this.Damage=Damage;
        this.Descripcion=Descripcion;
    }
}