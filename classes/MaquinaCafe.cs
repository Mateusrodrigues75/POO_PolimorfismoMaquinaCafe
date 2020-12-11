using System;

namespace POO_PolimorfismoMaquinaCafe.classes
{
    public class MaquinaCafe
    {
        public int acucarDisponivel = 1000;

        public int quantacucar;


        public void FazerCafe(int acucarDisponivel){
            Console.WriteLine("Digite a quantidade de açucar desejada: \nObs: Em gramas");
            quantacucar = int.Parse(Console.ReadLine());
            

            if (quantacucar > acucarDisponivel)
            {
                Console.WriteLine("Quantidade superior a disponível na máquina. Chamar o técnico para encher reservatório de Açúcar\nAdicionando 10g de açucar");
            }
            acucarDisponivel =- quantacucar;
            Console.WriteLine("Fazendo Café...");

        }

        public void FazerCafe(){
        quantacucar = 10;
        Console.WriteLine("Fazendo Café...");


        }
    }
}