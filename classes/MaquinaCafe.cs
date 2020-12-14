using System;

namespace POO_PolimorfismoMaquinaCafe.classes
{
    public class MaquinaCafe
    {
        public int acucarDisponivel = 1000;
        public int quantacucar;

        public void FazerCafe(int acucarDisponivel, int quantacucar){
            if (quantacucar > acucarDisponivel)
            {
                Console.WriteLine("Quantidade superior a disponível na máquina. Chamar o técnico para encher reservatório de Açúcar");
                quantacucar = 0;
            }if (acucarDisponivel == 0)
            {
                Console.WriteLine("Máquina sem açucar! Fazendo café sem açucar...");
                quantacucar = 0;
            }
            acucarDisponivel =- quantacucar;
            Console.WriteLine("Fazendo Café...");

        }

        public void FazerCafe(){
        Console.WriteLine("Fazendo Café...");


        }
    }
}