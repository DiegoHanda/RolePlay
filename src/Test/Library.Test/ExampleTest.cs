using NUnit.Framework;
using System;
using Library;

namespace Test.Library
{
    public class ExampleTest
    {

        [Test]
        public void chequearStatsAlSubirNivel()  //Chequeo de Stats de Elfo al subir de nivel, solo se testea la clase Elfo ya que el resto de los Personajes (Mago y Enano) tienen el mismo metodo SubirNivel()
        {
            Elfo elfo1 = new Elfo("elfo");
            elfo1.SubirNivel();

            int dañoActual = elfo1.Daño;
            int dañoEsperado = 193;
            int saludActual = elfo1.Salud;
            int saludEsperado = 1100;
            int nivelActual = elfo1.Nivel;
            int nivelEsperado = 2;

            Assert.AreEqual(dañoEsperado,dañoActual);
            Assert.AreEqual(saludEsperado,saludActual);
            Assert.AreEqual(nivelEsperado,nivelActual);
        }
        [Test]
        public void chequearAtacarYRecibirDaño()//Se testea que al recibir da;o el personaje efectivamente pirda vida
        {
           Enano enano1 = new Enano("enano1");
           Mago mago1 = new Mago ("mago1");
           mago1.Atacar(enano1);
           int saludActualEnano = enano1.Salud;
           int saludEsperadaEnano = 1290;
            Assert.AreEqual(saludEsperadaEnano,saludActualEnano);
        }
        [Test]
        public void chequearCuraryRecibirVida()//Se testea para asegurarse de que la curacion de un personaje a otro funcinoe bien
        {
           Enano enano1 = new Enano("enano1");
           Mago mago1 = new Mago ("mago1");
           mago1.Curar(enano1);
           int saludActualEnano = enano1.Salud;
           int saludEsperadaEnano = 1450;
            Assert.AreEqual(saludEsperadaEnano,saludActualEnano);
        }
    }
}
