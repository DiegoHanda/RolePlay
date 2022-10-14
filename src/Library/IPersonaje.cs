public interface IPersonaje 
{
    public void Atacar(IPersonaje personaje);
    public void Curar(IPersonaje personaje);
    public void RecibirSalud(int cantidad);
    public void RecibirDaño(int daño);
}