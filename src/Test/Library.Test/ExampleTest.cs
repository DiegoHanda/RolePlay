using NUnit.Framework;
using Library;

namespace Test.Library
{
    public class ExampleTest
    {
        [Test]
        public void chequearCuraryRecibirVida()
        {
           Enano enano1 = new Enano("enano1");
           Mago mago1 = new Mago ("mago1");
           mago1.Curar(enano1);
           int saludActualEnano = enano1.Salud;
           int saludEsperadaEnano = 1450;
            Assert.AreEqual(saludEsperadaEnano,saludActualEnano);
        }
        
        [Test]
        public void chequearAtacarYRecibirDaño()
        {
           Enano enano1 = new Enano("enano1");
           Mago mago1 = new Mago ("mago1");
           mago1.Atacar(enano1);
           int saludActualEnano = enano1.Salud;
           int saludEsperadaEnano = 1290;
            Assert.AreEqual(saludEsperadaEnano,saludActualEnano);
        }
    }
}