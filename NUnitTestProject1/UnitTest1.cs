using NUnit.Framework;
using EjercicioFizz;

//Escribe un programa que imprima los número del 1 al 100, pero aplicando las siguientes normas: 
//Devuelve Fizz si el número es = 3 o divisible por 3. 
//Devuelve Buzz si el número es = 5 o divisible por 5. 
//Devuelve FizzBuzz si el número es divisible por 3 y por 5. 

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestFizz21()
        {
            //Arrange
            int numero = 21;
            string resultado = "Fizz";
            string resultadoComprobar;

            //Act
            resultadoComprobar = ClaseFizz.Comprobar(numero);

            //Asert
            Assert.AreEqual(resultado, resultadoComprobar);
        }

        [Test]
        public void TestFizz3()
        {
            //Arrange
            int numero = 3;
            string resultado = "Fizz";
            string resultadoComprobar;

            //Act
            resultadoComprobar = ClaseFizz.Comprobar(numero);

            //Asert
            Assert.AreEqual(resultado, resultadoComprobar);
        }

        [Test]
        public void TestFizz5()
        {
            //Arrange
            int numero = 5;
            string resultado = "Buzz";
            string resultadoComprobar;

            //Act
            resultadoComprobar = ClaseFizz.Comprobar(numero);

            //Asert
            Assert.AreEqual(resultado, resultadoComprobar);
        }

        [Test]
        public void TestFizz35()
        {
            //Arrange
            int numero = 35;
            string resultado = "Buzz";
            string resultadoComprobar;

            //Act
            resultadoComprobar = ClaseFizz.Comprobar(numero);

            //Asert
            Assert.AreEqual(resultado, resultadoComprobar);
        }

        [Test]
        public void TestFizz30()
        {
            //Arrange
            int numero = 30;
            string resultado = "FizzBuzz";
            string resultadoComprobar;

            //Act
            resultadoComprobar = ClaseFizz.Comprobar(numero);

            //Asert
            Assert.AreEqual(resultado, resultadoComprobar);
        }

        [Test]
        public void TestFizz32()
        {
            //Arrange
            int numero = 32;
            string resultado = "32";
            string resultadoComprobar;

            //Act
            resultadoComprobar = ClaseFizz.Comprobar(numero);

            //Asert
            Assert.AreEqual(resultado, resultadoComprobar);
        }

        [Test]
        public void TestFizz80()
        {
            //Arrange
            int numero = 80;
            string resultado = "Buzz";
            string resultadoComprobar;

            //Act
            resultadoComprobar = ClaseFizz.Comprobar(numero);

            //Asert
            Assert.AreEqual(resultado, resultadoComprobar);
        }


    }
}