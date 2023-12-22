using System.Runtime.Intrinsics.Arm;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:"); // Pedi para o user digitar a placa
            string novaPlaca = Console.ReadLine();                               // Criei uma string lendo o que foi digitado pelo user
            Console.WriteLine($"A {novaPlaca} foi adicionada");                  // Informado ao cliente que a placa foi adcionada com sucesso!
            veiculos.Add(novaPlaca);                                             // Placa adicionada a lista de veiculos
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");   // user digita a placa
            string placa = Console.ReadLine();                              // placa digitada adicionada a string "placa"   
            


            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {

                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:"); // Pedido para digitar a QTD em horas
                    string horas = Console.ReadLine();                                                   // leitura do que foi digitado
                    int novaHora = int.Parse(horas);                                                     // add o inteiro da variavel horas na nova hora

                    decimal valorTotal = (precoInicial+precoPorHora)*novaHora;                          // calculo
                        veiculos[0]= placa;                                                              // removendo o video da lista 
                        veiculos.RemoveAt(0);                                                           // removendo o video da lista 

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}"); //informado o valor 
            
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

   public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                
               {foreach(string placa in veiculos)
               Console.WriteLine(placa);}
               
                
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}