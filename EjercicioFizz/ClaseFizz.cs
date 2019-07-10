using System;
using System.Collections.Generic;
using System.Text;

//Escribe un programa que imprima los número del 1 al 100, pero aplicando las siguientes normas: 
//Devuelve Fizz si el número es = 3 o divisible por 3. 
//Devuelve Buzz si el número es = 5 o divisible por 5. 
//Devuelve FizzBuzz si el número es divisible por 3 y por 5. 

namespace EjercicioFizz
{
    public class ClaseFizz
    {
        public static string Comprobar(int numero)
        {
            string resultado = "";

            if (numero % 3 == 0 && numero % 5 == 0)
            {
                resultado = "FizzBuzz";
            }
            else
            {
                if (numero % 3 == 0)
                {
                    resultado = "Fizz";
                }
                else
                {
                    if (numero % 5 == 0)
                    {
                        resultado = "Buzz";
                    }
                    else
                    {
                        resultado = numero.ToString();
                    }
                }
            }

            return resultado;
        }
    }
}
