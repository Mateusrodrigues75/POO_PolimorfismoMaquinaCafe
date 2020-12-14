using System;
using POO_PolimorfismoMaquinaCafe.classes;

namespace POO_PolimorfismoMaquinaCafe
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaCafe novoCafe = new MaquinaCafe();
            Console.WriteLine("-----Bem Vindo a Máquina de Café-----");
            Console.WriteLine("Digite a quantidade de açúcar que você deseja em seu café: \nObs: em gramas");
            novoCafe.quantacucar = int.Parse(Console.ReadLine());

            
            
            if (novoCafe.quantacucar == 0)
            {
                novoCafe.FazerCafe();
            }else
            {
            novoCafe.FazerCafe(novoCafe.quantacucar, novoCafe.acucarDisponivel);
            }




        }
    }
}
