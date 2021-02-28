using System;

namespace calcula_imc
{
    class Program
    {
        static void Main(string[] args)
        {

            double altura;
            double peso;
            double imc;

            Console.WriteLine("***************IMC 2020************");
            Console.WriteLine("Digite sua altura em metros");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o seu peso em quilos");
            peso = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("seu imc é:" + (imc = peso / (altura * altura)));

            if (imc < 20)
            {
               Console.WriteLine("\n\t\t\t MUITO MAGRO");
            }
            else
            {
                if (imc >= 20 && imc < 25)
                {
                   Console.WriteLine("\n\n NORMAL");
                }
                else
                {
                    if (imc >= 25 && imc < 30)
                    {
                        Console.WriteLine("\n\t\t  SOBRE PESO");
                    }
                    else
                    {
                        if (imc >= 30 && imc <= 35)
                        {
                            Console.WriteLine("\n\t\t  OBESIDADE LEVE");
                        }
                        else
                        {
                            if (imc >= 35 && imc <= 40)
                            {
                                Console.WriteLine(" \n\t\t OBESIDADE MODERADA");
                            }
                            else
                            {
                                if (imc > 40)
                                {
                                    Console.WriteLine("\n\t\t  OBESIDADE GRAVE");
                                }
                            }
                           
                        }
                    }
                }
            }


            Console.WriteLine("Aperte qual tecla para encerrar");

            

        }
    }
}
